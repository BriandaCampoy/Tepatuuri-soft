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

namespace tepatuuri_soft
{

    public partial class Form1 : Form
    {
        Button[,] caja;
        byte vistactual = 1;
        byte vistainv = 6;
        public DateTime FechaActual;
        public DateTime FechaCalendar;
        List<int> listaids1;
        List<int> listaids2;
        List<CONEXION.productos> listprod= new List<CONEXION.productos>();
        List<CONEXION.individuo> LClientes;
        List<CONEXION.productos> prodinv;
        double totalpedido=0;
        DataTable global;
        bool finv;
        
        public Form1()
        {
            InitializeComponent();
            FechaActual = DateTime.Today;
            FechaCalendar = DateTime.Today;
            spawncalendar(FechaActual);
            listar(1, "");
            listarclientes();
            listarinv(6, "");
            finv = true;
            datepicker.MinDate = FechaActual;
            recalculartotal();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void spawncalendar(DateTime Fecha)
        {
            try
            {
                int start = 0;
                List<string> dias = CONEXION.getCalendar(Fecha);
                DateTime pf = new DateTime(Fecha.Year, Fecha.Month, 01);
                string dia1 = pf.DayOfWeek.ToString();
                switch (dia1)
                {
                    case "Monday": start = 0; break;
                    case "Tuesday": start = 1; break;
                    case "Wednesday": start = 2; break;
                    case "Thursday": start = 3; break;
                    case "Friday": start = 4; break;
                    case "Saturday": start = 5; break;
                    case "Sunday": start = 6; break;
                }

                string month = Fecha.Month.ToString();
                switch (Fecha.Month)
                {
                    case 1: lblMes.Text = "Enero " + Fecha.Year; break;
                    case 2: lblMes.Text = "Febrero " + Fecha.Year; break;
                    case 3: lblMes.Text = "Marzo " + Fecha.Year; break;
                    case 4: lblMes.Text = "Abril " + Fecha.Year; break;
                    case 5: lblMes.Text = "Mayo " + Fecha.Year; break;
                    case 6: lblMes.Text = "Junio " + Fecha.Year; break;
                    case 7: lblMes.Text = "Julio " + Fecha.Year; break;
                    case 8: lblMes.Text = "Agosto " + Fecha.Year; break;
                    case 9: lblMes.Text = "Septiembre " + Fecha.Year; break;
                    case 10: lblMes.Text = "Octubre " + Fecha.Year; break;
                    case 11: lblMes.Text = "Noviembre " + Fecha.Year; break;
                    case 12: lblMes.Text = "Diciembre " + Fecha.Year; break;
                }

                caja = new Button[7, 6];
                int l = 7;
                int m = 74;
                int day = 1;
                int end = dias.Count;
                int c = 0;

                for (int i = 0; i < 6; i++)
                {
                    for (int k = 0; k < 7; k++)
                    {
                        caja[k, i] = new Button();
                        caja[k, i].Location = new Point(l, m);
                        caja[k, i].Text = day.ToString();
                        caja[k, i].Size = new System.Drawing.Size(140, 95);
                        //77, 61
                        caja[k, i].TextAlign = ContentAlignment.TopLeft;
                        l += 140;
                        if (start <= c && day <= end)
                        {
                            caja[k, i].Text = day.ToString() + "\n \n" + dias[day - 1];
                            if (dias[day - 1]!="")
                            {
                                caja[k, i].Text = day.ToString() + "\n\n" +"Pedidos pendientes: " +dias[day - 1];
                            }
                            caja[k, i].Tag = day.ToString(); //+ "\n " + dias[day - 1];
                            caja[k, i].Click += new EventHandler(btncaja_Click);
                            caja[k, i].FlatStyle = FlatStyle.Flat;
                            caja[k, i].BackColor = Color.FromArgb(255, 255, 255);
                            if (FechaActual == new DateTime(Fecha.Year, Fecha.Month, Convert.ToInt32(caja[k, i].Tag)))
                            {
                               // caja[k, i].FlatStyle = FlatStyle.Flat;
                               // caja[k, i].BackColor = Color.FromArgb(225, 225, 255);
                                caja[k, i].FlatAppearance.BorderSize = 3;
                                caja[k, i].FlatAppearance.BorderColor = Color.Black;
                            }
                            calendar.Controls.Add(caja[k, i]);
                            day++;
                        }
                        c++;
                    }
                    l = 7;
                    m += 95;
                }
            }
            catch (Exception)
            {
                  MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // throw;
            }
           
        
        }

        private void d11_MouseHover(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int wh = this.Size.Width;
            int ww = this.Size.Height;

            int w = (77 / 874) * wh;
            int h = (61 / 500) * ww;
          
                  //  caja[6, 4].Width =  w;
                  //  caja[6, 4].Height = h;
                    caja[6, 4].Size = new System.Drawing.Size(w, h);
                    calendar.Controls.Add(caja[6, 4]);
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listar(1,"");
            vistactual = 1;
             cambiarvista("Cliente");
        }

        public void listar(byte numvista,string parametro)
        {

            try
            {
            DataTable tabla = CONEXION.Listar(numvista, parametro);
            global = CONEXION.Listar(numvista, parametro);
            listaids1 = new List<int>();
            listview.Clear();
            combobox.Items.Clear();
            int sizecoluma = 800 / tabla.Columns.Count;
            for (int i = 1; i < tabla.Columns.Count; i++)
            {
                listview.Columns.Add(tabla.Columns[i].ToString(), sizecoluma);
            }
            foreach (DataRow item in tabla.Rows)
            {
                listaids1.Add(Convert.ToInt32(item[0]));
                ListViewItem it = new ListViewItem(item[1].ToString());
                combobox.Items.Add(item[1].ToString());
                for (int i = 2; i < tabla.Columns.Count; i++)
                {
                    it.SubItems.Add(item[i].ToString());
                }
                listview.Items.Add(it);
            }
            }
            catch (Exception)
            {
              MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // throw;
            }
          
        }

        void listarinv(byte vista, string parametro)
        { 
        
           try
            {
                DataTable lst = CONEXION.Listar(vista, parametro);
                viewinv.Items.Clear();
                listaids2 = new List<int>();
                listaids2.Clear();
                comboinv.Items.Clear();
                viewre.Items.Clear();
                prodinv = new List<CONEXION.productos>();

                foreach (DataRow item in lst.Rows)
                {
                    CONEXION.productos p1 = new CONEXION.productos();
                    listaids2.Add(Convert.ToInt32(item[0].ToString()));
                    p1.idproducto = Convert.ToInt32(item[0].ToString());
                    ListViewItem it = new ListViewItem(item[1].ToString());
                    p1.nombre = item[1].ToString();
                    comboinv.Items.Add(item[1].ToString());
                    it.SubItems.Add(item[2].ToString());
                    p1.contenido = item[2].ToString();
                    it.SubItems.Add(item[3].ToString());
                    p1.cantidad = Convert.ToInt16(item[3].ToString());
                    viewinv.Items.Add(it);
                    prodinv.Add(p1);
                    if (Convert.ToInt32(item[3].ToString()) <= 0)
                    {
                        ListViewItem reit = new ListViewItem(item[1].ToString());
                        reit.SubItems.Add(item[2].ToString());
                        reit.SubItems.Add(item[3].ToString());
                        viewre.Items.Add(reit);
                    }
                }
            }
            catch (Exception)
           {
              MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listar(4, "");
            vistactual = 4;
            cambiarvista("Proveedor");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listar(2, "");
            vistactual = 2;
            cambiarvista("Producto");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listar(3, "");
            vistactual = 3;
            cambiarvista("Insumo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listar(vistactual, combobox.Text);
        }

        public void cambiarvista(string n)
        {
            if (n == "Proveedor")
            { group.Text = n + "es"; }
            else {group.Text = n + "s"; }
            lbl1.Text = "Buscar " + n + ":";
            btnadd.Text = "Añadir " + n;
            btnmod.Text = "Modificar " + n;
            btndlt.Text = "Eliminar " + n;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            switch (vistactual)
            {
                case 1:
                    forms.frmCliente cliente = new forms.frmCliente();
                    cliente.ShowDialog();
                    listarclientes();
                   // listar(1,"");
                    break;
                case 2:
                    forms.frmProducto producto = new forms.frmProducto();
                    producto.ShowDialog();
                    if(finv)
                    { listarinv(6, ""); }
                   // listar(2, "");
                    break;
                case 3:
                    forms.frmInsumo insumo = new forms.frmInsumo();
                    insumo.ShowDialog();
                    if (!finv)
                    { listarinv(5, ""); }
                   // listar(3, "");
                    break;
                case 4:
                    forms.frmProveedor proveedor = new forms.frmProveedor();
                    proveedor.ShowDialog();
                    //listar(4, "");
                    break;
            }
            listar(vistactual, "");
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro que quiere eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                try
                {
                    int idselect = listview.SelectedItems[0].Index;
                    DataRow row = global.Rows[idselect];
                    int ids = Convert.ToInt32(row[0]);
                    switch (vistactual)
                    {
                        case 1://cliente
                            CONEXION.cliente(3, ids, "", "", "", "");
                            break;
                        case 2://producto
                            CONEXION.producto(3, ids, "", 0, "", "", "",0);
                            break;
                        case 3://insumo
                            CONEXION.insumo(3, ids, "", 0, "", "");
                            break;
                        case 4://proveedor
                            CONEXION.proveedor(3, ids, "", "", "");
                            break;
                    }
                    listar(vistactual, "");
                    listarinv(vistainv, "");
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("No se puede borrar ese registro porque se encuentra vinculado a otros registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            //modificar
            int idselect = listview.SelectedItems[0].Index;
            DataRow row = global.Rows[idselect];
            int ids = Convert.ToInt32(row[0]);
            try
            {
                List<string> datos = CONEXION.obDatos(vistactual, ids);
                CONEXION.individuo prov = new CONEXION.individuo();
            switch (vistactual)
            {
                case 1:
                    forms.frmCliente cnt = new forms.frmCliente(ids,datos[0],datos[1],datos[2],datos[3]);
                    cnt.ShowDialog();
                    break;
                case 2:
                    if (datos[1] != "")
                    {
                        prov.idindividuo = Convert.ToInt32(datos[1]);
                    }
                    else { prov.idindividuo = 0; }
                    forms.frmProducto prd = new forms.frmProducto(ids,datos[0],prov,datos[3],datos[4],datos[5],Convert.ToDouble(datos[6]));
                    prd.ShowDialog();
                    break;
                case 3:
                    if (datos[1] != "")
                    {
                        prov.idindividuo = Convert.ToInt32(datos[1]);
                    }
                    else { prov.idindividuo = 0; }
                    prov.nombre=datos[2];
                    forms.frmInsumo ins = new forms.frmInsumo(ids, datos[0], prov, datos[3], datos[4]);
                    ins.ShowDialog();
                    break;
                case 4:
                    forms.frmProveedor prv = new forms.frmProveedor(ids,datos[0],datos[1],datos[2]);
                    prv.ShowDialog();
                    break;
            }
            listar(vistactual, "");

            }
            catch (Exception)
            {
               // MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                   comboped.Items.Add(item.nombre);
               }

            }
            catch (Exception)
            {
              MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        

        private void button5_Click_1(object sender, EventArgs e)
        {
            forms.frmCliente addcliente = new forms.frmCliente();
            addcliente.ShowDialog();
            listarclientes();
            comboclientes.SelectedIndex = comboclientes.Items.Count - 1;
            comboclientes.Enabled = true;
            btncrearclnt.Enabled = false;
        }

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
        void resetcampos()
        {
            radioButton1.Checked = true;
            comboclientes.ResetText();
            viewproductos.Items.Clear();
            datepicker.ResetText();
            txtnota.Text = "";
            listprod.Clear();
            recalculartotal();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resetcampos();
        }
     
        private void button5_Click_2(object sender, EventArgs e)
        {
            foreach (var item in caja)
            {
                item.Dispose(); 
            }
            FechaCalendar = FechaCalendar.AddMonths(1);
            spawncalendar(FechaCalendar);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (var item in caja)
            {
                item.Dispose();
            }
            FechaCalendar = FechaCalendar.AddMonths(-1);
            spawncalendar(FechaCalendar);
        }

        private void btncaja_Click(object sender, System.EventArgs e)
        {
            DateTime dias = new DateTime(FechaCalendar.Year, FechaCalendar.Month, Convert.ToInt32(this.ActiveControl.Tag));
            forms.frmPedidos formpedidos = new forms.frmPedidos(dias);
            if (formpedidos.listpedidos.Count == 0)
            {
                MessageBox.Show("No hay pedidos que mostrar de este dia", "Pedidos inexistentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                formpedidos.Dispose();
            }
            else
            {
                formpedidos.ShowDialog();
                foreach (var item in caja)
                {
                    item.Dispose();
                }
                spawncalendar(FechaCalendar);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (listprod.Count > 0 && comboclientes.SelectedIndex!=-1)
                {
                    int idcliente = LClientes[comboclientes.SelectedIndex].idindividuo;
                    DateTime fechaped = datepicker.Value;
                    CONEXION.hacerpedido(1, idcliente, listprod, fechaped, txtnota.Text, totalpedido);
                    resetcampos();
                    foreach (var item in caja)
                    {
                        item.Dispose();
                    }
                    spawncalendar(FechaCalendar);
                }
                else { MessageBox.Show("Asegurese llenar todos los campos y agregar productos al pedido", "Error al guardar pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                 }
                catch (Exception)
                 {
                     MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                 }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            forms.frmAddProductos ap = new forms.frmAddProductos(listprod);
            ap.ShowDialog();
            listprod.Clear();
            listprod.AddRange(CONEXION.envio);
            recalculartotal();
            viewpedido();
        }

        void viewpedido()
        {
            viewproductos.Items.Clear();
            foreach (var item in listprod)
            {
                ListViewItem vi = new ListViewItem(item.nombre);
                vi.SubItems.Add(item.contenido);
                vi.SubItems.Add(item.cantidad.ToString());
                vi.SubItems.Add(item.precio.ToString());
                viewproductos.Items.Add(vi);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listarinv(6, "");
            vistainv = 6;
            groupBox3.Text = "Inventario de Productos";
            lblInv.Text = "Buscar Producto:";
            viewinv.Columns[0].Text = "Producto";
            viewre.Columns[0].Text = "Producto";
            lblProd1.Text = "Seleccione un producto";
            finv = true;
            btnAplicar.Enabled = false;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            listarinv(5, "");
            vistainv = 5;
            groupBox3.Text = "Inventario de Insumos";
            lblInv.Text = "Buscar Insumo:";
            viewinv.Columns[0].Text = "Insumo";
            viewre.Columns[0].Text = "Insumo";
            lblProd1.Text = "Seleccione un insumo";
            finv = false;
            btnAplicar.Enabled = false;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (finv)
            { listarinv(6, comboinv.Text);
            vistainv = 6;
              lblProd1.Text = "Seleccione un producto";
            }
            else
            { listarinv(5, comboinv.Text);
            vistainv = 5;
              lblProd1.Text = "Seleccione un insumo";
            }
            btnAplicar.Enabled = false;

        }

        private void listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int n1 = listview.SelectedItems[0].Index;
                btnmod.Enabled = true;
                btndlt.Enabled = true;
            }
            catch (Exception)
            {
                btnmod.Enabled = false;
                btndlt.Enabled = false;
            }
        }

        private void viewinv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int n1= viewinv.SelectedItems[0].Index;
                lblProd1.Text = prodinv[n1].nombre + " de " + prodinv[n1].contenido;
                btnAplicar.Enabled = true;
            }
            catch (Exception)
            {
                if (finv)
                {lblProd1.Text = "Seleccione un producto";}
                else
                {lblProd1.Text = "Seleccione un insumo"; }
                btnAplicar.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
            int n1 = viewinv.SelectedItems[0].Index;
            lblProd1.Text = prodinv[n1].nombre + " de " + prodinv[n1].contenido;
            int ncant;

            if(radiosum.Checked)
            {
             ncant = prodinv[n1].cantidad + (int)numcant.Value;
            }
            else
            {
             ncant = prodinv[n1].cantidad - (int)numcant.Value;
            }
            if (ncant >= 0)
            {
                CONEXION.Inventario(finv, prodinv[n1].idproducto, ncant);
            }
            else
            {
                MessageBox.Show("No se puede registrar una cantidad negativa de existencias","Fuera de limite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (finv)
            { listarinv(6, "");
            lblProd1.Text = "Selecciona un producto";
            vistainv = 6;
            }
            else { listarinv(5, "");
            vistainv = 5;
            lblProd1.Text = "Selecciona un insumo";
            }
            btnAplicar.Enabled = false;
            numcant.Value = 0;
            }
            catch (Exception)
            {
                 MessageBox.Show("A ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void listview_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n1 = viewproductos.SelectedIndices[0];
            listprod.RemoveAt(n1);
            viewpedido();
            recalculartotal();
        }
        void recalculartotal()
        {
            totalpedido = 0;
            foreach (var item in listprod)
            {
                totalpedido += item.precio * item.cantidad;
            }
            decimal totaldecimal = Convert.ToDecimal(totalpedido);
            string total = string.Format("{0:C}", totaldecimal);
            lbltotalpedido.Text = "El total del pedido es: " + total;
        
        }

        private void viewproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int n1 = viewproductos.SelectedIndices[0];
                btnquitar.Enabled = true;
            }
            catch (Exception)
            {
                btnquitar.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                forms.frmPedidos pedidoxcliente = new forms.frmPedidos(LClientes[comboped.SelectedIndex]);
                if (pedidoxcliente.listpedidos.Count == 0)
                {
                    MessageBox.Show("No hay pedidos que mostrar de este cliente", "Pedidos inexistentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    pedidoxcliente.Dispose();
                }
                else
                {
                    pedidoxcliente.ShowDialog();
                    foreach (var item in caja)
                    {
                        item.Dispose();
                    }
                    spawncalendar(FechaCalendar);
                }
            }
            catch (Exception)
            {
              // throw;
                MessageBox.Show("Seleccione un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
          
        }

        private void comboped_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            reports.frmReportPedido frm = new reports.frmReportPedido(new DateTime(2021, 1, 1));
            frm.Show();
        }

        private void button15_Click_2(object sender, EventArgs e)
        {
            forms.frmSeleccionarMes mes = new forms.frmSeleccionarMes();
            mes.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            reports.frmReportReStock rst = new reports.frmReportReStock();
            rst.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            reports.frmReportInvProductos rip = new reports.frmReportInvProductos();
            rip.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            reports.frmInvInsumo rii = new reports.frmInvInsumo();
            rii.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            reports.frmReportListClientes rlc = new reports.frmReportListClientes();
            rlc.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            reports.frmReportListProveedores rlp = new reports.frmReportListProveedores();
            rlp.Show();
        }

    }
}
