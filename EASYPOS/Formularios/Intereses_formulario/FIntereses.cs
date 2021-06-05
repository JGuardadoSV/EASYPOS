using EASYPOS.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPOS.Formularios.Intereses_formulario
{
    public partial class FIntereses : Form
    {
        public FIntereses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FIntereses_Load(object sender, EventArgs e)
        {
            interesesBindingSource.DataSource = new CIntereses().Obtener();
        }
    }
}
