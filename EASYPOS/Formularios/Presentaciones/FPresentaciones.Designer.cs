
namespace EASYPOS.Formularios.Presentaciones
{
    partial class FPresentaciones
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
            System.Windows.Forms.Label cantidadPresentacionLabel;
            System.Windows.Forms.Label nombrePresentacionLabel;
            System.Windows.Forms.Label presentacionInferiorLabel;
            System.Windows.Forms.Label presentacionSuperiorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPresentaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.presentacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.presentacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.presentacionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.presentacionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.presentacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.presentacionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deseaEliminarEstaPresentaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Registrarbutton = new System.Windows.Forms.Button();
            this.Fpanel = new System.Windows.Forms.Panel();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.SuperiorcomboBox = new System.Windows.Forms.ComboBox();
            this.InferiorcomboBox = new System.Windows.Forms.ComboBox();
            this.cantidadPresentacionTextBox = new System.Windows.Forms.TextBox();
            this.nombrePresentacionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            cantidadPresentacionLabel = new System.Windows.Forms.Label();
            nombrePresentacionLabel = new System.Windows.Forms.Label();
            presentacionInferiorLabel = new System.Windows.Forms.Label();
            presentacionSuperiorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingNavigator)).BeginInit();
            this.presentacionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.Fpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cantidadPresentacionLabel
            // 
            cantidadPresentacionLabel.AutoSize = true;
            cantidadPresentacionLabel.Location = new System.Drawing.Point(48, 168);
            cantidadPresentacionLabel.Name = "cantidadPresentacionLabel";
            cantidadPresentacionLabel.Size = new System.Drawing.Size(117, 13);
            cantidadPresentacionLabel.TabIndex = 2;
            cantidadPresentacionLabel.Text = "Cantidad Presentacion:";
            // 
            // nombrePresentacionLabel
            // 
            nombrePresentacionLabel.AutoSize = true;
            nombrePresentacionLabel.Location = new System.Drawing.Point(53, 142);
            nombrePresentacionLabel.Name = "nombrePresentacionLabel";
            nombrePresentacionLabel.Size = new System.Drawing.Size(112, 13);
            nombrePresentacionLabel.TabIndex = 0;
            nombrePresentacionLabel.Text = "Nombre Presentación:";
            // 
            // presentacionInferiorLabel
            // 
            presentacionInferiorLabel.AutoSize = true;
            presentacionInferiorLabel.Location = new System.Drawing.Point(58, 220);
            presentacionInferiorLabel.Name = "presentacionInferiorLabel";
            presentacionInferiorLabel.Size = new System.Drawing.Size(107, 13);
            presentacionInferiorLabel.TabIndex = 6;
            presentacionInferiorLabel.Text = "Presentación Inferior:";
            // 
            // presentacionSuperiorLabel
            // 
            presentacionSuperiorLabel.AutoSize = true;
            presentacionSuperiorLabel.Location = new System.Drawing.Point(51, 193);
            presentacionSuperiorLabel.Name = "presentacionSuperiorLabel";
            presentacionSuperiorLabel.Size = new System.Drawing.Size(114, 13);
            presentacionSuperiorLabel.TabIndex = 4;
            presentacionSuperiorLabel.Text = "Presentación Superior:";
            // 
            // presentacionBindingNavigator
            // 
            this.presentacionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.presentacionBindingNavigator.BindingSource = this.presentacionBindingSource;
            this.presentacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.presentacionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.presentacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.presentacionBindingNavigatorSaveItem});
            this.presentacionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.presentacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.presentacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.presentacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.presentacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.presentacionBindingNavigator.Name = "presentacionBindingNavigator";
            this.presentacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.presentacionBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.presentacionBindingNavigator.TabIndex = 0;
            this.presentacionBindingNavigator.Text = "bindingNavigator1";
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
            // presentacionBindingSource
            // 
            this.presentacionBindingSource.DataSource = typeof(EASYPOS.Entidades.Presentacion);
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
            // presentacionBindingNavigatorSaveItem
            // 
            this.presentacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.presentacionBindingNavigatorSaveItem.Enabled = false;
            this.presentacionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("presentacionBindingNavigatorSaveItem.Image")));
            this.presentacionBindingNavigatorSaveItem.Name = "presentacionBindingNavigatorSaveItem";
            this.presentacionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.presentacionBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // presentacionDataGridView
            // 
            this.presentacionDataGridView.AllowUserToAddRows = false;
            this.presentacionDataGridView.AllowUserToDeleteRows = false;
            this.presentacionDataGridView.AutoGenerateColumns = false;
            this.presentacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.presentacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.presentacionDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.presentacionDataGridView.DataSource = this.presentacionBindingSource;
            this.presentacionDataGridView.Location = new System.Drawing.Point(12, 112);
            this.presentacionDataGridView.Name = "presentacionDataGridView";
            this.presentacionDataGridView.ReadOnly = true;
            this.presentacionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.presentacionDataGridView.Size = new System.Drawing.Size(776, 267);
            this.presentacionDataGridView.TabIndex = 1;
            this.presentacionDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.presentacionDataGridView_CellDoubleClick);
            this.presentacionDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.presentacionDataGridView_CellMouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPresentacion";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdPresentacion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombrePresentacion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Presentación";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PresentacionSuperior";
            this.dataGridViewTextBoxColumn3.DataSource = this.presentacionBindingSource1;
            dataGridViewCellStyle1.NullValue = "-";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.DisplayMember = "NombrePresentacion";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Presentación Superior";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IdPresentacion";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // presentacionBindingSource1
            // 
            this.presentacionBindingSource1.DataSource = typeof(EASYPOS.Entidades.Presentacion);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PresentacionInferior";
            this.dataGridViewTextBoxColumn4.DataSource = this.presentacionBindingSource2;
            dataGridViewCellStyle2.NullValue = "-";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.DisplayMember = "NombrePresentacion";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Presentación Inferior";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IdPresentacion";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // presentacionBindingSource2
            // 
            this.presentacionBindingSource2.DataSource = typeof(EASYPOS.Entidades.Presentacion);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CantidadPresentacion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deseaEliminarEstaPresentaciónToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(257, 26);
            // 
            // deseaEliminarEstaPresentaciónToolStripMenuItem
            // 
            this.deseaEliminarEstaPresentaciónToolStripMenuItem.Name = "deseaEliminarEstaPresentaciónToolStripMenuItem";
            this.deseaEliminarEstaPresentaciónToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.deseaEliminarEstaPresentaciónToolStripMenuItem.Text = "¿Desea eliminar esta presentación?";
            this.deseaEliminarEstaPresentaciónToolStripMenuItem.Click += new System.EventHandler(this.deseaEliminarEstaPresentaciónToolStripMenuItem_Click);
            // 
            // Registrarbutton
            // 
            this.Registrarbutton.Location = new System.Drawing.Point(12, 68);
            this.Registrarbutton.Name = "Registrarbutton";
            this.Registrarbutton.Size = new System.Drawing.Size(151, 38);
            this.Registrarbutton.TabIndex = 2;
            this.Registrarbutton.Text = "Registrar  presentación";
            this.Registrarbutton.UseVisualStyleBackColor = true;
            this.Registrarbutton.Click += new System.EventHandler(this.Registrarbutton_Click);
            // 
            // Fpanel
            // 
            this.Fpanel.Controls.Add(this.Cancelarbutton);
            this.Fpanel.Controls.Add(this.Guardarbutton);
            this.Fpanel.Controls.Add(this.SuperiorcomboBox);
            this.Fpanel.Controls.Add(this.InferiorcomboBox);
            this.Fpanel.Controls.Add(cantidadPresentacionLabel);
            this.Fpanel.Controls.Add(this.cantidadPresentacionTextBox);
            this.Fpanel.Controls.Add(nombrePresentacionLabel);
            this.Fpanel.Controls.Add(this.nombrePresentacionTextBox);
            this.Fpanel.Controls.Add(presentacionInferiorLabel);
            this.Fpanel.Controls.Add(presentacionSuperiorLabel);
            this.Fpanel.Controls.Add(this.label1);
            this.Fpanel.Location = new System.Drawing.Point(172, 47);
            this.Fpanel.Name = "Fpanel";
            this.Fpanel.Size = new System.Drawing.Size(501, 391);
            this.Fpanel.TabIndex = 3;
            this.Fpanel.Visible = false;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(211, 278);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(135, 54);
            this.Cancelarbutton.TabIndex = 9;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(61, 278);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(135, 54);
            this.Guardarbutton.TabIndex = 8;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // SuperiorcomboBox
            // 
            this.SuperiorcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.presentacionBindingSource, "PresentacionSuperior", true));
            this.SuperiorcomboBox.DataSource = this.presentacionBindingSource1;
            this.SuperiorcomboBox.DisplayMember = "NombrePresentacion";
            this.SuperiorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SuperiorcomboBox.FormattingEnabled = true;
            this.SuperiorcomboBox.Location = new System.Drawing.Point(171, 193);
            this.SuperiorcomboBox.Name = "SuperiorcomboBox";
            this.SuperiorcomboBox.Size = new System.Drawing.Size(215, 21);
            this.SuperiorcomboBox.TabIndex = 5;
            this.SuperiorcomboBox.ValueMember = "IdPresentacion";
            // 
            // InferiorcomboBox
            // 
            this.InferiorcomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.presentacionBindingSource, "PresentacionInferior", true));
            this.InferiorcomboBox.DataSource = this.presentacionBindingSource2;
            this.InferiorcomboBox.DisplayMember = "NombrePresentacion";
            this.InferiorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InferiorcomboBox.FormattingEnabled = true;
            this.InferiorcomboBox.Location = new System.Drawing.Point(171, 220);
            this.InferiorcomboBox.Name = "InferiorcomboBox";
            this.InferiorcomboBox.Size = new System.Drawing.Size(215, 21);
            this.InferiorcomboBox.TabIndex = 7;
            this.InferiorcomboBox.ValueMember = "IdPresentacion";
            // 
            // cantidadPresentacionTextBox
            // 
            this.cantidadPresentacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presentacionBindingSource, "CantidadPresentacion", true));
            this.cantidadPresentacionTextBox.Location = new System.Drawing.Point(171, 165);
            this.cantidadPresentacionTextBox.Name = "cantidadPresentacionTextBox";
            this.cantidadPresentacionTextBox.Size = new System.Drawing.Size(83, 20);
            this.cantidadPresentacionTextBox.TabIndex = 3;
            // 
            // nombrePresentacionTextBox
            // 
            this.nombrePresentacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presentacionBindingSource, "NombrePresentacion", true));
            this.nombrePresentacionTextBox.Location = new System.Drawing.Point(171, 139);
            this.nombrePresentacionTextBox.Name = "nombrePresentacionTextBox";
            this.nombrePresentacionTextBox.Size = new System.Drawing.Size(232, 20);
            this.nombrePresentacionTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración  de  presentaciones";
            // 
            // FPresentaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fpanel);
            this.Controls.Add(this.Registrarbutton);
            this.Controls.Add(this.presentacionDataGridView);
            this.Controls.Add(this.presentacionBindingNavigator);
            this.Name = "FPresentaciones";
            this.Text = "FPresentaciones";
            this.Load += new System.EventHandler(this.FPresentaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingNavigator)).EndInit();
            this.presentacionBindingNavigator.ResumeLayout(false);
            this.presentacionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionBindingSource2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.Fpanel.ResumeLayout(false);
            this.Fpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource presentacionBindingSource;
        private System.Windows.Forms.BindingNavigator presentacionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton presentacionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView presentacionDataGridView;
        private System.Windows.Forms.Button Registrarbutton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deseaEliminarEstaPresentaciónToolStripMenuItem;
        private System.Windows.Forms.Panel Fpanel;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.ComboBox SuperiorcomboBox;
        private System.Windows.Forms.ComboBox InferiorcomboBox;
        private System.Windows.Forms.TextBox cantidadPresentacionTextBox;
        private System.Windows.Forms.TextBox nombrePresentacionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource presentacionBindingSource1;
        private System.Windows.Forms.BindingSource presentacionBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}