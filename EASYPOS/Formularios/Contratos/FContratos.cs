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
using Contrato=EASYPOS.Entidades.Contratos;

namespace EASYPOS.Formularios.Contratos
{
    public partial class FContratos : Form
    {
        CContratos cContratos = new CContratos();
       public  Contrato c = new Contrato();
        Boolean seleccion = false;
        public FContratos(Boolean seleccion=false)
        {
            this.seleccion = seleccion;
            InitializeComponent();
        }

        private void FContratos_Load(object sender, EventArgs e)
        {
            cargar();
            if (seleccion)
                button2.Visible = false;
        }

        private void cargar()
        {
            contratosBindingSource.DataSource = cContratos.Listado();
        }

        private void contratosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (seleccion)
            {
                c = (Contrato)contratosBindingSource.Current;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Contrato contrato = new Contrato();
                contrato = (Contrato)contratosBindingSource.Current;
                FNuevoContrato f = new FNuevoContrato(contrato);
                f.ShowDialog();
                cargar();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FNuevoContrato f = new FNuevoContrato();
            f.ShowDialog();
            cargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
