﻿using EASYPOS.Controladores;
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
using contrato = EASYPOS.Entidades.Contratos;
using EASYPOS.Formularios.Reportes;
using EASYPOS.Formularios.POS;
using ESC_POS_USB_NET.Printer;

namespace EASYPOS.Formularios.Contratos
{
    public partial class FNuevoContrato : Form
    {
        contrato contratoUp, contraton = new contrato();
        public FNuevoContrato(EASYPOS.Entidades.Contratos contrato = null)
        {
            this.contratoUp = contrato;
            InitializeComponent();
        }

        private void FNuevoContrato_Load(object sender, EventArgs e)
        {

            CCuenta cCuenta = new CCuenta();
            cuentasBindingSource.DataSource = cCuenta.Listado();

            

            if (contratoUp == null)
            {
                //contraton.Meses = 18;
                //contraton.GastosEscritura = 0;
                //// contraton.PrimaNeta = 0;
                // contraton.PrimaInicial = contraton.PrimaNeta;
                contraton.Estado = 1;
                contratosBindingSource.Add(contraton);
               button5.Visible = false;

                bancoLabel2.Visible = false;


            }
            else
            {
                
                if (contratoUp.IdCuenta_FK !=null)
                {
                    bancoLabel2.Visible = true;
                }
                else
                {
                    bancoLabel2.Visible = false;
                }
                CContratos c = new CContratos();
                contratoUp = c.uno(contratoUp.IdContrato);
                contratosBindingSource.DataSource = contratoUp;
                if (contratoUp.Estado == 1)
                {
                    estadoCheckBox.Checked = true;

                }

                else
                {
                    estadoCheckBox.Checked = false;
                    estadoCheckBox.Visible = false;
                    datosgenerales.Controls["labelestado"].Visible = false;
                    //button4.Visible = false;

                }

                if (contratoUp.Estado == 1)
                {
                    button5.Visible = false;
                }

                COtrosPagos cOtros = new COtrosPagos();
                otrosPagosBindingSource.DataSource = cOtros.Listado(contratoUp.IdContrato);

                if (contratoUp.Finalizado==1)
                {
                    button1.Visible = false;
                    button2.Visible = false;
                    button4.Visible = false;
                    
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardar();




        }

        private void guardar(bool cerrar=true)
        {
            contratosBindingSource.EndEdit();
            CContratos cContratos = new CContratos();
            contrato contrato = new contrato();
            contrato = (EASYPOS.Entidades.Contratos)contratosBindingSource.Current;

            if (idCuenta_FKComboBox.SelectedIndex>0)
            {
                Cuentas cuentas = new Cuentas();
                cuentas = (Cuentas)cuentasBindingSource.Current;
                contrato.IdCuenta_FK = cuentas.IdCuenta;
            }
            if (contrato.Precio == 0 || contrato.Cuota == 0 || contrato.Financiamiento == 0 || contrato.Prima == 0 || contrato.Meses == 0)
            {
                MessageBox.Show("Para guardar, debe de rellenar los datos del financiamiento");
                return;
            }




            if (contrato.FechaInicio == null)
            {
                //MessageBox.Show("Seleccione la fecha de inicio");
                contrato.FechaInicio = DateTime.Now;
            }
            else
            {
                if (estadoCheckBox.Checked)
                    contrato.Estado = 1;
                else
                    contrato.Estado = 0;

                int idcontrato = cContratos.Insertar(contrato);

                if (contratoUp == null)
                {
                    generarTabla(contrato.Financiamiento.Value, contrato.Meses, contrato.FechaInicio.Value, contrato.Tasa, idcontrato, contrato.Prima.Value);
                    MessageBox.Show(this, "Contrato guardado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    CCuota c = new CCuota();
                    int cu;
                    cu = c.Listado(contratoUp.IdContrato).Count;
                    if (cu == 0)
                    {
                        generarTabla(contrato.Financiamiento.Value, contrato.Meses, contrato.FechaInicio.Value, contrato.Tasa, idcontrato, contrato.Prima.Value);
                    }
                    MessageBox.Show(this, "Contrato actualizado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (cerrar)
                {
                    this.Close();
                }

               

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = decimal.Parse(precioTextBox.Text.Trim());
                int meses = int.Parse(mesesTextBox.Text);
                decimal cuota = Math.Round(monto / meses, 2);
                decimal tasa = decimal.Parse(textBox9.Text.Trim());
                DateTime fecha = fechaInicioDateTimePicker.Value;
                decimal prima = decimal.Parse(primaTextBox.Text)- decimal.Parse(gastosEscrituraTextBox.Text);

                FTablaAmortizacion f = new FTablaAmortizacion(monto, meses, cuota, tasa, fecha, prima, nombreCompletoTextBox.Text);
                f.ShowDialog();
            }
            catch (Exception)
            {

                // throw;
            }

        }

        private void gastosEscrituraTextBox_TextChanged(object sender, EventArgs e)
        {
            /*if (gastosEscrituraTextBox.Text.Length > 0)
            {
                try
                {
                    decimal gastos = decimal.Parse(gastosEscrituraTextBox.Text);
                    this.contraton.GastosEscritura = gastos;
                    contraton.PrimaNeta = contraton.Prima + contraton.GastosEscritura;
                    contraton.PrimaInicial = contraton.PrimaNeta;
                }
                catch (Exception)
                {


                    ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).GastosEscritura = 0;
                }

            }*/

        }

        private void primaTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularcuota();
        }

        private void calcularcuota()
        {
            try
            {


                decimal precio = decimal.Parse(precioTextBox.Text);
                decimal prima = decimal.Parse(primaTextBox.Text);
                decimal financiamiento = precio - prima;
                decimal interes = financiamiento * 0.03M;

                decimal capital = financiamiento / contraton.Meses;
                decimal cuota = Math.Round(capital + interes, 2);
                //   financiamientoTextBox1.Text = financiamiento.ToString();
                //            ((contrato)contratosBindingSource.Current).Financiamiento = financiamiento;
                contraton.Financiamiento = financiamiento;
                contraton.Cuota = cuota;
                //cuotaTextBox.Text = contraton.Cuota.ToString();



            }
            catch (Exception)
            {

                //    MessageBox.Show("Error");
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46
                                && e.KeyChar != 8)
                e.Handled = true;
        }

        private void precioTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (precioTextBox.Text.Length == 0)
            {
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).GastosEscritura = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Prima = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Financiamiento = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).PrimaInicial = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).PrimaNeta = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Cuota = 0;

            }
        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {
            if (precioTextBox.Text.Length == 0)
            {
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).GastosEscritura = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Prima = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Financiamiento = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).PrimaInicial = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).PrimaNeta = 0;
                ((EASYPOS.Entidades.Contratos)contratosBindingSource.Current).Cuota = 0;

            }
        }

        private void mesesTextBox_TextChanged(object sender, EventArgs e)
        {
            calcularcuota();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = datoscredito;
            try
            {


                FCalculos fCalculos = new FCalculos(nombreCompletoTextBox.Text);
                fCalculos.StartPosition = FormStartPosition.CenterParent;
                fCalculos.ShowDialog();

                if (fCalculos.DialogResult == DialogResult.OK && contratoUp == null)
                {
                    contraton = new contrato();

                    // contratosBindingSource.ResetBindings(true);
                    contraton = (contrato)contratosBindingSource.Current;
                    contraton.Precio = fCalculos.precio;
                    contraton.Meses = fCalculos.meses;
                    contraton.Cuota = fCalculos.cuota;
                    //MessageBox.Show(contraton.Financiamiento.ToString());
                    contraton.Financiamiento = 0; contraton.Financiamiento = fCalculos.financiamiento;
                    contraton.Prima = fCalculos.prima;
                    contraton.GastosEscritura = fCalculos.gastos;
                    contraton.Tasa = fCalculos.tasa;
                        
                        contraton.PrimaInicial = contraton.Prima ;
                        contraton.PrimaNeta = contraton.Prima - fCalculos.gastos;





                    contratosBindingSource.DataSource = contraton;
                    contratosBindingSource.ResetBindings(true);

                }

                if (fCalculos.DialogResult == DialogResult.OK && contratoUp != null)
                {
                    // contraton = new contrato();

                    // contratosBindingSource.ResetBindings(true);
                    //contraton = (contrato)contratosBindingSource.Current;
                    contratoUp.Precio = fCalculos.precio;
                    contratoUp.Meses = fCalculos.meses;
                    contratoUp.Cuota = fCalculos.cuota;
                    contratoUp.Tasa = fCalculos.tasa;
                    //MessageBox.Show(contraton.Financiamiento.ToString());
                    contratoUp.Financiamiento = 0; contratoUp.Financiamiento = fCalculos.financiamiento;
                    contratoUp.Prima = fCalculos.prima;

                    if (gastosEscrituraTextBox.Text.Length > 0)
                    {

                        decimal gastos = decimal.Parse(gastosEscrituraTextBox.Text);
                        contratoUp.GastosEscritura = gastos;
                        contratoUp.PrimaInicial = contratoUp.Prima + gastos;
                        contratoUp.PrimaNeta = contratoUp.PrimaInicial;

                    }




                    contratosBindingSource.DataSource = contratoUp;
                    contratosBindingSource.ResetBindings(true);

                }

            }
            catch (Exception)
            {


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FCuotasPagarV2 f = new FCuotasPagarV2(contratoUp.IdContrato);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FReporteDocumentos f = new FReporteDocumentos(contratoUp.IdContrato);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            otrosPagosBindingSource.MoveLast();
            otrosPagosBindingSource.AddNew();
            groupBoxDatos.Enabled =!groupBoxDatos.Enabled;
            button7.Enabled = !button7.Enabled;
            montoTextBox.Focus();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            otrosPagosBindingSource.RemoveCurrent();
            otrosPagosBindingSource.CancelEdit();
            groupBoxDatos.Enabled = !groupBoxDatos.Enabled;
            button7.Enabled = !button7.Enabled;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(montoTextBox.Text);
            FCobro f = new FCobro(total);
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {

                OtrosPagos otros = new OtrosPagos();
                COtrosPagos cOtros = new COtrosPagos();
                otrosPagosBindingSource.EndEdit();
                otros = (OtrosPagos)otrosPagosBindingSource.Current;
                otros.fecha = DateTime.Now;
                otros.efectivo = f.recibe;
                otros.cambio = f.cambio;
                otros.IdContrato_FK = contratoUp.IdContrato;
                cOtros.Insertar(otros);
                //otrosPagosBindingSource.DataSource = null;
                otrosPagosBindingSource.DataSource = cOtros.Listado(contratoUp.IdContrato);
                groupBoxDatos.Enabled = !groupBoxDatos.Enabled;
                button7.Enabled = !button7.Enabled;
                MessageBox.Show("Pago registrado con éxito");

                ImprimirTicket(otros);
            }
        }

        private void ImprimirTicket(OtrosPagos otros)
        {
            
                CContratos cContratos = new CContratos();
               /* CCuota cCuota = new CCuota();
                Cuotas c = new Cuotas();
                c = cCuota.ObtenerUna(id);*/
            contrato contrato = new contrato();
                contrato = cContratos.uno(otros.IdContrato_FK);


                CConfiguracion cConfiguracion = new CConfiguracion();
                Configuracion config = cConfiguracion.ObtenerConfiguracion();
                Printer printer = new Printer(config.Impresora);

               // CCorrelativo ccorrelativo = new CCorrelativo();
              //  Correlativo correlativo = ccorrelativo.ObtenerUna(c.IdCorrelativo_FK);

                printer.AlignCenter();
                printer.Append("                                        ");
                printer.Append("                                        ");
                printer.Append("                                        ");
                printer.BoldMode(config.NombreEmpresa);
                printer.BoldMode(config.municipio);
                //Bitmap image = new Bitmap(Bitmap.FromFile("Icon.bmp"));
                //printer.Image(image);
                printer.Append(config.Direccion);
                printer.Append("NIT:" + config.NIT);
                printer.Append("NRC:" + config.NRC);
                printer.Append("Fecha:" + otros.fecha);
                printer.Append("Comprobante de pago");
                printer.Append("Cliente:" + contrato.NombreCompleto);
                printer.Append("--------------------------------------");

                printer.AlignLeft();
                printer.Append("Descripción del pago");


                printer.Append("Total cancelado = $" + otros.monto.Value.ToString("F"));
                
                if (otros.comentario != null)
                {
                    printer.Append("--------------");
                    printer.Append("Información:" + otros.comentario);
                    printer.Append("--------------");
                }
                /*printer.Append("A intereses = $" + c.AIntereses.Value.ToString("F"));
                printer.Append("A capital = $" + c.ACapital.Value.ToString("F"));
                printer.Append("Abono extra a capital = $" + c.ACapitalExtra.Value.ToString("F"));
                printer.Append("--------------");
                printer.Append("Capital pendiente = $" + c.CapitalPendiente.Value.ToString("F"));*/

                printer.AlignCenter();
                printer.Append("--------------------------------------");
                printer.AlignLeft();
                printer.Append("Ventas Afectas:" + otros.monto);
                printer.Append("Ventas Exentas:" + "0.00");
                printer.AlignCenter();
                printer.Append("--------------------------------------");
                printer.AlignLeft();
                printer.Append("Recibido:" + otros.efectivo.Value);
                printer.Append("Cambio:" + otros.cambio.Value);
                printer.AlignCenter();
                printer.Append("                                        ");
                printer.Append("                                        ");
                printer.Append("                                        ");
                printer.Append("Gracias por su pago realizado");
                printer.Append("                                        ");
                printer.Append("                                        ");
                printer.Append("                                        ");

                /*printer.Append("Resolución: " + correlativo.Resolucion);
                printer.Append("Del " + "0000001 al " + correlativo.Fin);
                printer.Append("Autorización:" + correlativo.Autorizacion);
                printer.Append("Fecha de resolución:" + correlativo.FechaDeAutorizacion.ToString());*/
                printer.Append("                                        ");
                printer.Append("                                        ");
                printer.FullPaperCut();
                try
                {
                    printer.PrintDocument();
                }
                catch (Exception)
                {


                }



            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (contratoUp!=null)
            {
                FReportePagosExtras f = new FReportePagosExtras(contratoUp.IdContrato);
                f.ShowDialog();
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (contratoUp!=null)
            {

            
            CCuota cCuota = new CCuota();
            cCuota.EliminarTodas(contratoUp.IdContrato);
                MessageBox.Show("Cuotas eliminadas, eliga nueva fecha de inicio y luego de clic en guardar");

                CContratos cContratos = new CContratos();
                contrato contrato = new contrato();
                contrato = (EASYPOS.Entidades.Contratos)contratosBindingSource.Current;
                cContratos.ActualizarRestanteBorrado(contrato);
                contratoUp.Restante = contrato.Financiamiento;
                contratosBindingSource.DataSource = contrato;

                guardar(false);

            }
        }

        private void datoscredito_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FCalculos fCalculos = new FCalculos(nombreCompletoTextBox.Text);
            fCalculos.StartPosition = FormStartPosition.CenterParent;
            fCalculos.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void generarTabla(decimal monto, int meses, DateTime fecha, decimal tasa, int idcontrato, decimal prima)
        {
            decimal total = monto;
            decimal restante = monto;
            List<TablaPagos> tabla = new List<TablaPagos>();

            for (int i = 1; i <= meses; i++)
            {
                restante -= Math.Round(total / meses, 2);
                fecha = fecha.AddMonths(1);
                TablaPagos p = new TablaPagos();
                p.Correlativo = i;
                p.Fecha = fecha;
                p.Capital = Math.Round(total / meses, 2);
                p.Interes = Math.Round(total * tasa, 2);
                p.Restante = restante;
                p.Cuota = p.Capital + p.Interes;

                if (p.Restante < 0)
                {
                    p.Capital = p.Capital + p.Restante;
                    p.Restante = 0;
                }
                if (p.Restante > 0 && p.Restante <= 1)
                {
                    p.Capital = p.Capital + p.Restante;
                    p.Cuota = p.Cuota + p.Restante;
                }
                tabla.Add(p);

            }

            CCuota cCuota = new CCuota();
            foreach (TablaPagos p in tabla)
            {
                Cuotas cuota = new Cuotas();

                //Fecha,Monto,IdContrato_FK,Capital,Intereses
                cuota.Fecha = p.Fecha;
                cuota.Monto = p.Cuota;
                cuota.IdContrato_FK = idcontrato;
                cuota.Capital = p.Capital;
                cuota.Intereses = p.Interes;

                cCuota.Insertar(cuota);
            }
        }
    }
}
