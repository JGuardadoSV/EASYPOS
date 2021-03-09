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

namespace EASYPOS.Formularios.Presentaciones
{
    public partial class FPresentaciones : Form
    {
        CPresentacion cPresentacion = new CPresentacion();
        Boolean actualizacion = false;
        public FPresentaciones()
        {
            InitializeComponent();
        }

        private void deseaEliminarEstaPresentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea eliminar esta presentación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Presentacion presentacion = new Presentacion();
                presentacion = (Presentacion)presentacionBindingSource.Current;

                try
                {
                    cPresentacion.Eliminar(presentacion);
                    cargarListado();
                    MessageBox.Show("Proveedor eliminado con éxito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la eliminación del proveedor. " + ex.Message);
                }
            }
        }

        private void cargarListado()
        {
            presentacionBindingSource.DataSource = cPresentacion.Listado();
        }

        private void FPresentaciones_Load(object sender, EventArgs e)
        {
          
            presentacionBindingSource1.DataSource = cPresentacion.Listado();
            presentacionBindingSource2.DataSource = cPresentacion.Listado();
            cargarListado();
        }

        private void activarcontroles()
        {
            this.Fpanel.Visible = !this.Fpanel.Visible;
            this.Registrarbutton.Enabled = !this.Fpanel.Visible;
            this.presentacionDataGridView.Enabled = !this.Fpanel.Visible;
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            presentacionBindingSource.MoveLast();
            presentacionBindingSource.AddNew();
            
            activarcontroles();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Presentacion presentacion = new Presentacion();
            presentacionBindingSource.EndEdit();
            presentacion = (Presentacion)presentacionBindingSource.Current;


            //estableciendo las presentaciones inferiores y superiores

            //presentacion.PresentacionSuperior = ((Presentacion)presentacionBindingSource1.Current).IdPresentacion;
            //presentacion.PresentacionInferior = ((Presentacion)presentacionBindingSource2.Current).IdPresentacion;


            cPresentacion.Insertar(presentacion);
            if (actualizacion)
            {
                MessageBox.Show("Presentación actualizada con éxito");
            }
            else
            {
                MessageBox.Show("Presentación registrada con éxito");
            }
            actualizacion = false;
            cargarListado();
            activarcontroles();
        }

        private void presentacionDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                // para que se seleccione el row donde se hizo clic derecho
                presentacionDataGridView.ClearSelection();
                presentacionDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                presentacionBindingSource.Position = e.RowIndex; //actualizar la pos del bindigsource del objeto seleccionado


            }
        }

        private void presentacionDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizacion = true;
            activarcontroles();
            Presentacion presentacion = new Presentacion();
            presentacion = (Presentacion)presentacionBindingSource.Current;
           
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            presentacionBindingSource.EndEdit();
            if (actualizacion == false)
            {
                presentacionBindingSource.RemoveCurrent();
            }

            actualizacion = false;
            cargarListado();
            activarcontroles();
        }
    }
}
