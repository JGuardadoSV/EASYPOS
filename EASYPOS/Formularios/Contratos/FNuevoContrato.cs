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
using EASYPOS.Entidades;
namespace EASYPOS.Formularios.Contratos
{
    public partial class FNuevoContrato : Form
    {
        EASYPOS.Entidades.Contratos contratoUp;
        public FNuevoContrato(EASYPOS.Entidades.Contratos contrato=null)
        {
            this.contratoUp = contrato;
            InitializeComponent();
        }

        private void FNuevoContrato_Load(object sender, EventArgs e)
        {
            if (contratoUp == null)
                contratosBindingSource.AddNew();
            else
                contratosBindingSource.DataSource = contratoUp;

        
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CContratos cContratos = new CContratos();
            EASYPOS.Entidades.Contratos contrato = new EASYPOS.Entidades.Contratos();
            contrato = (EASYPOS.Entidades.Contratos)contratosBindingSource.Current;
            cContratos.Insertar(contrato);

            if (contratoUp==null)
                MessageBox.Show(this, "Contrato guardado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Contrato actualizado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
