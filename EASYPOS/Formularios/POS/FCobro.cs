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
    public partial class FCobro : Form
    {
        public decimal total, recibe, cambio;
        public FCobro(decimal total)
        {
            this.total = total;
            InitializeComponent();
        }

        private void FCobro_Load(object sender, EventArgs e)
        {
            textBoxTotal.Text = total.ToString("C");
            textBoxTotal.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRecibe.Text.Length>0)
            {
                recibe = decimal.Parse(textBoxRecibe.Text);
                cambio = total - recibe;
                textBoxCambio.Text = cambio.ToString("C");
            }
            else
            {
                textBoxCambio.Text = "$ 0.00";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxRecibe.Text.Length==0)
            {
                MessageBox.Show(this, "Indique el efectivo recibido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cambio>0)
            {
                MessageBox.Show(this, "El efectivo recibido no es suficiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            
        }
    }
}
