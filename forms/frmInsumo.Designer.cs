﻿namespace tepatuuri_soft.forms
{
    partial class frmInsumo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnaddprov = new System.Windows.Forms.Button();
            this.comboprov = new System.Windows.Forms.ComboBox();
            this.rdnuevo = new System.Windows.Forms.RadioButton();
            this.rdexistente = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnaddprov);
            this.groupBox1.Controls.Add(this.comboprov);
            this.groupBox1.Controls.Add(this.rdnuevo);
            this.groupBox1.Controls.Add(this.rdexistente);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 78);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor:";
            // 
            // btnaddprov
            // 
            this.btnaddprov.Enabled = false;
            this.btnaddprov.Location = new System.Drawing.Point(284, 41);
            this.btnaddprov.Name = "btnaddprov";
            this.btnaddprov.Size = new System.Drawing.Size(124, 23);
            this.btnaddprov.TabIndex = 3;
            this.btnaddprov.Text = "Crear Proveedor";
            this.btnaddprov.UseVisualStyleBackColor = true;
            this.btnaddprov.Click += new System.EventHandler(this.btnaddprov_Click);
            // 
            // comboprov
            // 
            this.comboprov.FormattingEnabled = true;
            this.comboprov.Location = new System.Drawing.Point(107, 43);
            this.comboprov.Name = "comboprov";
            this.comboprov.Size = new System.Drawing.Size(138, 21);
            this.comboprov.TabIndex = 2;
            // 
            // rdnuevo
            // 
            this.rdnuevo.AutoSize = true;
            this.rdnuevo.Location = new System.Drawing.Point(284, 20);
            this.rdnuevo.Name = "rdnuevo";
            this.rdnuevo.Size = new System.Drawing.Size(124, 17);
            this.rdnuevo.TabIndex = 1;
            this.rdnuevo.Text = "Proveedor Nuevo";
            this.rdnuevo.UseVisualStyleBackColor = true;
            this.rdnuevo.CheckedChanged += new System.EventHandler(this.rdnuevo_CheckedChanged_1);
            // 
            // rdexistente
            // 
            this.rdexistente.AutoSize = true;
            this.rdexistente.Checked = true;
            this.rdexistente.Location = new System.Drawing.Point(107, 20);
            this.rdexistente.Name = "rdexistente";
            this.rdexistente.Size = new System.Drawing.Size(140, 17);
            this.rdexistente.TabIndex = 0;
            this.rdexistente.TabStop = true;
            this.rdexistente.Text = "Proveedor existente";
            this.rdexistente.UseVisualStyleBackColor = true;
            this.rdexistente.CheckedChanged += new System.EventHandler(this.rdexistente_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Contenido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(148, 299);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 32);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(325, 299);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 32);
            this.btnAceptar.TabIndex = 35;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Agregar Insumo:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(113, 221);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(434, 21);
            this.txtdescripcion.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Descripcion:";
            // 
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(113, 261);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(122, 21);
            this.txtContenido.TabIndex = 29;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(113, 81);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(234, 21);
            this.txtnombre.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre:";
            // 
            // frmInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "frmInsumo";
            this.Text = "Insumo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnaddprov;
        private System.Windows.Forms.ComboBox comboprov;
        private System.Windows.Forms.RadioButton rdnuevo;
        private System.Windows.Forms.RadioButton rdexistente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;

    }
}