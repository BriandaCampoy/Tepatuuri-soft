namespace tepatuuri_soft.forms
{
    partial class frmFormularioPedido
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltotalpedido = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.button9 = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.viewproductos = new System.Windows.Forms.ListView();
            this.producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cont = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio_unitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btncrearclnt = new System.Windows.Forms.Button();
            this.comboclientes = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltotalpedido);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.txtnota);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.datepicker);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.btnquitar);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.viewproductos);
            this.groupBox2.Controls.Add(this.btncrearclnt);
            this.groupBox2.Controls.Add(this.comboclientes);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 461);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar pedido:";
            // 
            // lbltotalpedido
            // 
            this.lbltotalpedido.AutoSize = true;
            this.lbltotalpedido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpedido.Location = new System.Drawing.Point(9, 210);
            this.lbltotalpedido.Name = "lbltotalpedido";
            this.lbltotalpedido.Size = new System.Drawing.Size(154, 18);
            this.lbltotalpedido.TabIndex = 26;
            this.lbltotalpedido.Text = "Total del pedido:";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(90, 419);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(101, 29);
            this.button10.TabIndex = 25;
            this.button10.Text = "Cancelar";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // txtnota
            // 
            this.txtnota.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnota.Location = new System.Drawing.Point(9, 363);
            this.txtnota.Multiline = true;
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(291, 50);
            this.txtnota.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha de entrega del pedido:";
            // 
            // datepicker
            // 
            this.datepicker.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepicker.Location = new System.Drawing.Point(9, 318);
            this.datepicker.MinDate = new System.DateTime(2021, 5, 18, 15, 13, 11, 0);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(263, 21);
            this.datepicker.TabIndex = 21;
            this.datepicker.Value = new System.DateTime(2021, 5, 18, 15, 13, 11, 0);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(197, 419);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 29);
            this.button9.TabIndex = 20;
            this.button9.Text = "Añadir";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnquitar.Enabled = false;
            this.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitar.Location = new System.Drawing.Point(158, 237);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(140, 46);
            this.btnquitar.TabIndex = 19;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = false;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(8, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 46);
            this.button7.TabIndex = 18;
            this.button7.Text = "Agregar o modificar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Productos del pedido:";
            // 
            // viewproductos
            // 
            this.viewproductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.producto,
            this.cont,
            this.cant,
            this.Precio_unitario});
            this.viewproductos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewproductos.FullRowSelect = true;
            this.viewproductos.Location = new System.Drawing.Point(9, 99);
            this.viewproductos.MultiSelect = false;
            this.viewproductos.Name = "viewproductos";
            this.viewproductos.Size = new System.Drawing.Size(292, 108);
            this.viewproductos.TabIndex = 16;
            this.viewproductos.UseCompatibleStateImageBehavior = false;
            this.viewproductos.View = System.Windows.Forms.View.Details;
            this.viewproductos.SelectedIndexChanged += new System.EventHandler(this.viewproductos_SelectedIndexChanged);
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            this.producto.Width = 88;
            // 
            // cont
            // 
            this.cont.Text = "Contenido";
            this.cont.Width = 73;
            // 
            // cant
            // 
            this.cant.Text = "Cantidad";
            this.cant.Width = 65;
            // 
            // Precio_unitario
            // 
            this.Precio_unitario.Text = "PrecioUnitario";
            // 
            // btncrearclnt
            // 
            this.btncrearclnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btncrearclnt.Enabled = false;
            this.btncrearclnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrearclnt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearclnt.Location = new System.Drawing.Point(174, 49);
            this.btncrearclnt.Name = "btncrearclnt";
            this.btncrearclnt.Size = new System.Drawing.Size(124, 23);
            this.btncrearclnt.TabIndex = 15;
            this.btncrearclnt.Text = "Crear Cliente";
            this.btncrearclnt.UseVisualStyleBackColor = false;
            this.btncrearclnt.Click += new System.EventHandler(this.btncrearclnt_Click);
            // 
            // comboclientes
            // 
            this.comboclientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboclientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboclientes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboclientes.FormattingEnabled = true;
            this.comboclientes.Location = new System.Drawing.Point(9, 49);
            this.comboclientes.Name = "comboclientes";
            this.comboclientes.Size = new System.Drawing.Size(159, 21);
            this.comboclientes.TabIndex = 14;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(176, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cliente Nuevo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(9, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(121, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cliente existente";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // frmFormularioPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 475);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFormularioPedido";
            this.Text = "Formulario pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFormularioPedido_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltotalpedido;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datepicker;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView viewproductos;
        private System.Windows.Forms.ColumnHeader producto;
        private System.Windows.Forms.ColumnHeader cont;
        private System.Windows.Forms.ColumnHeader cant;
        private System.Windows.Forms.ColumnHeader Precio_unitario;
        private System.Windows.Forms.Button btncrearclnt;
        private System.Windows.Forms.ComboBox comboclientes;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}