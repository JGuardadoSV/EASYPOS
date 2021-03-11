
namespace EASYPOS.Formularios.Sucursales
{
    partial class FSucursales
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
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label nombreSucursalLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSucursales));
            this.sucursalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.sucursalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sucursalDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deseaEliminarEstaSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Registrarbutton = new System.Windows.Forms.Button();
            this.Fpanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreSucursalTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            direccionLabel = new System.Windows.Forms.Label();
            nombreSucursalLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingNavigator)).BeginInit();
            this.sucursalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.Fpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(79, 133);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 2;
            direccionLabel.Text = "Direccion:";
            // 
            // nombreSucursalLabel
            // 
            nombreSucursalLabel.AutoSize = true;
            nombreSucursalLabel.Location = new System.Drawing.Point(43, 107);
            nombreSucursalLabel.Name = "nombreSucursalLabel";
            nombreSucursalLabel.Size = new System.Drawing.Size(91, 13);
            nombreSucursalLabel.TabIndex = 0;
            nombreSucursalLabel.Text = "Nombre Sucursal:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(82, 159);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 4;
            telefonoLabel.Text = "Telefono:";
            // 
            // sucursalBindingNavigator
            // 
            this.sucursalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sucursalBindingNavigator.BindingSource = this.sucursalBindingSource;
            this.sucursalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sucursalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sucursalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sucursalBindingNavigatorSaveItem});
            this.sucursalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sucursalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sucursalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sucursalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sucursalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sucursalBindingNavigator.Name = "sucursalBindingNavigator";
            this.sucursalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sucursalBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.sucursalBindingNavigator.TabIndex = 0;
            this.sucursalBindingNavigator.Text = "bindingNavigator1";
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
            // sucursalBindingNavigatorSaveItem
            // 
            this.sucursalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sucursalBindingNavigatorSaveItem.Enabled = false;
            this.sucursalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sucursalBindingNavigatorSaveItem.Image")));
            this.sucursalBindingNavigatorSaveItem.Name = "sucursalBindingNavigatorSaveItem";
            this.sucursalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sucursalBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // sucursalDataGridView
            // 
            this.sucursalDataGridView.AllowUserToAddRows = false;
            this.sucursalDataGridView.AllowUserToDeleteRows = false;
            this.sucursalDataGridView.AutoGenerateColumns = false;
            this.sucursalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sucursalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sucursalDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.sucursalDataGridView.DataSource = this.sucursalBindingSource;
            this.sucursalDataGridView.Location = new System.Drawing.Point(12, 127);
            this.sucursalDataGridView.Name = "sucursalDataGridView";
            this.sucursalDataGridView.ReadOnly = true;
            this.sucursalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sucursalDataGridView.Size = new System.Drawing.Size(776, 220);
            this.sucursalDataGridView.TabIndex = 1;
            this.sucursalDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sucursalDataGridView_CellDoubleClick);
            this.sucursalDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sucursalDataGridView_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deseaEliminarEstaSucursalToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 26);
            // 
            // deseaEliminarEstaSucursalToolStripMenuItem
            // 
            this.deseaEliminarEstaSucursalToolStripMenuItem.Name = "deseaEliminarEstaSucursalToolStripMenuItem";
            this.deseaEliminarEstaSucursalToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.deseaEliminarEstaSucursalToolStripMenuItem.Text = "¿Desea eliminar esta sucursal?";
            this.deseaEliminarEstaSucursalToolStripMenuItem.Click += new System.EventHandler(this.deseaEliminarEstaSucursalToolStripMenuItem_Click);
            // 
            // Registrarbutton
            // 
            this.Registrarbutton.Location = new System.Drawing.Point(12, 61);
            this.Registrarbutton.Name = "Registrarbutton";
            this.Registrarbutton.Size = new System.Drawing.Size(132, 45);
            this.Registrarbutton.TabIndex = 2;
            this.Registrarbutton.Text = "Registrar sucursal";
            this.Registrarbutton.UseVisualStyleBackColor = true;
            this.Registrarbutton.Click += new System.EventHandler(this.Registrarbutton_Click);
            // 
            // Fpanel
            // 
            this.Fpanel.Controls.Add(this.button2);
            this.Fpanel.Controls.Add(this.button1);
            this.Fpanel.Controls.Add(direccionLabel);
            this.Fpanel.Controls.Add(this.direccionTextBox);
            this.Fpanel.Controls.Add(nombreSucursalLabel);
            this.Fpanel.Controls.Add(this.nombreSucursalTextBox);
            this.Fpanel.Controls.Add(telefonoLabel);
            this.Fpanel.Controls.Add(this.telefonoTextBox);
            this.Fpanel.Controls.Add(this.label1);
            this.Fpanel.Location = new System.Drawing.Point(161, 40);
            this.Fpanel.Name = "Fpanel";
            this.Fpanel.Size = new System.Drawing.Size(482, 386);
            this.Fpanel.TabIndex = 3;
            this.Fpanel.Visible = false;
            this.Fpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Fpanel_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sucursalBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(140, 130);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(244, 20);
            this.direccionTextBox.TabIndex = 3;
            // 
            // nombreSucursalTextBox
            // 
            this.nombreSucursalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sucursalBindingSource, "NombreSucursal", true));
            this.nombreSucursalTextBox.Location = new System.Drawing.Point(140, 104);
            this.nombreSucursalTextBox.Name = "nombreSucursalTextBox";
            this.nombreSucursalTextBox.Size = new System.Drawing.Size(244, 20);
            this.nombreSucursalTextBox.TabIndex = 1;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sucursalBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(140, 156);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(98, 20);
            this.telefonoTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración de  sucursales";
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(EASYPOS.Entidades.Sucursal);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdSucursal";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdSucursal";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreSucursal";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Sucursal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fpanel);
            this.Controls.Add(this.Registrarbutton);
            this.Controls.Add(this.sucursalDataGridView);
            this.Controls.Add(this.sucursalBindingNavigator);
            this.Name = "FSucursales";
            this.Text = "FSucursales";
            this.Load += new System.EventHandler(this.FSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingNavigator)).EndInit();
            this.sucursalBindingNavigator.ResumeLayout(false);
            this.sucursalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.Fpanel.ResumeLayout(false);
            this.Fpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private System.Windows.Forms.BindingNavigator sucursalBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sucursalBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sucursalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button Registrarbutton;
        private System.Windows.Forms.Panel Fpanel;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox nombreSucursalTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deseaEliminarEstaSucursalToolStripMenuItem;
    }
}