using EASYPOS.Controladores;
using EASYPOS.Entidades;
using EASYPOS.Formularios.POS;
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
        public Cuotas cuota = new Cuotas();
        Boolean seleccion = false,pago=false;
        Boolean cotizaciones = false;
        public FContratos(Boolean seleccion=false,Boolean cotizaciones=false, Boolean pago=false)
        {
            this.seleccion = seleccion;
            this.cotizaciones = cotizaciones;
            this.pago = pago;
            InitializeComponent();
        }

        private void FContratos_Load(object sender, EventArgs e)
        {
            cargar();
            if (seleccion )
                button2.Visible = false;

            if (cotizaciones)
            {
                label1.Text = "Cotizaciones realizadas";
            }
            if (pago)
            {
                button1.Enabled = false;
                label1.Text = "Seleccion un contrato";
            }
        }

        private void cargar()
        {
            if (cotizaciones)
                contratosBindingSource.DataSource = cContratos.Listado(true);
            else
                contratosBindingSource.DataSource = cContratos.Listado(false);

        }

        private void contratosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (seleccion)
            {
                c = (Contrato)contratosBindingSource.Current;
                
                FCuotasPagar f = new FCuotasPagar(c.IdContrato);
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
                if (f.DialogResult==DialogResult.OK)
                {
                    this.cuota = f.cuota;
                }
                

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (pago)
            {
                c = (Contrato)contratosBindingSource.Current;
                FCuotasPagar f = new FCuotasPagar(c.IdContrato, pago);
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    this.cuota = f.cuota;
                }
                //FCobroCuotaMoto f = new FCobroCuotaMoto(c);
                //f.StartPosition = FormStartPosition.CenterParent;
                //f.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {
            filtrado(this.textBoxCliente.Text);
        }

        private void contratosDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in contratosDataGridView.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                
                
                if (Convert.ToInt32(Myrow.Cells["TratoEspecial"].Value) == 1)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                    Myrow.DefaultCellStyle.ForeColor = Color.White;

                }

            }
        }

        private void filtrado(string cliente)
        {

            contratosBindingSource.DataSource = cContratos.Busqueda(cliente,false);
        }
    }
}
