using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tepatuuri_soft.forms
{
    public partial class frmFormularioPedido : origen
    {
        public frmFormularioPedido(CONEXION.pedidos ped)
        {
            InitializeComponent();
            pedido = ped;
            listarclientes();
            comboclientes.SelectedItem=ped.nombrecliente;
            viewpedido();
            datepicker.Value = ped.fecha;
            txtnota.Text = ped.nota;
            recalculartotal();

            pedidoriginal = new CONEXION.pedidos();
            pedidoriginal.idpedido = ped.idpedido;
            pedidoriginal.idcliente = ped.idcliente;
            pedidoriginal.nombrecliente = ped.nombrecliente;
            pedidoriginal.nota = ped.nota;
            pedidoriginal.total = ped.total;
            pedidoriginal.direccion = ped.direccion;
            pedidoriginal.fecha = ped.fecha;
            pedidoriginal.listaproductos = new List<CONEXION.productos>();
            foreach (var item in ped.listaproductos)
            {
                pedidoriginal.listaproductos.Add(item);
            }
            datepicker.MinDate = DateTime.Today;
        }
        CONEXION.pedidos pedido;
        CONEXION.pedidos pedidoriginal;
        List<CONEXION.individuo> LClientes = new List<CONEXION.individuo>();
        //List<CONEXION.productos> listprod = new List<CONEXION.productos>();
        double totalpedido = 0;
        bool modocierre = false;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboclientes.Enabled = true;
            btncrearclnt.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboclientes.Enabled = false;
            btncrearclnt.Enabled = true;
        }

        private void btncrearclnt_Click(object sender, EventArgs e)
        {
            forms.frmCliente addcliente = new forms.frmCliente();
            addcliente.ShowDialog();
            listarclientes();
            comboclientes.SelectedIndex = comboclientes.Items.Count - 1;
            comboclientes.Enabled = true;
            btncrearclnt.Enabled = false;
        }

        void listarclientes()
        {
            try
            {
                LClientes = CONEXION.listarindividuo(false);
                comboclientes.Items.Clear();
                foreach (var item in LClientes)
                {
                    comboclientes.Items.Add(item.nombre);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void viewpedido()
        {
            viewproductos.Items.Clear();
            foreach (var item in pedido.listaproductos)
            {
                ListViewItem vi = new ListViewItem(item.nombre);
                vi.SubItems.Add(item.contenido);
                vi.SubItems.Add(item.cantidad.ToString());
                vi.SubItems.Add(item.precio.ToString());
                viewproductos.Items.Add(vi);
            }
        }
        void recalculartotal()
        {
            totalpedido = 0;
            foreach (var item in pedido.listaproductos)
            {
                totalpedido += item.precio * item.cantidad;
            }
            decimal totaldecimal = Convert.ToDecimal(totalpedido);
            string total = string.Format("{0:C}", totaldecimal);
            lbltotalpedido.Text = "El total del pedido es: " + total;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            forms.frmAddProductos ap = new forms.frmAddProductos(pedido.listaproductos);
            ap.ShowDialog();
            pedido.listaproductos.Clear();
            pedido.listaproductos.AddRange(CONEXION.envio);
            recalculartotal();
            viewpedido();
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            int n1 = viewproductos.SelectedIndices[0];
            pedido.listaproductos.RemoveAt(n1);
            viewpedido();
            recalculartotal();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (pedido.listaproductos.Count > 0 && comboclientes.SelectedIndex != -1)
                {
                int idcliente = LClientes[comboclientes.SelectedIndex].idindividuo;
                DateTime fechaped = datepicker.Value;
                CONEXION.pedidos npedido = new CONEXION.pedidos();
                npedido.idpedido = pedido.idpedido;
                npedido.idcliente = idcliente;
                npedido.fecha = fechaped;
                npedido.nota = txtnota.Text;
                npedido.estado = false;
                npedido.total = totalpedido;
                npedido.nombrecliente = LClientes[comboclientes.SelectedIndex].nombre;
                npedido.direccion = LClientes[comboclientes.SelectedIndex].direccion;
                npedido.listaproductos = pedido.listaproductos;
                CONEXION.pedido(2, npedido);
                CONEXION.pedidoenvio = npedido;
                modocierre = true;
                this.Close();
                }else
                {
                    MessageBox.Show("Asegurese llenar todos los campos y agregar productos al pedido", "Error guardar pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void viewproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int n1 = viewproductos.SelectedItems[0].Index;
                btnquitar.Enabled = true;
            }
            catch (Exception)
            {
                btnquitar.Enabled = false;
            }
        }

        private void frmFormularioPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!modocierre)
            {
                CONEXION.pedidoenvio = pedidoriginal;
            }
            
        }
    }
}
