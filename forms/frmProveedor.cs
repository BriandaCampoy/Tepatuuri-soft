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
    public partial class frmProveedor : origen
    {
        int ids;
        byte forma;
        public frmProveedor()
        {
            InitializeComponent();
            forma=1;
            ids=0;
        }
        public frmProveedor(int id, string nombre, string telefono, string direccion)
        {
            InitializeComponent();
            txtnombre.Text = nombre;
            txtdireccion.Text = direccion;
            txttelefono.Text = telefono;
            ids = id;
            forma =2;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtnombre.Text.Trim()==""||txtdireccion.Text.Trim()==""||txttelefono.Text.Trim()=="")
                {
                  MessageBox.Show("No puede dejar esos campos vacios", "Error de formulario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                CONEXION.proveedor(forma, ids, txtnombre.Text, txtdireccion.Text, txttelefono.Text);
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
