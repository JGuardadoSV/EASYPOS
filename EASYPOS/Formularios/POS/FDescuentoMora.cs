using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPOS.Formularios.POS
{
    public partial class FDescuentoMora : Form
    {
        decimal mora;
        public decimal nuevamora;
        public FDescuentoMora(decimal mora)
        {
            this.mora = mora;
            InitializeComponent();
        }

        private void FDescuentoMora_Load(object sender, EventArgs e)
        {
            label1.Text = "Ingrese el valor de la nueva mora (Mora actual $" + mora.ToString("F")+")";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    
                    nuevamora = decimal.Parse(textBox1.Text);
                    if (nuevamora > mora || nuevamora<0)
                    {
                        MessageBox.Show("La nueva mora es superior a la actual");
                    }
                    else {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                   
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Introduzca un valor numérico");
                textBox1.Focus();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
