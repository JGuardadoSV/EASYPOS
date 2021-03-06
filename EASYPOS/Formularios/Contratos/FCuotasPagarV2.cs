﻿using EASYPOS.Controladores;
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
using con = EASYPOS.Entidades.Contratos;
namespace EASYPOS.Formularios.Contratos
{
    public partial class FCuotasPagarV2 : Form
    {
        int id;
        public Cuotas cuota;
        Boolean pagar,pagartodo=false;
        decimal cacumulado = 0, iacumulado = 0;
        decimal mora = 0;
        con contrato = new con();
        DateTime FechaReferencia=DateTime.Now;
        List<Cuotas> lista = new List<Cuotas>();
        List<int> idcuotas = new List<int>();

        int especial = 0;
        public FCuotasPagarV2(int id, Boolean pagar = false)
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
            this.FechaReferencia = dateTimePickerFecha.Value;

            CCuota cCuotas = new CCuota();
            lista = cCuotas.Listado(id);
            cuotasBindingSource.DataSource = lista;
            CContratos cContratos = new CContratos();
            contrato = cContratos.uno(id);
            contratosBindingSource.DataSource = contrato;

            if (contrato.TratoEspecial == 1)
            {
                labelAviso.Visible = true;
            }

            foreach (Cuotas item in lista)
            {
                if (FechaReferencia.Date >= item.Fecha.Value.Date && item.Cancelada == 0)
                {
                    cacumulado += item.Capital.Value;
                    iacumulado += item.Intereses.Value;
                    if (FechaReferencia.Date > item.Fecha.Value.Date)
                    {
                        mora += item.Capital.Value;
                    }

                    idcuotas.Add(item.IdCuota);

                }
            }
            mora = Math.Round(mora * 0.05M,2);

            txtCapitalAlaFecha.Text = cacumulado.ToString("F");
            txtInteresesAlafecha.Text = iacumulado.ToString("F");
            txtTotal.Text = (cacumulado + iacumulado).ToString("F");
            txtmora.Text = (mora).ToString("F");


            if (contrato.Finalizado == 1)
            {
                button2.Visible = false;
            }


        }

        private void cuotasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contrato.Finalizado == 0)
            {
                cobrar();
            }




        }

        private void cobrar()
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
                    if (cuota.Cancelada == 1)
                    {

                        MessageBox.Show("Seleccione otra cuota, esta ya esta cancelada");


                    }
                    else
                    { // si es la primera fila revisar si ya esta cancelada

                            this.DialogResult = DialogResult.OK;
                            FCobroCuotaMoto f = new FCobroCuotaMoto(cuota,cacumulado,iacumulado,mora,pagartodo);
                            f.StartPosition = FormStartPosition.CenterParent;
                            f.ShowDialog();
                            this.Close();
                       
                    }

                }

            }
            else
            {
                if (cuota.Cancelada == 1)
                {
                    MessageBox.Show("Seleccione otra cuota, esta ya esta cancelada");

                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    FCobroCuotaMoto f = new FCobroCuotaMoto(cuota, cacumulado, iacumulado, mora, pagartodo);
                    f.StartPosition = FormStartPosition.CenterParent;
                    f.ShowDialog();
                    this.Close();

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

                if (DateTime.Now.Date >= fecha.Date.Date && Convert.ToInt32(Myrow.Cells[6].Value) == 0)// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }

                if (Convert.ToInt32(Myrow.Cells[2].Value) == 0 || Convert.ToInt32(Myrow.Cells[6].Value) == 1)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Green;
                }

            }
        }

        private void checkBoxCobrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            this.pagartodo = !pagartodo;
        }

        private void labelAvisos_Click(object sender, EventArgs e)
        {

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
