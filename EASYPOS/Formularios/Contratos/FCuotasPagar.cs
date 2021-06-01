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

namespace EASYPOS.Formularios.Contratos
{
    public partial class FCuotasPagar : Form
    {
        int id;
        public Cuotas cuota;
        Boolean pagar;
        decimal cacumulado = 0, iacumulado = 0;
        decimal mora = 0;
        
        List<Cuotas> lista = new List<Cuotas>();
        List<int> idcuotas = new List<int>();
        public FCuotasPagar(int id, Boolean pagar=false)
        {
            this.pagar = pagar;
            this.id = id;
            
            InitializeComponent();
        }

        private void cuotasBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            

        }

        private void FCuotasPagar_Load(object sender, EventArgs e)
        {
            CCuota cCuotas = new CCuota();
            lista = cCuotas.Listado(id);
            cuotasBindingSource.DataSource = lista;
            CContratos cContratos = new CContratos();
            contratosBindingSource.DataSource = cContratos.uno(id);
            
            foreach (Cuotas item in lista)
            {
                if (DateTime.Now.Date>=item.Fecha.Value.Date && item.Cancelada==0)
                {
                    cacumulado +=item.Capital.Value;
                    iacumulado+=item.Intereses.Value;
                    if (DateTime.Now.Date > item.Fecha.Value.Date)
                    {
                        mora += item.Capital.Value;
                    }

                    idcuotas.Add(item.IdCuota);
                    
                }
            }
            mora = mora * 0.05M;

            txtCapitalAlaFecha.Text = cacumulado.ToString("F");
            txtInteresesAlafecha.Text = iacumulado.ToString("F");
            txtTotal.Text = (cacumulado + iacumulado).ToString("F");
            txtmora.Text = (mora).ToString("F");


        }

        private void cuotasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cobrar();

            
        }

        private void cobrar()
        {
            if (cacumulado>0)
            { // Si hay pagos pendientes
                decimal totalpago = cacumulado + iacumulado + mora;
                if (MessageBox.Show(this,"¿Va a cancelar la totalidad de lo adeudado ($"+totalpago.ToString("F")+")?\n De no hacerlo, marque el contrato para tratamiento especial","Este contrato requiere atención especial",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                    FCobroCuotaMoto f = new FCobroCuotaMoto(-1, id, idcuotas:idcuotas, cacumulado:cacumulado, iacumulado:iacumulado ,mora:mora);
                    f.StartPosition = FormStartPosition.CenterParent;
                    f.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                cuota = (Cuotas)cuotasBindingSource.Current;

                int indice = cuotasDataGridView.CurrentRow.Index;

                if (indice > 0)
                {
                    int sicancelada = int.Parse(cuotasDataGridView.Rows[indice - 1].Cells[6].Value.ToString());
                    if (sicancelada == 0)
                    {
                        MessageBox.Show("La cuota anterior a la seleccionada, no ha sido cancelada aún", "Aviso");
                    }
                    else
                    {
                        if (cuota.FechaDePago.HasValue || cuota.Cancelada == 1)
                        {

                            MessageBox.Show("Seleccione otra cuota, esta ya esta cancelada");


                        }
                        else
                        {

                            this.DialogResult = DialogResult.OK;
                            FCobroCuotaMoto f = new FCobroCuotaMoto(cuota.IdCuota, cuota.IdContrato_FK);
                            f.StartPosition = FormStartPosition.CenterParent;
                            f.ShowDialog();
                            this.Close();
                        }

                    }

                }

            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FHojaDePagos f = new FHojaDePagos(id);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void cuotasDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in cuotasDataGridView.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                DateTime fecha = Convert.ToDateTime(Myrow.Cells[1].Value);

                if (DateTime.Now.Date >= fecha.Date.Date && Convert.ToInt32(Myrow.Cells[6].Value)==0)// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }

                if (Convert.ToInt32(Myrow.Cells[2].Value) == 0 || Convert.ToInt32(Myrow.Cells[6].Value) == 1)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Green;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Myrow in cuotasDataGridView.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToInt32(Myrow.Cells[6].Value) == 0)
                {
                    //cuotasDataGridView.Rows[Myrow.Index].Selected = true;
                    cuotasBindingSource.Position = Myrow.Index;
                    cobrar();
                    break;
                }

            }
        }
    }
}
