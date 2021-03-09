
namespace EASYPOS.Formularios.Productos
{
    partial class FProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label informacionAdicionalLabel;
            System.Windows.Forms.Label nombreProductoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label tieneVariasPresentacionesLabel1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label codigoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarEsteProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Registrarbutton = new System.Windows.Forms.Button();
            this.Fpanel = new System.Windows.Forms.Panel();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.ProveedorcomboBox = new System.Windows.Forms.ComboBox();
            this.CategoriacomboBox = new System.Windows.Forms.ComboBox();
            this.tieneVariasPresentacionesCheckBox = new System.Windows.Forms.CheckBox();
            this.informacionAdicionalTextBox = new System.Windows.Forms.TextBox();
            this.nombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            informacionAdicionalLabel = new System.Windows.Forms.Label();
            nombreProductoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            tieneVariasPresentacionesLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.Fpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // informacionAdicionalLabel
            // 
            informacionAdicionalLabel.AutoSize = true;
            informacionAdicionalLabel.Location = new System.Drawing.Point(80, 166);
            informacionAdicionalLabel.Name = "informacionAdicionalLabel";
            informacionAdicionalLabel.Size = new System.Drawing.Size(111, 13);
            informacionAdicionalLabel.TabIndex = 7;
            informacionAdicionalLabel.Text = "Informacion Adicional:";
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.Location = new System.Drawing.Point(98, 78);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new System.Drawing.Size(93, 13);
            nombreProductoLabel.TabIndex = 1;
            nombreProductoLabel.Text = "Nombre Producto:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(151, 135);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 5;
            precioLabel.Text = "Precio:";
            // 
            // tieneVariasPresentacionesLabel1
            // 
            tieneVariasPresentacionesLabel1.AutoSize = true;
            tieneVariasPresentacionesLabel1.Location = new System.Drawing.Point(13, 105);
            tieneVariasPresentacionesLabel1.Name = "tieneVariasPresentacionesLabel1";
            tieneVariasPresentacionesLabel1.Size = new System.Drawing.Size(178, 13);
            tieneVariasPresentacionesLabel1.TabIndex = 3;
            tieneVariasPresentacionesLabel1.Text = "Se vende en varias Presentaciones:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(134, 190);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 13);
            label2.TabIndex = 9;
            label2.Text = "Categoría:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(132, 221);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 13);
            label3.TabIndex = 11;
            label3.Text = "Proveedor:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(148, 256);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 13;
            codigoLabel.Text = "Codigo:";
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productoBindingNavigatorSaveItem});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(969, 25);
            this.productoBindingNavigator.TabIndex = 0;
            this.productoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(EASYPOS.Entidades.Producto);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productoBindingNavigatorSaveItem
            // 
            this.productoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productoBindingNavigatorSaveItem.Enabled = false;
            this.productoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productoBindingNavigatorSaveItem.Image")));
            this.productoBindingNavigatorSaveItem.Name = "productoBindingNavigatorSaveItem";
            this.productoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productoBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AllowUserToDeleteRows = false;
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Codigo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.productoDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(12, 81);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productoDataGridView.Size = new System.Drawing.Size(945, 302);
            this.productoDataGridView.TabIndex = 1;
            this.productoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productoDataGridView_CellDoubleClick);
            this.productoDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productoDataGridView_CellMouseDown);
            this.productoDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.productoDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProducto";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProducto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.NullValue = "-";
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TieneVariasPresentaciones";
            this.dataGridViewTextBoxColumn3.HeaderText = "TieneVariasPresentaciones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdCategoria_FK";
            this.dataGridViewTextBoxColumn4.DataSource = this.categoriaBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "NombreCategoria";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IdCategoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(EASYPOS.Entidades.Categoria);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdProveedor_FK";
            this.dataGridViewTextBoxColumn5.DataSource = this.proveedorBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "NombreProveedor";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "IdProveedor";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(EASYPOS.Entidades.Proveedor);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "InformacionAdicional";
            this.dataGridViewTextBoxColumn6.HeaderText = "Informacion adicional";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PrincipioActivo";
            this.dataGridViewTextBoxColumn7.HeaderText = "PrincipioActivo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Precio";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn8.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarEsteProductoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 26);
            // 
            // eliminarEsteProductoToolStripMenuItem
            // 
            this.eliminarEsteProductoToolStripMenuItem.Name = "eliminarEsteProductoToolStripMenuItem";
            this.eliminarEsteProductoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.eliminarEsteProductoToolStripMenuItem.Text = "¿Eliminar este producto?";
            this.eliminarEsteProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarEsteProductoToolStripMenuItem_Click);
            // 
            // Registrarbutton
            // 
            this.Registrarbutton.Location = new System.Drawing.Point(13, 28);
            this.Registrarbutton.Name = "Registrarbutton";
            this.Registrarbutton.Size = new System.Drawing.Size(235, 47);
            this.Registrarbutton.TabIndex = 3;
            this.Registrarbutton.Text = "Registrar producto";
            this.Registrarbutton.UseVisualStyleBackColor = true;
            this.Registrarbutton.Click += new System.EventHandler(this.Registrarbutton_Click);
            // 
            // Fpanel
            // 
            this.Fpanel.Controls.Add(codigoLabel);
            this.Fpanel.Controls.Add(this.codigoTextBox);
            this.Fpanel.Controls.Add(this.Cancelarbutton);
            this.Fpanel.Controls.Add(this.Guardarbutton);
            this.Fpanel.Controls.Add(this.ProveedorcomboBox);
            this.Fpanel.Controls.Add(this.CategoriacomboBox);
            this.Fpanel.Controls.Add(tieneVariasPresentacionesLabel1);
            this.Fpanel.Controls.Add(this.tieneVariasPresentacionesCheckBox);
            this.Fpanel.Controls.Add(label3);
            this.Fpanel.Controls.Add(label2);
            this.Fpanel.Controls.Add(informacionAdicionalLabel);
            this.Fpanel.Controls.Add(this.informacionAdicionalTextBox);
            this.Fpanel.Controls.Add(nombreProductoLabel);
            this.Fpanel.Controls.Add(this.nombreProductoTextBox);
            this.Fpanel.Controls.Add(precioLabel);
            this.Fpanel.Controls.Add(this.precioTextBox);
            this.Fpanel.Controls.Add(this.label1);
            this.Fpanel.Location = new System.Drawing.Point(18, 41);
            this.Fpanel.Name = "Fpanel";
            this.Fpanel.Size = new System.Drawing.Size(743, 393);
            this.Fpanel.TabIndex = 4;
            this.Fpanel.Visible = false;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(198, 254);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(244, 20);
            this.codigoTextBox.TabIndex = 14;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(321, 283);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(147, 59);
            this.Cancelarbutton.TabIndex = 16;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(168, 283);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(147, 59);
            this.Guardarbutton.TabIndex = 15;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // ProveedorcomboBox
            // 
            this.ProveedorcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IdProveedor_FK", true));
            this.ProveedorcomboBox.DataSource = this.proveedorBindingSource;
            this.ProveedorcomboBox.DisplayMember = "NombreProveedor";
            this.ProveedorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProveedorcomboBox.FormattingEnabled = true;
            this.ProveedorcomboBox.Location = new System.Drawing.Point(198, 221);
            this.ProveedorcomboBox.Name = "ProveedorcomboBox";
            this.ProveedorcomboBox.Size = new System.Drawing.Size(244, 21);
            this.ProveedorcomboBox.TabIndex = 12;
            this.ProveedorcomboBox.ValueMember = "IdProveedor";
            // 
            // CategoriacomboBox
            // 
            this.CategoriacomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IdCategoria_FK", true));
            this.CategoriacomboBox.DataSource = this.categoriaBindingSource;
            this.CategoriacomboBox.DisplayMember = "NombreCategoria";
            this.CategoriacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriacomboBox.FormattingEnabled = true;
            this.CategoriacomboBox.Location = new System.Drawing.Point(198, 190);
            this.CategoriacomboBox.Name = "CategoriacomboBox";
            this.CategoriacomboBox.Size = new System.Drawing.Size(244, 21);
            this.CategoriacomboBox.TabIndex = 10;
            this.CategoriacomboBox.ValueMember = "IdCategoria";
            // 
            // tieneVariasPresentacionesCheckBox
            // 
            this.tieneVariasPresentacionesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productoBindingSource, "TieneVariasPresentaciones", true));
            this.tieneVariasPresentacionesCheckBox.Location = new System.Drawing.Point(198, 105);
            this.tieneVariasPresentacionesCheckBox.Name = "tieneVariasPresentacionesCheckBox";
            this.tieneVariasPresentacionesCheckBox.Size = new System.Drawing.Size(104, 24);
            this.tieneVariasPresentacionesCheckBox.TabIndex = 4;
            this.tieneVariasPresentacionesCheckBox.Text = "Sí";
            this.tieneVariasPresentacionesCheckBox.UseVisualStyleBackColor = true;
            // 
            // informacionAdicionalTextBox
            // 
            this.informacionAdicionalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "InformacionAdicional", true));
            this.informacionAdicionalTextBox.Location = new System.Drawing.Point(198, 163);
            this.informacionAdicionalTextBox.Name = "informacionAdicionalTextBox";
            this.informacionAdicionalTextBox.Size = new System.Drawing.Size(244, 20);
            this.informacionAdicionalTextBox.TabIndex = 8;
            // 
            // nombreProductoTextBox
            // 
            this.nombreProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "NombreProducto", true));
            this.nombreProductoTextBox.Location = new System.Drawing.Point(198, 75);
            this.nombreProductoTextBox.Name = "nombreProductoTextBox";
            this.nombreProductoTextBox.Size = new System.Drawing.Size(244, 20);
            this.nombreProductoTextBox.TabIndex = 2;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(198, 135);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración de productos";
            // 
            // FProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.Fpanel);
            this.Controls.Add(this.Registrarbutton);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.productoBindingNavigator);
            this.Name = "FProductos";
            this.Text = "FProductos";
            this.Load += new System.EventHandler(this.FProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.Fpanel.ResumeLayout(false);
            this.Fpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarEsteProductoToolStripMenuItem;
        private System.Windows.Forms.Button Registrarbutton;
        private System.Windows.Forms.Panel Fpanel;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.ComboBox ProveedorcomboBox;
        private System.Windows.Forms.ComboBox CategoriacomboBox;
        private System.Windows.Forms.CheckBox tieneVariasPresentacionesCheckBox;
        private System.Windows.Forms.TextBox informacionAdicionalTextBox;
        private System.Windows.Forms.TextBox nombreProductoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}