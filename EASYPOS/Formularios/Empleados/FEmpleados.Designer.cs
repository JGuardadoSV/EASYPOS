
namespace EASYPOS.Formularios.Empleados
{
    partial class FEmpleados
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
            System.Windows.Forms.Label apellidosEmpleadoLabel;
            System.Windows.Forms.Label dUILabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idRol_FKLabel;
            System.Windows.Forms.Label idSucursal_FKLabel;
            System.Windows.Forms.Label nITLabel;
            System.Windows.Forms.Label nombresEmpleadoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEmpleados));
            this.empleadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.empleadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSucursal_FK = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deseaEliminarEsteEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Registrarbutton = new System.Windows.Forms.Button();
            this.Fpanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SucursalcomboBox = new System.Windows.Forms.ComboBox();
            this.RolcomboBox = new System.Windows.Forms.ComboBox();
            this.apellidosEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.dUITextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nITTextBox = new System.Windows.Forms.TextBox();
            this.nombresEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            apellidosEmpleadoLabel = new System.Windows.Forms.Label();
            dUILabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idRol_FKLabel = new System.Windows.Forms.Label();
            idSucursal_FKLabel = new System.Windows.Forms.Label();
            nITLabel = new System.Windows.Forms.Label();
            nombresEmpleadoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).BeginInit();
            this.empleadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.Fpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // apellidosEmpleadoLabel
            // 
            apellidosEmpleadoLabel.AutoSize = true;
            apellidosEmpleadoLabel.Location = new System.Drawing.Point(28, 80);
            apellidosEmpleadoLabel.Name = "apellidosEmpleadoLabel";
            apellidosEmpleadoLabel.Size = new System.Drawing.Size(102, 13);
            apellidosEmpleadoLabel.TabIndex = 2;
            apellidosEmpleadoLabel.Text = "Apellidos Empleado:";
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Location = new System.Drawing.Point(101, 186);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(29, 13);
            dUILabel.TabIndex = 10;
            dUILabel.Text = "DUI:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(95, 108);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // idRol_FKLabel
            // 
            idRol_FKLabel.AutoSize = true;
            idRol_FKLabel.Location = new System.Drawing.Point(104, 216);
            idRol_FKLabel.Name = "idRol_FKLabel";
            idRol_FKLabel.Size = new System.Drawing.Size(26, 13);
            idRol_FKLabel.TabIndex = 12;
            idRol_FKLabel.Text = "Rol:";
            // 
            // idSucursal_FKLabel
            // 
            idSucursal_FKLabel.AutoSize = true;
            idSucursal_FKLabel.Location = new System.Drawing.Point(82, 246);
            idSucursal_FKLabel.Name = "idSucursal_FKLabel";
            idSucursal_FKLabel.Size = new System.Drawing.Size(48, 13);
            idSucursal_FKLabel.TabIndex = 14;
            idSucursal_FKLabel.Text = "Sucursal";
            // 
            // nITLabel
            // 
            nITLabel.AutoSize = true;
            nITLabel.Location = new System.Drawing.Point(102, 160);
            nITLabel.Name = "nITLabel";
            nITLabel.Size = new System.Drawing.Size(28, 13);
            nITLabel.TabIndex = 8;
            nITLabel.Text = "NIT:";
            // 
            // nombresEmpleadoLabel
            // 
            nombresEmpleadoLabel.AutoSize = true;
            nombresEmpleadoLabel.Location = new System.Drawing.Point(28, 54);
            nombresEmpleadoLabel.Name = "nombresEmpleadoLabel";
            nombresEmpleadoLabel.Size = new System.Drawing.Size(102, 13);
            nombresEmpleadoLabel.TabIndex = 0;
            nombresEmpleadoLabel.Text = "Nombres Empleado:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(78, 134);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 6;
            telefonoLabel.Text = "Telefono:";
            // 
            // empleadoBindingNavigator
            // 
            this.empleadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empleadoBindingNavigator.BindingSource = this.empleadoBindingSource;
            this.empleadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empleadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empleadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.empleadoBindingNavigatorSaveItem});
            this.empleadoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empleadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empleadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empleadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empleadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empleadoBindingNavigator.Name = "empleadoBindingNavigator";
            this.empleadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empleadoBindingNavigator.Size = new System.Drawing.Size(1003, 25);
            this.empleadoBindingNavigator.TabIndex = 0;
            this.empleadoBindingNavigator.Text = "bindingNavigator1";
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
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(EASYPOS.Entidades.Empleado);
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
            // empleadoBindingNavigatorSaveItem
            // 
            this.empleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empleadoBindingNavigatorSaveItem.Enabled = false;
            this.empleadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoBindingNavigatorSaveItem.Image")));
            this.empleadoBindingNavigatorSaveItem.Name = "empleadoBindingNavigatorSaveItem";
            this.empleadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.empleadoBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // empleadoDataGridView
            // 
            this.empleadoDataGridView.AllowUserToAddRows = false;
            this.empleadoDataGridView.AllowUserToDeleteRows = false;
            this.empleadoDataGridView.AutoGenerateColumns = false;
            this.empleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.IdSucursal_FK,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.empleadoDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.empleadoDataGridView.DataSource = this.empleadoBindingSource;
            this.empleadoDataGridView.Location = new System.Drawing.Point(12, 102);
            this.empleadoDataGridView.Name = "empleadoDataGridView";
            this.empleadoDataGridView.ReadOnly = true;
            this.empleadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.empleadoDataGridView.Size = new System.Drawing.Size(979, 294);
            this.empleadoDataGridView.TabIndex = 1;
            this.empleadoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empleadoDataGridView_CellDoubleClick);
            this.empleadoDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.empleadoDataGridView_CellMouseDown);
            this.empleadoDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.empleadoDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEmpleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEmpleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombresEmpleado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ApellidosEmpleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // IdSucursal_FK
            // 
            this.IdSucursal_FK.DataPropertyName = "IdSucursal_FK";
            this.IdSucursal_FK.DataSource = this.sucursalBindingSource;
            this.IdSucursal_FK.DisplayMember = "NombreSucursal";
            this.IdSucursal_FK.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IdSucursal_FK.HeaderText = "Sucursal Asignada";
            this.IdSucursal_FK.Name = "IdSucursal_FK";
            this.IdSucursal_FK.ReadOnly = true;
            this.IdSucursal_FK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdSucursal_FK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdSucursal_FK.ValueMember = "IdSucursal";
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(EASYPOS.Entidades.Sucursal);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdRol_FK";
            this.dataGridViewTextBoxColumn4.DataSource = this.rolBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "NombreRol";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IdRol";
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataSource = typeof(EASYPOS.Entidades.Rol);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DUI";
            this.dataGridViewTextBoxColumn5.HeaderText = "DUI";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NIT";
            this.dataGridViewTextBoxColumn6.HeaderText = "NIT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deseaEliminarEsteEmpleadoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 26);
            // 
            // deseaEliminarEsteEmpleadoToolStripMenuItem
            // 
            this.deseaEliminarEsteEmpleadoToolStripMenuItem.Name = "deseaEliminarEsteEmpleadoToolStripMenuItem";
            this.deseaEliminarEsteEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.deseaEliminarEsteEmpleadoToolStripMenuItem.Text = "¿Desea eliminar este empleado?";
            this.deseaEliminarEsteEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.deseaEliminarEsteEmpleadoToolStripMenuItem_Click);
            // 
            // Registrarbutton
            // 
            this.Registrarbutton.Location = new System.Drawing.Point(13, 55);
            this.Registrarbutton.Name = "Registrarbutton";
            this.Registrarbutton.Size = new System.Drawing.Size(163, 34);
            this.Registrarbutton.TabIndex = 2;
            this.Registrarbutton.Text = "Registrar empleado";
            this.Registrarbutton.UseVisualStyleBackColor = true;
            this.Registrarbutton.Click += new System.EventHandler(this.Registrarbutton_Click);
            // 
            // Fpanel
            // 
            this.Fpanel.Controls.Add(this.button2);
            this.Fpanel.Controls.Add(this.button1);
            this.Fpanel.Controls.Add(this.SucursalcomboBox);
            this.Fpanel.Controls.Add(this.RolcomboBox);
            this.Fpanel.Controls.Add(apellidosEmpleadoLabel);
            this.Fpanel.Controls.Add(this.apellidosEmpleadoTextBox);
            this.Fpanel.Controls.Add(dUILabel);
            this.Fpanel.Controls.Add(this.dUITextBox);
            this.Fpanel.Controls.Add(emailLabel);
            this.Fpanel.Controls.Add(this.emailTextBox);
            this.Fpanel.Controls.Add(idRol_FKLabel);
            this.Fpanel.Controls.Add(idSucursal_FKLabel);
            this.Fpanel.Controls.Add(nITLabel);
            this.Fpanel.Controls.Add(this.nITTextBox);
            this.Fpanel.Controls.Add(nombresEmpleadoLabel);
            this.Fpanel.Controls.Add(this.nombresEmpleadoTextBox);
            this.Fpanel.Controls.Add(telefonoLabel);
            this.Fpanel.Controls.Add(this.telefonoTextBox);
            this.Fpanel.Controls.Add(this.label1);
            this.Fpanel.Location = new System.Drawing.Point(204, 31);
            this.Fpanel.Name = "Fpanel";
            this.Fpanel.Size = new System.Drawing.Size(570, 411);
            this.Fpanel.TabIndex = 4;
            this.Fpanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 60);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 60);
            this.button1.TabIndex = 16;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SucursalcomboBox
            // 
            this.SucursalcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadoBindingSource, "IdSucursal_FK", true));
            this.SucursalcomboBox.DataSource = this.sucursalBindingSource;
            this.SucursalcomboBox.DisplayMember = "NombreSucursal";
            this.SucursalcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SucursalcomboBox.FormattingEnabled = true;
            this.SucursalcomboBox.Location = new System.Drawing.Point(136, 238);
            this.SucursalcomboBox.Name = "SucursalcomboBox";
            this.SucursalcomboBox.Size = new System.Drawing.Size(310, 21);
            this.SucursalcomboBox.TabIndex = 15;
            this.SucursalcomboBox.ValueMember = "IdSucursal";
            // 
            // RolcomboBox
            // 
            this.RolcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadoBindingSource, "IdRol_FK", true));
            this.RolcomboBox.DataSource = this.rolBindingSource;
            this.RolcomboBox.DisplayMember = "NombreRol";
            this.RolcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RolcomboBox.FormattingEnabled = true;
            this.RolcomboBox.Location = new System.Drawing.Point(136, 210);
            this.RolcomboBox.Name = "RolcomboBox";
            this.RolcomboBox.Size = new System.Drawing.Size(310, 21);
            this.RolcomboBox.TabIndex = 13;
            this.RolcomboBox.ValueMember = "IdRol";
            // 
            // apellidosEmpleadoTextBox
            // 
            this.apellidosEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "ApellidosEmpleado", true));
            this.apellidosEmpleadoTextBox.Location = new System.Drawing.Point(136, 77);
            this.apellidosEmpleadoTextBox.Name = "apellidosEmpleadoTextBox";
            this.apellidosEmpleadoTextBox.Size = new System.Drawing.Size(310, 20);
            this.apellidosEmpleadoTextBox.TabIndex = 3;
            // 
            // dUITextBox
            // 
            this.dUITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "DUI", true));
            this.dUITextBox.Location = new System.Drawing.Point(136, 183);
            this.dUITextBox.Name = "dUITextBox";
            this.dUITextBox.Size = new System.Drawing.Size(310, 20);
            this.dUITextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(136, 105);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(310, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // nITTextBox
            // 
            this.nITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "NIT", true));
            this.nITTextBox.Location = new System.Drawing.Point(136, 157);
            this.nITTextBox.Name = "nITTextBox";
            this.nITTextBox.Size = new System.Drawing.Size(310, 20);
            this.nITTextBox.TabIndex = 9;
            // 
            // nombresEmpleadoTextBox
            // 
            this.nombresEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "NombresEmpleado", true));
            this.nombresEmpleadoTextBox.Location = new System.Drawing.Point(136, 51);
            this.nombresEmpleadoTextBox.Name = "nombresEmpleadoTextBox";
            this.nombresEmpleadoTextBox.Size = new System.Drawing.Size(310, 20);
            this.nombresEmpleadoTextBox.TabIndex = 1;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(136, 131);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(310, 20);
            this.telefonoTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración de empleados";
            // 
            // FEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.Fpanel);
            this.Controls.Add(this.Registrarbutton);
            this.Controls.Add(this.empleadoDataGridView);
            this.Controls.Add(this.empleadoBindingNavigator);
            this.Name = "FEmpleados";
            this.Text = "FEmpleados";
            this.Load += new System.EventHandler(this.FEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).EndInit();
            this.empleadoBindingNavigator.ResumeLayout(false);
            this.empleadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.Fpanel.ResumeLayout(false);
            this.Fpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.BindingNavigator empleadoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton empleadoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView empleadoDataGridView;
        private System.Windows.Forms.Button Registrarbutton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deseaEliminarEsteEmpleadoToolStripMenuItem;
        private System.Windows.Forms.Panel Fpanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SucursalcomboBox;
        private System.Windows.Forms.ComboBox RolcomboBox;
        private System.Windows.Forms.TextBox apellidosEmpleadoTextBox;
        private System.Windows.Forms.TextBox dUITextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nITTextBox;
        private System.Windows.Forms.TextBox nombresEmpleadoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdSucursal_FK;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}