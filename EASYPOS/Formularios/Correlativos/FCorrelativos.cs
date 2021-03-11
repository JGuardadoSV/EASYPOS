using EASYPOS.Controladores;
using EASYPOS.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPOS.Formularios.Correlativos
{
    public partial class FCorrelativos : Form
    {
        CCorrelativo cCorrelativo = new CCorrelativo();
        CSucursal cSucursal = new CSucursal();
        TipoDocumento tipoDocumento = new TipoDocumento();
        Boolean actualizacion = false;
        public FCorrelativos()
        {
            InitializeComponent();
        }

        private void finLabel_Click(object sender, EventArgs e)
        {

        }

        private void finTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Correlativo correlativo = new Correlativo();
            correlativoBindingSource.EndEdit();
            correlativo = (Correlativo)correlativoBindingSource.Current;

            int tipo = 1;
            if (ccfradioButton.Checked) tipo = 2;
            if (TicketradioButton.Checked) tipo = 3;
            
            correlativo.FechaCreacion = DateTime.Now;
            correlativo.TipoDeDocumento = tipo;
            correlativo.IdSucursal_FK = ((Sucursal)sucursalBindingSource.Current).IdSucursal;
            if (!actualizacion)   correlativo.ValorActual = 0;

            if (correlativo.FechaDeAutorizacion == null) correlativo.FechaDeAutorizacion = DateTime.Now;


            cCorrelativo.Insertar(correlativo);
            if (actualizacion)
            {
                MessageBox.Show("Correlativo actualizado con éxito");
            }
            else
            {
                MessageBox.Show("Correlativo registrado con éxito");
            }
            actualizacion = false;
            activarcontroles();
        }

        private void FCorrelativos_Load(object sender, EventArgs e)
        {
            sucursalBindingSource.DataSource = cSucursal.Listado();
            tipoDocumentoBindingSource.DataSource = tipoDocumento.listado();
            cargarListado();

        }

        private void cargarListado()
        {
            correlativoBindingSource.DataSource = cCorrelativo.Listado();
        }

        private void deseaEliminarEsteCorrelativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea eliminar este correlativo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Correlativo correlativo = new Correlativo();
                correlativo = (Correlativo)correlativoBindingSource.Current;

                try
                {
                    cCorrelativo.Eliminar(correlativo);
                    cargarListado();
                    MessageBox.Show("Correlativo eliminado con éxito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la eliminación del correlativo. " + ex.Message);
                }
            }
        }

        private void activarcontroles()
        {
            this.Fpanel.Visible = !this.Fpanel.Visible;
            this.Registrarbutton.Enabled = !this.Fpanel.Visible;
            this.correlativoDataGridView.Enabled = !this.Fpanel.Visible;
        }

        private void correlativoDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                // para que se seleccione el row donde se hizo clic derecho
                correlativoDataGridView.ClearSelection();
                correlativoDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                correlativoBindingSource.Position = e.RowIndex; //actualizar la pos del bindigsource del objeto seleccionado


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activarcontroles();
            correlativoBindingSource.EndEdit();
            if (actualizacion == false)
            {
                correlativoBindingSource.RemoveCurrent();
            }
            actualizacion = false;
            cargarListado();
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            correlativoBindingSource.MoveLast();
            correlativoBindingSource.AddNew();
            actualizacion = false;

            activarcontroles();
        }

        private void correlativoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            anError.ThrowException = false;/*
            MessageBox.Show("Error happened " + anError.Context.ToString());

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }*/
        }

        private void correlativoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizacion = true;
            activarcontroles();
            Correlativo  correlativo = new Correlativo();
            correlativo = (Correlativo)correlativoBindingSource.Current;

            switch (correlativo.TipoDeDocumento)
            {
                case 1:
                    CFradioButton.Checked = true;
                    break;
                case 2:
                    ccfradioButton.Checked = true;
                    break;
                default:
                    TicketradioButton.Checked = true;
                    break;
            }


        }

        private void Fpanel_VisibleChanged(object sender, EventArgs e)
        {
            if (actualizacion)
            {
                valorActualTextBox.Enabled = true;
            }
            else
            {
                valorActualTextBox.Enabled = false;
            }
        }
    }
}
