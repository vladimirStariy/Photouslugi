namespace Фотоуслуги
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Material = new System.Windows.Forms.TabPage();
            this.MaterialDataGrid = new System.Windows.Forms.DataGridView();
            this.MaterialNavMenu = new System.Windows.Forms.BindingNavigator(this.components);
            this.MaterialAddButton = new System.Windows.Forms.ToolStripButton();
            this.MaterialPostButton = new System.Windows.Forms.ToolStripButton();
            this.MaterialDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.MaterialTypes = new System.Windows.Forms.TabPage();
            this.MaterialTypeDataGrid = new System.Windows.Forms.DataGridView();
            this.MaterialTypeNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.MaterialTypeAddButton = new System.Windows.Forms.ToolStripButton();
            this.MaterialTypeEditButton = new System.Windows.Forms.ToolStripButton();
            this.MaterialTypeDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.MaterialMovement = new System.Windows.Forms.TabPage();
            this.MaterialMovementDataGrid = new System.Windows.Forms.DataGridView();
            this.MaterialMovementNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фотоуслугиDataSet = new Фотоуслуги.ФотоуслугиDataSet();
            this.materialnaskladeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.material_na_skladeTableAdapter = new Фотоуслуги.ФотоуслугиDataSetTableAdapters.material_na_skladeTableAdapter();
            this.materialTableAdapter = new Фотоуслуги.ФотоуслугиDataSetTableAdapters.materialTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материлыЗаПериодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Material.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialNavMenu)).BeginInit();
            this.MaterialNavMenu.SuspendLayout();
            this.MaterialTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialTypeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialTypeNavigator)).BeginInit();
            this.MaterialTypeNavigator.SuspendLayout();
            this.MaterialMovement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialMovementDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialMovementNavigator)).BeginInit();
            this.MaterialMovementNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотоуслугиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialnaskladeBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Material);
            this.tabControl1.Controls.Add(this.MaterialTypes);
            this.tabControl1.Controls.Add(this.MaterialMovement);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 423);
            this.tabControl1.TabIndex = 1;
            // 
            // Material
            // 
            this.Material.Controls.Add(this.MaterialDataGrid);
            this.Material.Controls.Add(this.MaterialNavMenu);
            this.Material.Location = new System.Drawing.Point(4, 22);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(780, 397);
            this.Material.TabIndex = 6;
            this.Material.Text = "Материалы";
            this.Material.UseVisualStyleBackColor = true;
            // 
            // MaterialDataGrid
            // 
            this.MaterialDataGrid.AllowUserToAddRows = false;
            this.MaterialDataGrid.AllowUserToDeleteRows = false;
            this.MaterialDataGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.MaterialDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaterialDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialDataGrid.Location = new System.Drawing.Point(0, 25);
            this.MaterialDataGrid.MultiSelect = false;
            this.MaterialDataGrid.Name = "MaterialDataGrid";
            this.MaterialDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MaterialDataGrid.RowHeadersVisible = false;
            this.MaterialDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MaterialDataGrid.Size = new System.Drawing.Size(780, 372);
            this.MaterialDataGrid.TabIndex = 4;
            // 
            // MaterialNavMenu
            // 
            this.MaterialNavMenu.AddNewItem = null;
            this.MaterialNavMenu.CountItem = null;
            this.MaterialNavMenu.DeleteItem = null;
            this.MaterialNavMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaterialAddButton,
            this.MaterialPostButton,
            this.MaterialDeleteButton});
            this.MaterialNavMenu.Location = new System.Drawing.Point(0, 0);
            this.MaterialNavMenu.MoveFirstItem = null;
            this.MaterialNavMenu.MoveLastItem = null;
            this.MaterialNavMenu.MoveNextItem = null;
            this.MaterialNavMenu.MovePreviousItem = null;
            this.MaterialNavMenu.Name = "MaterialNavMenu";
            this.MaterialNavMenu.PositionItem = null;
            this.MaterialNavMenu.Size = new System.Drawing.Size(780, 25);
            this.MaterialNavMenu.TabIndex = 3;
            this.MaterialNavMenu.Text = "bindingNavigator1";
            // 
            // MaterialAddButton
            // 
            this.MaterialAddButton.Image = ((System.Drawing.Image)(resources.GetObject("MaterialAddButton.Image")));
            this.MaterialAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MaterialAddButton.Name = "MaterialAddButton";
            this.MaterialAddButton.Size = new System.Drawing.Size(79, 22);
            this.MaterialAddButton.Text = "Добавить";
            this.MaterialAddButton.Click += new System.EventHandler(this.MaterialAddButton_Click);
            // 
            // MaterialPostButton
            // 
            this.MaterialPostButton.Image = ((System.Drawing.Image)(resources.GetObject("MaterialPostButton.Image")));
            this.MaterialPostButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MaterialPostButton.Name = "MaterialPostButton";
            this.MaterialPostButton.Size = new System.Drawing.Size(69, 22);
            this.MaterialPostButton.Text = "Приход";
            this.MaterialPostButton.Click += new System.EventHandler(this.MaterialPostButton_Click);
            // 
            // MaterialDeleteButton
            // 
            this.MaterialDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("MaterialDeleteButton.Image")));
            this.MaterialDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MaterialDeleteButton.Name = "MaterialDeleteButton";
            this.MaterialDeleteButton.Size = new System.Drawing.Size(71, 22);
            this.MaterialDeleteButton.Text = "Удалить";
            this.MaterialDeleteButton.Click += new System.EventHandler(this.MaterialDeleteButton_Click);
            // 
            // MaterialTypes
            // 
            this.MaterialTypes.Controls.Add(this.MaterialTypeDataGrid);
            this.MaterialTypes.Controls.Add(this.MaterialTypeNavigator);
            this.MaterialTypes.Location = new System.Drawing.Point(4, 22);
            this.MaterialTypes.Name = "MaterialTypes";
            this.MaterialTypes.Size = new System.Drawing.Size(780, 397);
            this.MaterialTypes.TabIndex = 7;
            this.MaterialTypes.Text = "Типы материалов";
            this.MaterialTypes.UseVisualStyleBackColor = true;
            // 
            // MaterialTypeDataGrid
            // 
            this.MaterialTypeDataGrid.AllowUserToAddRows = false;
            this.MaterialTypeDataGrid.AllowUserToDeleteRows = false;
            this.MaterialTypeDataGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.MaterialTypeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialTypeDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaterialTypeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialTypeDataGrid.Location = new System.Drawing.Point(0, 25);
            this.MaterialTypeDataGrid.MultiSelect = false;
            this.MaterialTypeDataGrid.Name = "MaterialTypeDataGrid";
            this.MaterialTypeDataGrid.ReadOnly = true;
            this.MaterialTypeDataGrid.RowHeadersVisible = false;
            this.MaterialTypeDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MaterialTypeDataGrid.Size = new System.Drawing.Size(780, 372);
            this.MaterialTypeDataGrid.TabIndex = 5;
            // 
            // MaterialTypeNavigator
            // 
            this.MaterialTypeNavigator.AddNewItem = null;
            this.MaterialTypeNavigator.CountItem = null;
            this.MaterialTypeNavigator.DeleteItem = null;
            this.MaterialTypeNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaterialTypeAddButton,
            this.MaterialTypeEditButton,
            this.MaterialTypeDeleteButton});
            this.MaterialTypeNavigator.Location = new System.Drawing.Point(0, 0);
            this.MaterialTypeNavigator.MoveFirstItem = null;
            this.MaterialTypeNavigator.MoveLastItem = null;
            this.MaterialTypeNavigator.MoveNextItem = null;
            this.MaterialTypeNavigator.MovePreviousItem = null;
            this.MaterialTypeNavigator.Name = "MaterialTypeNavigator";
            this.MaterialTypeNavigator.PositionItem = null;
            this.MaterialTypeNavigator.Size = new System.Drawing.Size(780, 25);
            this.MaterialTypeNavigator.TabIndex = 4;
            this.MaterialTypeNavigator.Text = "bindingNavigator1";
            // 
            // MaterialTypeAddButton
            // 
            this.MaterialTypeAddButton.Image = ((System.Drawing.Image)(resources.GetObject("MaterialTypeAddButton.Image")));
            this.MaterialTypeAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MaterialTypeAddButton.Name = "MaterialTypeAddButton";
            this.MaterialTypeAddButton.Size = new System.Drawing.Size(79, 22);
            this.MaterialTypeAddButton.Text = "Добавить";
            // 
            // MaterialTypeEditButton
            // 
            this.MaterialTypeEditButton.Image = ((System.Drawing.Image)(resources.GetObject("MaterialTypeEditButton.Image")));
            this.MaterialTypeEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MaterialTypeEditButton.Name = "MaterialTypeEditButton";
            this.MaterialTypeEditButton.Size = new System.Drawing.Size(81, 22);
            this.MaterialTypeEditButton.Text = "Изменить";
            this.MaterialTypeEditButton.Click += new System.EventHandler(this.MaterialTypeEditButton_Click);
            // 
            // MaterialTypeDeleteButton
            // 
            this.MaterialTypeDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("MaterialTypeDeleteButton.Image")));
            this.MaterialTypeDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MaterialTypeDeleteButton.Name = "MaterialTypeDeleteButton";
            this.MaterialTypeDeleteButton.Size = new System.Drawing.Size(71, 22);
            this.MaterialTypeDeleteButton.Text = "Удалить";
            // 
            // MaterialMovement
            // 
            this.MaterialMovement.Controls.Add(this.MaterialMovementDataGrid);
            this.MaterialMovement.Controls.Add(this.MaterialMovementNavigator);
            this.MaterialMovement.Location = new System.Drawing.Point(4, 22);
            this.MaterialMovement.Name = "MaterialMovement";
            this.MaterialMovement.Size = new System.Drawing.Size(780, 397);
            this.MaterialMovement.TabIndex = 8;
            this.MaterialMovement.Text = "Движения материалов";
            this.MaterialMovement.UseVisualStyleBackColor = true;
            // 
            // MaterialMovementDataGrid
            // 
            this.MaterialMovementDataGrid.AllowUserToAddRows = false;
            this.MaterialMovementDataGrid.AllowUserToDeleteRows = false;
            this.MaterialMovementDataGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.MaterialMovementDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MaterialMovementDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.MaterialMovementDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialMovementDataGrid.Location = new System.Drawing.Point(0, 25);
            this.MaterialMovementDataGrid.MultiSelect = false;
            this.MaterialMovementDataGrid.Name = "MaterialMovementDataGrid";
            this.MaterialMovementDataGrid.ReadOnly = true;
            this.MaterialMovementDataGrid.RowHeadersVisible = false;
            this.MaterialMovementDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MaterialMovementDataGrid.Size = new System.Drawing.Size(780, 372);
            this.MaterialMovementDataGrid.TabIndex = 6;
            // 
            // MaterialMovementNavigator
            // 
            this.MaterialMovementNavigator.AddNewItem = null;
            this.MaterialMovementNavigator.CountItem = null;
            this.MaterialMovementNavigator.DeleteItem = null;
            this.MaterialMovementNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripButton1});
            this.MaterialMovementNavigator.Location = new System.Drawing.Point(0, 0);
            this.MaterialMovementNavigator.MoveFirstItem = null;
            this.MaterialMovementNavigator.MoveLastItem = null;
            this.MaterialMovementNavigator.MoveNextItem = null;
            this.MaterialMovementNavigator.MovePreviousItem = null;
            this.MaterialMovementNavigator.Name = "MaterialMovementNavigator";
            this.MaterialMovementNavigator.PositionItem = null;
            this.MaterialMovementNavigator.Size = new System.Drawing.Size(780, 25);
            this.MaterialMovementNavigator.TabIndex = 4;
            this.MaterialMovementNavigator.Text = "bindingNavigator1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Поиск";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "material";
            this.materialBindingSource.DataSource = this.фотоуслугиDataSet;
            // 
            // фотоуслугиDataSet
            // 
            this.фотоуслугиDataSet.DataSetName = "ФотоуслугиDataSet";
            this.фотоуслугиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialnaskladeBindingSource
            // 
            this.materialnaskladeBindingSource.DataMember = "material_na_sklade";
            this.materialnaskladeBindingSource.DataSource = this.фотоуслугиDataSet;
            // 
            // material_na_skladeTableAdapter
            // 
            this.material_na_skladeTableAdapter.ClearBeforeFill = true;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отчётыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.материлыЗаПериодToolStripMenuItem});
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // материлыЗаПериодToolStripMenuItem
            // 
            this.материлыЗаПериодToolStripMenuItem.Name = "материлыЗаПериодToolStripMenuItem";
            this.материлыЗаПериодToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.материлыЗаПериодToolStripMenuItem.Text = "Материлы за период";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 447);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Кладовщик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            this.Material.ResumeLayout(false);
            this.Material.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialNavMenu)).EndInit();
            this.MaterialNavMenu.ResumeLayout(false);
            this.MaterialNavMenu.PerformLayout();
            this.MaterialTypes.ResumeLayout(false);
            this.MaterialTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialTypeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialTypeNavigator)).EndInit();
            this.MaterialTypeNavigator.ResumeLayout(false);
            this.MaterialTypeNavigator.PerformLayout();
            this.MaterialMovement.ResumeLayout(false);
            this.MaterialMovement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialMovementDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialMovementNavigator)).EndInit();
            this.MaterialMovementNavigator.ResumeLayout(false);
            this.MaterialMovementNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фотоуслугиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialnaskladeBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private ФотоуслугиDataSet фотоуслугиDataSet;
        private System.Windows.Forms.BindingSource materialnaskladeBindingSource;
        private ФотоуслугиDataSetTableAdapters.material_na_skladeTableAdapter material_na_skladeTableAdapter;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private ФотоуслугиDataSetTableAdapters.materialTableAdapter materialTableAdapter;
        private System.Windows.Forms.TabPage Material;
        private System.Windows.Forms.DataGridView MaterialDataGrid;
        private System.Windows.Forms.BindingNavigator MaterialNavMenu;
        private System.Windows.Forms.ToolStripButton MaterialAddButton;
        private System.Windows.Forms.ToolStripButton MaterialDeleteButton;
        private System.Windows.Forms.TabPage MaterialTypes;
        private System.Windows.Forms.DataGridView MaterialTypeDataGrid;
        private System.Windows.Forms.BindingNavigator MaterialTypeNavigator;
        private System.Windows.Forms.ToolStripButton MaterialTypeAddButton;
        private System.Windows.Forms.ToolStripButton MaterialTypeDeleteButton;
        private System.Windows.Forms.ToolStripButton MaterialTypeEditButton;
        private System.Windows.Forms.TabPage MaterialMovement;
        private System.Windows.Forms.DataGridView MaterialMovementDataGrid;
        private System.Windows.Forms.BindingNavigator MaterialMovementNavigator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материлыЗаПериодToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton MaterialPostButton;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}