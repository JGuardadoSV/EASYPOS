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

namespace EASYPOS.Formularios.Categorias
{
    public partial class FCategorias : Form
    {
        CCategoria cCategoria = new CCategoria();
        int idCategoriaSeleccionada=0;
        public FCategorias(){ InitializeComponent();  }

        private void FCategorias_Load(object sender, EventArgs e)
        {
            cargarListado();
        }

       

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            //string nombre= InputBox
            //categoriaBindingSource.MoveLast();
            //categoriaBindingSource.AddNew();
            activarControles();
            textBoxNombre.Focus();

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.NombreCategoria = textBoxNombre.Text;
            categoria.IdCategoria = idCategoriaSeleccionada;
            if (categoria.IdCategoria == 0)
            {
                
                try
                {
                    if (categoria.NombreCategoria.Length > 0)
                    {
                        cCategoria.Insertar(categoria);
                        cargarListado();
                        MessageBox.Show("Categoría creada con éxito");
                        activarControles();
                        textBoxNombre.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El nombre de la categoría es requerido");
                        textBoxNombre.Focus();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en el registro de la categoría. " + ex.Message);
                }
            }
            else
            {
                try
                {
                    if (categoria.NombreCategoria.Length > 0)
                    {
                        
                        cCategoria.Actualizar(categoria);
                        cargarListado();
                        MessageBox.Show("Categoría actualizada con éxito");
                        activarControles();
                        idCategoriaSeleccionada = 0;
                        textBoxNombre.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El nombre de la categoría es requerido");
                        textBoxNombre.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la actualización de la categoría. " + ex.Message);
                }
            }
            

        }

        //***************************************
        // FUNCIONES
        private void cargarListado()
        {
            categoriaBindingSource.DataSource = cCategoria.Listado();
        }
        private void activarControles()
        {
            
            textBoxNombre.Enabled = !textBoxNombre.Enabled;
            buttonGuardar.Enabled = !buttonGuardar.Enabled;
            buttonCancelar.Enabled = !buttonCancelar.Enabled;
            categoriaDataGridView.Enabled = !categoriaDataGridView.Enabled;
        }

        private void categoriaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria = (Categoria)categoriaBindingSource.Current;
            textBoxNombre.Text = categoria.NombreCategoria;
            idCategoriaSeleccionada = categoria.IdCategoria;
            activarControles();
            textBoxNombre.Focus();
        }

        private void eliminarEstaCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"¿Desea eliminar esta categoría?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                Categoria categoria = new Categoria();
                categoria = (Categoria)categoriaBindingSource.Current;

                try
                {
                        cCategoria.Eliminar(categoria);
                        cargarListado();
                        MessageBox.Show("Categoría eliminada con éxito");
                        idCategoriaSeleccionada = 0;
                        textBoxNombre.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la eliminación de la categoría. " + ex.Message);
                }
            }
        }

        private void categoriaDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                // para que se seleccione el row donde se hizo clic derecho
                categoriaDataGridView.ClearSelection();
                categoriaDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                categoriaBindingSource.Position = e.RowIndex; //actualizar la pos del bindigsource del objeto seleccionado


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activarControles();
            categoriaBindingSource.CancelEdit();
            textBoxNombre.Text = "";

        }
    }
}
