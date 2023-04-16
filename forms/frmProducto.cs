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
    public partial class frmProducto : origen
    {
        List<CONEXION.individuo> provs;
        int ids;
        byte forma;
        public frmProducto()
        {
            InitializeComponent();
            obproveedores();
            forma = 1;
            ids = 0;
        }
        public frmProducto(int id, string nombre, CONEXION.individuo proveedor, string categoria, string descripcion, string contenido, double precio)
        {
            InitializeComponent();
            obproveedores();
            forma = 2;
            ids = id;
            txtnombre.Text = nombre;
            txtContenido.Text = contenido;
            txtdescripcion.Text = descripcion;
            txtcategoria.Text = categoria;
            numprecio.Value = Convert.ToDecimal(precio);
            for (int i = 0; i < provs.Count; i++)
            {
                if (proveedor.idindividuo == provs[i].idindividuo)
                {
                    comboprov.SelectedIndex = i;
                }
            }
        }


        public void obproveedores()
        {
            try
            {
                provs = CONEXION.listarindividuo(true);
                comboprov.Items.Clear();
                for (int i = 0; i < provs.Count; i++)
                {
                    comboprov.Items.Add(provs[i].nombre);
                }
            }
            catch (Exception)
            {
               MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forms.frmProveedor prov = new frmProveedor();
            prov.ShowDialog();
            obproveedores();
            comboprov.SelectedIndex=comboprov.Items.Count - 1;
            comboprov.Enabled = true;
            btnaddprov.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdexistente_CheckedChanged(object sender, EventArgs e)
        {
                comboprov.Enabled = true;
                btnaddprov.Enabled = false;

        }

        private void rdnuevo_CheckedChanged(object sender, EventArgs e)
        {
            comboprov.Enabled = false;
            btnaddprov.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtnombre.Text.Trim()==""||comboprov.SelectedIndex==-1||txtcategoria.Text.Trim()==""||txtdescripcion.Text.Trim()==""||txtContenido.Text.Trim()==""||numprecio.Value==0)
                {
                    MessageBox.Show("No puede dejar esos campos vacios", "Error de formulario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int idprov = provs[comboprov.SelectedIndex].idindividuo;
                    CONEXION.producto(forma, ids, txtnombre.Text, idprov, txtcategoria.Text, txtdescripcion.Text, txtContenido.Text,Convert.ToDouble(numprecio.Value));
                    this.Close();
                }
                
            }
            catch (Exception)
            {
                  MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
