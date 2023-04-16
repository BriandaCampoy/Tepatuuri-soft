using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace tepatuuri_soft.forms
{
    public partial class frmPedidos : origen
    {
        public List<CONEXION.pedidos> listpedidos;
        DateTime day;
        int valuecombo = 0;
        public frmPedidos(DateTime dia)
        {
            InitializeComponent();
            string dayweek = "";
            string mes = "";
            day = dia;
            dayweek = obdia(dia.DayOfWeek.ToString());
            mes = obmes(dia.Month);
            lbltitulo.Text = "Pedido " +dayweek+" "+ dia.Day + " de " + mes + " del " + dia.Year;
            obpedidodia();

            if (combopedido.Items.Count == 0)
            {
                return;
            }
                combopedido.SelectedIndex = 0;
                cambiarpedido(0);
            }

        public frmPedidos(CONEXION.individuo cliente)
        {
            InitializeComponent();
            listpedidos = CONEXION.Listpedidoxcliente(cliente.idindividuo);
            foreach (var item in listpedidos)
            {
                combopedido.Items.Add("#" + item.idpedido.ToString() + " de " + item.nombrecliente);
            }
            if (combopedido.Items.Count == 0)
            {
                return;
            }
            combopedido.SelectedIndex = 0;
            cambiarpedido(0);
        }

          string obmes(int month)
        {
            string mes="";
            switch (month)
            {
                case 1: mes = "Enero"; break;
                case 2: mes = "Febrero"; break;
                case 3: mes = "Marzo"; break;
                case 4: mes = "Abril"; break;
                case 5: mes = "Mayo"; break;
                case 6: mes = "Junio"; break;
                case 7: mes = "Julio"; break;
                case 8: mes = "Agosto"; break;
                case 9: mes = "Septiembre"; break;
                case 10: mes = "Octubre"; break;
                case 11: mes = "Noviembre"; break;
                case 12: mes = "Diciembre"; break;
            }
            return mes;
             }
          string obdia(string day)
          {
              string dayweek = "";
              switch (day)
              {
                  case "Monday": dayweek = "Lunes"; break;
                  case "Tuesday": dayweek = "Martes"; break;
                  case "Wednesday": dayweek = "Miercoles"; break;
                  case "Thursday": dayweek = "Jueves"; break;
                  case "Friday": dayweek = "Viernes"; break;
                  case "Saturday": dayweek = "Sabado"; break;
                  case "Sunday": dayweek = "Domingo"; break;
              }
              return dayweek;
          }

        void obpedidodia()
        {
            DataTable dt = CONEXION.Listar(7, day.Day + "/" + day.Month + "/" + day.Year);
            listpedidos = new List<CONEXION.pedidos>();
            combopedido.Items.Clear();
            foreach (DataRow item in dt.Rows)
            {
                CONEXION.pedidos pedido = new CONEXION.pedidos();
                pedido.idpedido = Convert.ToInt32(item[0]);
                pedido.idcliente = Convert.ToInt32(item[1]);
                pedido.nombrecliente = item[2].ToString();
                pedido.fecha = Convert.ToDateTime(item[3].ToString());
                pedido.nota = item[4].ToString();
                pedido.total = Convert.ToDouble(item[5]);
                pedido.direccion = item[6].ToString();
                pedido.estado = Convert.ToBoolean(item[7]);
                pedido.listaproductos = CONEXION.listaprodPed(pedido.idpedido);
                listpedidos.Add(pedido);
                combopedido.Items.Add("#" + item[0].ToString() + " de " + item[2].ToString());
            }
        
        }

      
        void cambiarpedido(int a)
        {
           
            lblcliente.Text =listpedidos[a].nombrecliente;
            lbldireccion.Text = listpedidos[a].direccion;
            lblnota.Text = listpedidos[a].nota;
            decimal totaldecimal = Convert.ToDecimal(listpedidos[a].total);
            string total = string.Format("{0:C}", totaldecimal);
            lbltotal.Text = total;
            if (listpedidos[a].estado)
            {
                checkestado.Checked = true;
                checkestado.Enabled = false;
                btnmodificar.Enabled = false;
                btncancelar.Enabled = false;
            }
            else 
            {
                checkestado.Checked = false;
                checkestado.Enabled = true;
                btnmodificar.Enabled = true;
                btncancelar.Enabled = true;
            }
            viewproductos.Items.Clear();
            foreach (var item in listpedidos[a].listaproductos)
            {
                ListViewItem it = new ListViewItem(item.nombre);
                it.SubItems.Add(item.cantidad.ToString());
                it.SubItems.Add(item.precio.ToString());
                viewproductos.Items.Add(it);
            }
            string dayw = obdia(listpedidos[a].fecha.DayOfWeek.ToString());
            string mesw = obmes(listpedidos[a].fecha.Month);
            lbltitulo.Text = "Pedido " + dayw + " " + listpedidos[a].fecha.Day + " de " + mesw + " del " +listpedidos[a].fecha.Year;
        }

       

        private void combopedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambiarpedido(combopedido.SelectedIndex);
            valuecombo = combopedido.SelectedIndex;
        }

        private void checkestado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkestado_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Este pedido ya fue entregado?", "Confirmar entrega", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                checkestado.Enabled = false;
                int n1 = combopedido.SelectedIndex;
                try
                {
                    CONEXION.pedidos npedido = new CONEXION.pedidos();
                    npedido.idpedido = listpedidos[n1].idpedido;
                    npedido.idcliente = listpedidos[n1].idcliente;
                    npedido.fecha = listpedidos[n1].fecha;
                    npedido.nota = listpedidos[n1].nota;
                    npedido.estado = true;
                    npedido.total = listpedidos[n1].total;
                    npedido.nombrecliente = listpedidos[n1].nombrecliente;
                    npedido.direccion = listpedidos[n1].direccion;
                    npedido.listaproductos = listpedidos[n1].listaproductos;
                    CONEXION.pedido(2,npedido);
                    listpedidos.RemoveAt(n1);
                    listpedidos.Insert(n1, npedido);
                    btnmodificar.Enabled = false;
                    btncancelar.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {checkestado.Checked = false;  }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
                forms.frmFormularioPedido fp = new frmFormularioPedido(listpedidos[valuecombo]);
                fp.ShowDialog();
                listpedidos.RemoveAt(valuecombo);
                listpedidos.Insert(valuecombo, CONEXION.pedidoenvio);
                cambiarpedido(valuecombo);
                combopedido.Items.Clear();
                foreach (var item in listpedidos)
                {
                    combopedido.Items.Add("#" + item.idpedido.ToString() + " de " + item.nombrecliente);
                }
                combopedido.SelectedIndex = valuecombo;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que quiere cancelar este pedido?", "Cancelar pedido", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                CONEXION.pedido(3, listpedidos[valuecombo]);
                listpedidos.RemoveAt(valuecombo);
                if (listpedidos.Count == 0)
                {
                    MessageBox.Show("El pedido fue cancelado correctamente, pero no hay mas pedidos que mostrar", "Pedido cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El pedido fue cancelado correctamente", "Pedido cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    combopedido.Items.Clear();
                    foreach (var item in listpedidos)
                    {
                        combopedido.Items.Add("#" + item.idpedido.ToString() + " de " + item.nombrecliente);
                    }
                    combopedido.SelectedIndex = 0;
                    valuecombo = 0;
                    cambiarpedido(valuecombo);
                }
            }
        }

        private void combopedido_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}
