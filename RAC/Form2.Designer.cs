namespace RAC
{
    partial class Form2
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
            System.Windows.Forms.Label añoLabel;
            System.Windows.Forms.Label disponibleLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label precioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listaAutosBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.listaAutosBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.autoListaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autoListaDataGridView1 = new System.Windows.Forms.DataGridView();
            this.añoTextBox1 = new System.Windows.Forms.TextBox();
            this.disponibleCheckBox = new System.Windows.Forms.CheckBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.marcaTextBox1 = new System.Windows.Forms.TextBox();
            this.modeloTextBox1 = new System.Windows.Forms.TextBox();
            this.precioTextBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaAutosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            añoLabel = new System.Windows.Forms.Label();
            disponibleLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaAutosBindingSource1BindingNavigator)).BeginInit();
            this.listaAutosBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoListaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoListaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAutosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new System.Drawing.Point(27, 160);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new System.Drawing.Size(29, 13);
            añoLabel.TabIndex = 2;
            añoLabel.Text = "Año:";
            // 
            // disponibleLabel
            // 
            disponibleLabel.AutoSize = true;
            disponibleLabel.Location = new System.Drawing.Point(27, 188);
            disponibleLabel.Name = "disponibleLabel";
            disponibleLabel.Size = new System.Drawing.Size(59, 13);
            disponibleLabel.TabIndex = 4;
            disponibleLabel.Text = "Disponible:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(27, 56);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 6;
            idLabel.Text = "Id:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(27, 82);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 8;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(27, 108);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 10;
            modeloLabel.Text = "Modelo:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(27, 134);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 12;
            precioLabel.Text = "Precio:";
            // 
            // listaAutosBindingSource1BindingNavigator
            // 
            this.listaAutosBindingSource1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaAutosBindingSource1BindingNavigator.BindingSource = this.listaAutosBindingSource1;
            this.listaAutosBindingSource1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaAutosBindingSource1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaAutosBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaAutosBindingSource1BindingNavigatorSaveItem});
            this.listaAutosBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaAutosBindingSource1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaAutosBindingSource1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaAutosBindingSource1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaAutosBindingSource1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaAutosBindingSource1BindingNavigator.Name = "listaAutosBindingSource1BindingNavigator";
            this.listaAutosBindingSource1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaAutosBindingSource1BindingNavigator.Size = new System.Drawing.Size(806, 25);
            this.listaAutosBindingSource1BindingNavigator.TabIndex = 0;
            this.listaAutosBindingSource1BindingNavigator.Text = "bindingNavigator1";
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
            // listaAutosBindingSource1BindingNavigatorSaveItem
            // 
            this.listaAutosBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaAutosBindingSource1BindingNavigatorSaveItem.Enabled = false;
            this.listaAutosBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaAutosBindingSource1BindingNavigatorSaveItem.Image")));
            this.listaAutosBindingSource1BindingNavigatorSaveItem.Name = "listaAutosBindingSource1BindingNavigatorSaveItem";
            this.listaAutosBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaAutosBindingSource1BindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // autoListaBindingSource1
            // 
            this.autoListaBindingSource1.DataMember = "AutoLista";
            this.autoListaBindingSource1.DataSource = this.listaAutosBindingSource1;
            // 
            // autoListaDataGridView1
            // 
            this.autoListaDataGridView1.AutoGenerateColumns = false;
            this.autoListaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoListaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.autoListaDataGridView1.DataSource = this.autoListaBindingSource1;
            this.autoListaDataGridView1.Location = new System.Drawing.Point(21, 234);
            this.autoListaDataGridView1.Name = "autoListaDataGridView1";
            this.autoListaDataGridView1.Size = new System.Drawing.Size(749, 199);
            this.autoListaDataGridView1.TabIndex = 2;
            // 
            // añoTextBox1
            // 
            this.añoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoListaBindingSource1, "Año", true));
            this.añoTextBox1.Location = new System.Drawing.Point(92, 157);
            this.añoTextBox1.Name = "añoTextBox1";
            this.añoTextBox1.Size = new System.Drawing.Size(104, 20);
            this.añoTextBox1.TabIndex = 3;
            // 
            // disponibleCheckBox
            // 
            this.disponibleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.autoListaBindingSource1, "Disponible", true));
            this.disponibleCheckBox.Location = new System.Drawing.Point(92, 183);
            this.disponibleCheckBox.Name = "disponibleCheckBox";
            this.disponibleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.disponibleCheckBox.TabIndex = 5;
            this.disponibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoListaBindingSource1, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(92, 53);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(104, 20);
            this.idTextBox1.TabIndex = 7;
            // 
            // marcaTextBox1
            // 
            this.marcaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoListaBindingSource1, "Marca", true));
            this.marcaTextBox1.Location = new System.Drawing.Point(92, 79);
            this.marcaTextBox1.Name = "marcaTextBox1";
            this.marcaTextBox1.Size = new System.Drawing.Size(104, 20);
            this.marcaTextBox1.TabIndex = 9;
            // 
            // modeloTextBox1
            // 
            this.modeloTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoListaBindingSource1, "Modelo", true));
            this.modeloTextBox1.Location = new System.Drawing.Point(92, 105);
            this.modeloTextBox1.Name = "modeloTextBox1";
            this.modeloTextBox1.Size = new System.Drawing.Size(104, 20);
            this.modeloTextBox1.TabIndex = 11;
            // 
            // precioTextBox1
            // 
            this.precioTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoListaBindingSource1, "Precio", true));
            this.precioTextBox1.Location = new System.Drawing.Point(92, 131);
            this.precioTextBox1.Name = "precioTextBox1";
            this.precioTextBox1.Size = new System.Drawing.Size(104, 20);
            this.precioTextBox1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.autoListaBindingSource1, "Foto", true));
            this.pictureBox1.Location = new System.Drawing.Point(365, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listaAutosBindingSource1
            // 
            this.listaAutosBindingSource1.DataSource = typeof(RAC.ListaAutos);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn7.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Año";
            this.dataGridViewTextBoxColumn9.HeaderText = "Año";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn10.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Disponible";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Disponible";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Rentado";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Rentado";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(806, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(añoLabel);
            this.Controls.Add(this.añoTextBox1);
            this.Controls.Add(disponibleLabel);
            this.Controls.Add(this.disponibleCheckBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox1);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox1);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox1);
            this.Controls.Add(this.autoListaDataGridView1);
            this.Controls.Add(this.listaAutosBindingSource1BindingNavigator);
            this.Name = "Form2";
            this.Text = "Inventario Autos";
            ((System.ComponentModel.ISupportInitialize)(this.listaAutosBindingSource1BindingNavigator)).EndInit();
            this.listaAutosBindingSource1BindingNavigator.ResumeLayout(false);
            this.listaAutosBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoListaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoListaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaAutosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource listaAutosBindingSource;
        private System.Windows.Forms.BindingSource autoListaBindingSource;
        private System.Windows.Forms.DataGridView autoListaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TextBox añoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.CheckBox rentadoCheckBox;
        private System.Windows.Forms.BindingSource listaAutosBindingSource1;
        private System.Windows.Forms.BindingNavigator listaAutosBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaAutosBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource autoListaBindingSource1;
        private System.Windows.Forms.DataGridView autoListaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.TextBox añoTextBox1;
        private System.Windows.Forms.CheckBox disponibleCheckBox;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox marcaTextBox1;
        private System.Windows.Forms.TextBox modeloTextBox1;
        private System.Windows.Forms.TextBox precioTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}