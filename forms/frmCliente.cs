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
    public partial class frmCliente : origen
    {
        byte forma;
        int idm;
        public frmCliente()
        {
            InitializeComponent();
            forma = 1;
            idm = 0;
            //btnAceptar.Size = new Size(138, 32);
            //btnCancelar.Size = new Size(138, 32);
            //btnAceptar.Location = new Point(184, 269);
            //btnCancelar.Location = new Point(34, 269);
        }
        public frmCliente(int id, string nombre, string direccion, string telefono, string ciudad)
        {
            InitializeComponent();
            forma = 2;
            txtnombre.Text = nombre;
            txttelefono.Text = telefono;
            txtdireccion.Text = direccion;
            txtciudad.Text = ciudad;
            idm = id;
           
        
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                if(txtnombre.Text.Trim() == "" ||txtdireccion.Text.Trim()==""||txtciudad.Text.Trim()=="")
                {
                    MessageBox.Show("No puede dejar esos campos vacios", "Error de formulario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else{
            CONEXION.cliente(forma, idm, txtnombre.Text, txtdireccion.Text, txtciudad.Text, txttelefono.Text);
            this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
