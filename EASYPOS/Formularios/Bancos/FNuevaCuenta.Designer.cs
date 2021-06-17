
namespace EASYPOS.Formularios.Bancos
{
    partial class FNuevaCuenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bancoLabel;
            System.Windows.Forms.Label fechaAperturaLabel;
            System.Windows.Forms.Label montoInicialLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.fechaAperturaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.montoInicialTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxTiposCuenta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            bancoLabel = new System.Windows.Forms.Label();
            fechaAperturaLabel = new System.Windows.Forms.Label();
            montoInicialLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bancoLabel
            // 
            bancoLabel.AutoSize = true;
            bancoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancoLabel.Location = new System.Drawing.Point(103, 66);
            bancoLabel.Name = "bancoLabel";
            bancoLabel.Size = new System.Drawing.Size(69, 24);
            bancoLabel.TabIndex = 1;
            bancoLabel.Text = "Banco:";
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuentasBindingSource, "Banco", true));
            this.bancoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bancoTextBox.Location = new System.Drawing.Point(203, 66);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(432, 29);
            this.bancoTextBox.TabIndex = 2;
            // 
            // fechaAperturaLabel
            // 
            fechaAperturaLabel.AutoSize = true;
            fechaAperturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaAperturaLabel.Location = new System.Drawing.Point(26, 106);
            fechaAperturaLabel.Name = "fechaAperturaLabel";
            fechaAperturaLabel.Size = new System.Drawing.Size(146, 24);
            fechaAperturaLabel.TabIndex = 3;
            fechaAperturaLabel.Text = "Fecha Apertura:";
            // 
            // fechaAperturaDateTimePicker
            // 
            this.fechaAperturaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cuentasBindingSource, "FechaApertura", true));
            this.fechaAperturaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaAperturaDateTimePicker.Location = new System.Drawing.Point(203, 106);
            this.fechaAperturaDateTimePicker.Name = "fechaAperturaDateTimePicker";
            this.fechaAperturaDateTimePicker.Size = new System.Drawing.Size(365, 29);
            this.fechaAperturaDateTimePicker.TabIndex = 4;
            // 
            // montoInicialLabel
            // 
            montoInicialLabel.AutoSize = true;
            montoInicialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montoInicialLabel.Location = new System.Drawing.Point(52, 186);
            montoInicialLabel.Name = "montoInicialLabel";
            montoInicialLabel.Size = new System.Drawing.Size(120, 24);
            montoInicialLabel.TabIndex = 7;
            montoInicialLabel.Text = "Monto Inicial:";
            // 
            // montoInicialTextBox
            // 
            this.montoInicialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuentasBindingSource, "MontoInicial", true));
            this.montoInicialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoInicialTextBox.Location = new System.Drawing.Point(203, 186);
            this.montoInicialTextBox.Name = "montoInicialTextBox";
            this.montoInicialTextBox.Size = new System.Drawing.Size(200, 29);
            this.montoInicialTextBox.TabIndex = 8;
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroLabel.Location = new System.Drawing.Point(88, 146);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(84, 24);
            numeroLabel.TabIndex = 5;
            numeroLabel.Text = "Numero:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuentasBindingSource, "Numero", true));
            this.numeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTextBox.Location = new System.Drawing.Point(203, 146);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(365, 29);
            this.numeroTextBox.TabIndex = 6;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.Location = new System.Drawing.Point(119, 226);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(53, 24);
            tipoLabel.TabIndex = 11;
            tipoLabel.Text = "Tipo:";
            // 
            // comboBoxTiposCuenta
            // 
            this.comboBoxTiposCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTiposCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTiposCuenta.FormattingEnabled = true;
            this.comboBoxTiposCuenta.Items.AddRange(new object[] {
            "Credito",
            "Cuenta de ahorros"});
            this.comboBoxTiposCuenta.Location = new System.Drawing.Point(203, 226);
            this.comboBoxTiposCuenta.Name = "comboBoxTiposCuenta";
            this.comboBoxTiposCuenta.Size = new System.Drawing.Size(200, 32);
            this.comboBoxTiposCuenta.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(26, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(220, 24);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE CUENTA";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(107, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(232, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cuentasBindingSource
            // 
            this.cuentasBindingSource.DataSource = typeof(EASYPOS.Entidades.Cuentas);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cuentasBindingSource, "MontoDisponible", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(518, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 29);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(413, 186);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 24);
            label2.TabIndex = 9;
            label2.Text = "Disponible";
            // 
            // FNuevaCuenta
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxTiposCuenta);
            this.Controls.Add(label1);
            this.Controls.Add(bancoLabel);
            this.Controls.Add(this.bancoTextBox);
            this.Controls.Add(fechaAperturaLabel);
            this.Controls.Add(this.fechaAperturaDateTimePicker);
            this.Controls.Add(label2);
            this.Controls.Add(montoInicialLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.montoInicialTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(tipoLabel);
            this.Name = "FNuevaCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Cuenta";
            this.Load += new System.EventHandler(this.FNuevaCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cuentasBindingSource;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.DateTimePicker fechaAperturaDateTimePicker;
        private System.Windows.Forms.TextBox montoInicialTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.ComboBox comboBoxTiposCuenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}