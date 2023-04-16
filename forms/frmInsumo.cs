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
    public partial class frmInsumo : origen
    {
        List<CONEXION.individuo> provs;
        byte forma;
        int ids;
        public frmInsumo()
        {
            InitializeComponent();
            obproveedores();
            forma = 1;
            ids = 0;
        }
        public frmInsumo(int id, string nombre, CONEXION.individuo proveedor, string descripcion, string contenido)
        {
            InitializeComponent();
            obproveedores();
            txtnombre.Text = nombre;
            txtContenido.Text = contenido;
            txtdescripcion.Text = descripcion;
            for (int i = 0; i < provs.Count; i++)
            {
                if (proveedor.idindividuo == provs[i].idindividuo)
                {
                    comboprov.SelectedIndex = i;
                }
            }
            forma = 2;
            ids = id;
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
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddprov_Click(object sender, EventArgs e)
        {
            forms.frmProveedor prov = new frmProveedor();
            prov.ShowDialog();
            obproveedores();
            comboprov.SelectedIndex = comboprov.Items.Count - 1;
            comboprov.Enabled = true;
            btnaddprov.Enabled = false;
        }
     

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text.Trim() == "" || comboprov.SelectedIndex==-1||txtdescripcion.Text.Trim()==""||txtContenido.Text.Trim()=="")
                {
                    MessageBox.Show("No puede dejar esos campos vacios", "Error de formulario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else{
                int idprov = provs[comboprov.SelectedIndex].idindividuo;
                CONEXION.insumo(forma, ids, txtnombre.Text, idprov, txtdescripcion.Text, txtContenido.Text);

                this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdexistente_CheckedChanged_1(object sender, EventArgs e)
        {
            comboprov.Enabled = true;
            btnaddprov.Enabled = false;
        }

        private void rdnuevo_CheckedChanged_1(object sender, EventArgs e)
        {
            comboprov.Enabled = false;
            btnaddprov.Enabled = true;
        }
    }
}
