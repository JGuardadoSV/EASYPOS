
namespace EASYPOS.Formularios.Contratos
{
    partial class FCalculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.labelCuota = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFinanciamiento = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrimaNeta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxgatos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTasaAplicada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTasa = new System.Windows.Forms.TextBox();
            this.checkBoxGastos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(156, 44);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(196, 29);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            this.txtPrecio.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMeses_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prima";
            // 
            // txtPrima
            // 
            this.txtPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrima.Location = new System.Drawing.Point(156, 80);
            this.txtPrima.Name = "txtPrima";
            this.txtPrima.Size = new System.Drawing.Size(100, 29);
            this.txtPrima.TabIndex = 3;
            this.txtPrima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            this.txtPrima.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMeses_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meses";
            // 
            // txtMeses
            // 
            this.txtMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeses.Location = new System.Drawing.Point(156, 115);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(196, 29);
            this.txtMeses.TabIndex = 5;
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            this.txtMeses.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMeses_KeyUp);
            // 
            // labelCuota
            // 
            this.labelCuota.AutoSize = true;
            this.labelCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuota.Location = new System.Drawing.Point(93, 368);
            this.labelCuota.Name = "labelCuota";
            this.labelCuota.Size = new System.Drawing.Size(230, 73);
            this.labelCuota.TabIndex = 12;
            this.labelCuota.Text = "$0.000";
            this.labelCuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(94, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(226, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 52);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Financiamiento";
            // 
            // txtFinanciamiento
            // 
            this.txtFinanciamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinanciamiento.Location = new System.Drawing.Point(156, 150);
            this.txtFinanciamiento.Name = "txtFinanciamiento";
            this.txtFinanciamiento.Size = new System.Drawing.Size(196, 29);
            this.txtFinanciamiento.TabIndex = 7;
            this.txtFinanciamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(97, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "Ver tabla de amortización";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gastos administrativos";
            // 
            // textBoxPrimaNeta
            // 
            this.textBoxPrimaNeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrimaNeta.Location = new System.Drawing.Point(226, 278);
            this.textBoxPrimaNeta.Name = "textBoxPrimaNeta";
            this.textBoxPrimaNeta.ReadOnly = true;
            this.textBoxPrimaNeta.Size = new System.Drawing.Size(183, 29);
            this.textBoxPrimaNeta.TabIndex = 11;
            this.textBoxPrimaNeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrimaNeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prima neta";
            // 
            // textBoxgatos
            // 
            this.textBoxgatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxgatos.Location = new System.Drawing.Point(16, 278);
            this.textBoxgatos.Name = "textBoxgatos";
            this.textBoxgatos.ReadOnly = true;
            this.textBoxgatos.Size = new System.Drawing.Size(196, 29);
            this.textBoxgatos.TabIndex = 9;
            this.textBoxgatos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxgatos.TextChanged += new System.EventHandler(this.textBoxgatos_TextChanged);
            this.textBoxgatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            this.textBoxgatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMeses_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tasa aplicada:";
            // 
            // txtTasaAplicada
            // 
            this.txtTasaAplicada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTasaAplicada.Location = new System.Drawing.Point(156, 311);
            this.txtTasaAplicada.Name = "txtTasaAplicada";
            this.txtTasaAplicada.ReadOnly = true;
            this.txtTasaAplicada.Size = new System.Drawing.Size(100, 29);
            this.txtTasaAplicada.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tasa de interés";
            // 
            // textBoxTasa
            // 
            this.textBoxTasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTasa.Location = new System.Drawing.Point(156, 185);
            this.textBoxTasa.Name = "textBoxTasa";
            this.textBoxTasa.Size = new System.Drawing.Size(196, 29);
            this.textBoxTasa.TabIndex = 7;
            this.textBoxTasa.TextChanged += new System.EventHandler(this.textBoxTasa_TextChanged);
            this.textBoxTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            // 
            // checkBoxGastos
            // 
            this.checkBoxGastos.AutoSize = true;
            this.checkBoxGastos.Location = new System.Drawing.Point(263, 83);
            this.checkBoxGastos.Name = "checkBoxGastos";
            this.checkBoxGastos.Size = new System.Drawing.Size(77, 17);
            this.checkBoxGastos.TabIndex = 18;
            this.checkBoxGastos.Text = "Sin Gastos";
            this.checkBoxGastos.UseVisualStyleBackColor = true;
            this.checkBoxGastos.CheckedChanged += new System.EventHandler(this.checkBoxGastos_CheckedChanged);
            // 
            // FCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 595);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxGastos);
            this.Controls.Add(this.txtTasaAplicada);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCuota);
            this.Controls.Add(this.textBoxPrimaNeta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTasa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFinanciamiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxgatos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Name = "FCalculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de cuota";
            this.Load += new System.EventHandler(this.FCalculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label labelCuota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFinanciamiento;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrimaNeta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxgatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTasaAplicada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTasa;
        private System.Windows.Forms.CheckBox checkBoxGastos;
    }
}