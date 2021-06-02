using EASYPOS.Controladores;
using EASYPOS.Entidades;
using EASYPOS.Formularios.Reportes;
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
    public partial class FContratosPaganEsteMes:Form
    {
        CContratos cContratos= new CContratos();
        
        public FContratosPaganEsteMes()
        {
           
            InitializeComponent();
        }

        private void FContratosAtrasados_Load(object sender, EventArgs e)
        {
            cargar();
            

            
        }

        private void cargar()
        {
            
                contratosBindingSource.DataSource = cContratos.ParaEsteMes();

        }

        private void contratosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Contrato c = (Contrato)contratosBindingSource.Current;


            FReporteMora f = new FReporteMora(c.IdContrato);

         //   FCuotasPagar f = new FCuotasPagar(c.IdContrato);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {
            filtrado(this.textBoxCliente.Text);
        }

        private void filtrado(string cliente)
        {

            contratosBindingSource.DataSource = cContratos.Busqueda(cliente,true);
        }
    }
}
