namespace tepatuuri_soft.forms
{
    partial class frmAddProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltotal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblprod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboproductos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numcant = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lista_acciones = new System.Windows.Forms.ListBox();
            this.viewproductos = new System.Windows.Forms.ListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contenido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numcant)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(383, 110);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(210, 18);
            this.lbltotal.TabIndex = 10;
            this.lbltotal.Text = "El total del pedido es: 0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(547, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Terminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprod.Location = new System.Drawing.Point(383, 189);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(211, 18);
            this.lblprod.TabIndex = 2;
            this.lblprod.Text = "Selecciona un producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar producto:";
            // 
            // comboproductos
            // 
            this.comboproductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboproductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboproductos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboproductos.FormattingEnabled = true;
            this.comboproductos.Location = new System.Drawing.Point(386, 160);
            this.comboproductos.Name = "comboproductos";
            this.comboproductos.Size = new System.Drawing.Size(155, 26);
            this.comboproductos.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(547, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numcant
            // 
            this.numcant.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numcant.Location = new System.Drawing.Point(509, 246);
            this.numcant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numcant.Name = "numcant";
            this.numcant.Size = new System.Drawing.Size(97, 27);
            this.numcant.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(444, 279);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 30);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad: ";
            // 
            // Lista_acciones
            // 
            this.Lista_acciones.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_acciones.FormattingEnabled = true;
            this.Lista_acciones.Location = new System.Drawing.Point(386, 12);
            this.Lista_acciones.Name = "Lista_acciones";
            this.Lista_acciones.Size = new System.Drawing.Size(273, 95);
            this.Lista_acciones.TabIndex = 1;
            // 
            // viewproductos
            // 
            this.viewproductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.contenido,
            this.cant,
            this.precio});
            this.viewproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.viewproductos.FullRowSelect = true;
            this.viewproductos.Location = new System.Drawing.Point(4, 12);
            this.viewproductos.MultiSelect = false;
            this.viewproductos.Name = "viewproductos";
            this.viewproductos.Size = new System.Drawing.Size(373, 297);
            this.viewproductos.TabIndex = 0;
            this.viewproductos.UseCompatibleStateImageBehavior = false;
            this.viewproductos.View = System.Windows.Forms.View.Details;
            this.viewproductos.SelectedIndexChanged += new System.EventHandler(this.viewproductos_SelectedIndexChanged);
            // 
            // nombre
            // 
            this.nombre.Text = "Producto";
            this.nombre.Width = 125;
            // 
            // contenido
            // 
            this.contenido.Text = "Contenido";
            this.contenido.Width = 79;
            // 
            // cant
            // 
            this.cant.Text = "Cantidad";
            this.cant.Width = 68;
            // 
            // precio
            // 
            this.precio.Text = "PrecioUnitario";
            this.precio.Width = 79;
            // 
            // frmAddProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 321);
            this.ControlBox = false;
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblprod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboproductos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numcant);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lista_acciones);
            this.Controls.Add(this.viewproductos);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(687, 360);
            this.MinimumSize = new System.Drawing.Size(687, 360);
            this.Name = "frmAddProductos";
            this.Text = "Añadir productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddProductos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numcant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView viewproductos;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader contenido;
        private System.Windows.Forms.ColumnHeader cant;
        private System.Windows.Forms.ListBox Lista_acciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numcant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboproductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader precio;
        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.Label lbltotal;
    }
}