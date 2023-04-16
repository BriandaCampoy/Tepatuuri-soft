namespace tepatuuri_soft.forms
{
    partial class frmPedidos
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combopedido = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.viewproductos = new System.Windows.Forms.ListView();
            this.producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkestado = new System.Windows.Forms.CheckBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblnota = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(90, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(152, 18);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Pedidos \"Fecha\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pedido:";
            // 
            // combopedido
            // 
            this.combopedido.FormattingEnabled = true;
            this.combopedido.Location = new System.Drawing.Point(80, 54);
            this.combopedido.Name = "combopedido";
            this.combopedido.Size = new System.Drawing.Size(144, 21);
            this.combopedido.TabIndex = 2;
            this.combopedido.SelectedIndexChanged += new System.EventHandler(this.combopedido_SelectedIndexChanged);
            this.combopedido.SelectedValueChanged += new System.EventHandler(this.combopedido_SelectedValueChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(6, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(64, 16);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Cliente:";
            // 
            // viewproductos
            // 
            this.viewproductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.producto,
            this.cant,
            this.precio});
            this.viewproductos.Location = new System.Drawing.Point(15, 99);
            this.viewproductos.Name = "viewproductos";
            this.viewproductos.Size = new System.Drawing.Size(227, 228);
            this.viewproductos.TabIndex = 4;
            this.viewproductos.UseCompatibleStateImageBehavior = false;
            this.viewproductos.View = System.Windows.Forms.View.Details;
            // 
            // producto
            // 
            this.producto.Text = "Producto";
            // 
            // cant
            // 
            this.cant.Text = "Cantidad";
            // 
            // precio
            // 
            this.precio.Text = "PrecioUnitario";
            this.precio.Width = 79;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(3, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(80, 16);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Dirección:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(3, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(47, 16);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Nota:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(4, 182);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(49, 16);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Estado:";
            // 
            // checkestado
            // 
            this.checkestado.AutoSize = true;
            this.checkestado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkestado.Location = new System.Drawing.Point(73, 206);
            this.checkestado.Name = "checkestado";
            this.checkestado.Size = new System.Drawing.Size(102, 20);
            this.checkestado.TabIndex = 9;
            this.checkestado.Text = "entregado";
            this.checkestado.UseVisualStyleBackColor = true;
            this.checkestado.CheckedChanged += new System.EventHandler(this.checkestado_CheckedChanged);
            this.checkestado.Click += new System.EventHandler(this.checkestado_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(30, 233);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(86, 41);
            this.btnmodificar.TabIndex = 10;
            this.btnmodificar.Text = "Modificar pedido";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(141, 233);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(86, 42);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar pedido";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl2);
            this.flowLayoutPanel1.Controls.Add(this.lbldireccion);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(242, 65);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(89, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(46, 16);
            this.lbldireccion.TabIndex = 15;
            this.lbldireccion.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lbl3);
            this.flowLayoutPanel2.Controls.Add(this.lblnota);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 124);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(242, 55);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // lblnota
            // 
            this.lblnota.AutoSize = true;
            this.lblnota.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.Location = new System.Drawing.Point(56, 0);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(46, 16);
            this.lblnota.TabIndex = 16;
            this.lblnota.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcliente);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.checkestado);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Location = new System.Drawing.Point(250, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 281);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcliente.Location = new System.Drawing.Point(70, 13);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(46, 16);
            this.lblcliente.TabIndex = 14;
            this.lblcliente.Text = "label1";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(57, 182);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(46, 16);
            this.lbltotal.TabIndex = 17;
            this.lbltotal.Text = "label1";
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 339);
            this.Controls.Add(this.viewproductos);
            this.Controls.Add(this.combopedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPedidos";
            this.Text = "Pedidos";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combopedido;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListView viewproductos;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ColumnHeader producto;
        private System.Windows.Forms.ColumnHeader cant;
        private System.Windows.Forms.ColumnHeader precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkestado;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblnota;
        private System.Windows.Forms.Label lbltotal;

    }
}