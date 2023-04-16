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
    public partial class frmAddProductos : origen
    {
        public frmAddProductos(List<CONEXION.productos> listaactual)
        {
            InitializeComponent();
            carrito = new List<CONEXION.productos>();
            List<CONEXION.productos> listprovisiona = new List<CONEXION.productos>();
            listprovisiona.AddRange(listaactual);
            carrito.AddRange(listprovisiona);
            listarprod(listprovisiona,"");
            this.listaactual = listaactual;
            Lista_acciones.Items.Add("Productos del pedido:");
            recalcular();
        }
        List<CONEXION.productos> listaactual;
        List<CONEXION.productos> pg;
        List<CONEXION.productos> carrito;
        double total = 0;
        void listarprod(List<CONEXION.productos> listaactual, string parametro)
        {
            try
            {
                viewproductos.Items.Clear();
               pg = new List<CONEXION.productos>();
               DataTable dt = CONEXION.Listar(2, parametro);
               bool provisional;
               foreach (DataRow item in dt.Rows)
               {
                   CONEXION.productos producto = new CONEXION.productos();
                   provisional = false;
                   ListViewItem vi = new ListViewItem(item[1].ToString());
                   comboproductos.Items.Add(item[1].ToString());
                   vi.SubItems.Add(item[4].ToString());
                   for (int i = 0; i < listaactual.Count; i++)
                   {
                       if(listaactual[i].idproducto==Convert.ToInt32(item[0]))
                       {
                           vi.SubItems.Add(listaactual[i].cantidad.ToString());
                           producto.cantidad = listaactual[i].cantidad;
                           listaactual.RemoveAt(i);
                           provisional = true;
                           break;
                       }
                   }
                   if (!provisional) 
                   { vi.SubItems.Add("0"); 
                       producto.cantidad =0;
                   }
                   vi.SubItems.Add(item[5].ToString());
                   viewproductos.Items.Add(vi);

                   producto.idproducto = Convert.ToInt32(item[0].ToString());
                   producto.nombre = item[1].ToString();
                   producto.contenido = item[4].ToString();
                   producto.precio = Convert.ToDouble(item[5]);
                   pg.Add(producto);

               }
            }
            catch (Exception)
            {
               // throw;
                MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        public void recalcular()
        {
            total = 0;
            Lista_acciones.Items.Clear();
            Lista_acciones.Items.Add("Productos del pedido:");
            foreach (var item in carrito)
            {
                Lista_acciones.Items.Add(item.nombre + " de " + item.contenido);
                Lista_acciones.Items.Add(item.precio + " * " + item.cantidad + " = " + item.precio * item.cantidad);
                total += item.precio*item.cantidad;
            }

            Decimal totaldecimal = Convert.ToDecimal(total);
            string stringtotal = string.Format("{0:C}", totaldecimal);
            lbltotal.Text = "El total del pedido es: " + stringtotal;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n1 = viewproductos.SelectedItems[0].Index;
            CONEXION.productos pd = new CONEXION.productos();
            pd.idproducto = pg[n1].idproducto;
            pd.nombre = pg[n1].nombre;
            pd.contenido = pg[n1].contenido;
            pd.cantidad = (int)numcant.Value;
            pd.precio = pg[n1].precio;
            pg.RemoveAt(n1);
            pg.Insert(n1, pd);
            bool provisional = true;
            for (int i = 0; i < carrito.Count; i++)
            {
                if(pg[n1].idproducto==carrito[i].idproducto)
                {
                    if (pg[n1].cantidad <= 0)
                    {
                        carrito.RemoveAt(i);
                    }
                    else {
                        carrito.RemoveAt(i);
                        carrito.Insert(i, pd);
                    }
                    provisional = false;
                    break;
                }
            }

            if (provisional)
            { carrito.Add(pd); }
           
            viewproductos.Items[n1].SubItems[2].Text = pd.cantidad.ToString();
            recalcular();
        }

     

        private void viewproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int n1 = viewproductos.SelectedItems[0].Index;
                lblprod.Text = pg[n1].nombre + " de \n" + pg[n1].contenido;
                numcant.Value = pg[n1].cantidad;
                btnAgregar.Enabled = true;
            }
            catch (Exception)
            {
                lblprod.Text = "Seleccione un producto"; 
                btnAgregar.Enabled = false;
                numcant.Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<CONEXION.productos> lp1 = new List<CONEXION.productos>();
            lp1.AddRange(listaactual);
            listarprod(lp1, comboproductos.Text);
        }

        private void frmAddProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            CONEXION.envio = carrito;
        }
    }
}
