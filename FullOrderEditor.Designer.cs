namespace Фотоуслуги
{
    partial class FullOrderEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullOrderEditor));
            this.label2 = new System.Windows.Forms.Label();
            this.OrderDateLbl = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.KlientBox = new System.Windows.Forms.TextBox();
            this.CompleteDateBox = new System.Windows.Forms.DateTimePicker();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderDataGrid = new System.Windows.Forms.DataGridView();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.OrderUslugaAddButton = new System.Windows.Forms.ToolStripButton();
            this.OrderUslugaDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата исполнения:";
            // 
            // OrderDateLbl
            // 
            this.OrderDateLbl.AutoSize = true;
            this.OrderDateLbl.Location = new System.Drawing.Point(24, 25);
            this.OrderDateLbl.Name = "OrderDateLbl";
            this.OrderDateLbl.Size = new System.Drawing.Size(78, 13);
            this.OrderDateLbl.TabIndex = 15;
            this.OrderDateLbl.Text = "Дата заказа: ";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(197, 415);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(200, 23);
            this.AcceptButton.TabIndex = 14;
            this.AcceptButton.Text = "button3";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // KlientBox
            // 
            this.KlientBox.Enabled = false;
            this.KlientBox.Location = new System.Drawing.Point(27, 127);
            this.KlientBox.Name = "KlientBox";
            this.KlientBox.Size = new System.Drawing.Size(200, 20);
            this.KlientBox.TabIndex = 12;
            // 
            // CompleteDateBox
            // 
            this.CompleteDateBox.Location = new System.Drawing.Point(27, 75);
            this.CompleteDateBox.Name = "CompleteDateBox";
            this.CompleteDateBox.Size = new System.Drawing.Size(200, 20);
            this.CompleteDateBox.TabIndex = 11;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(277, 25);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(62, 13);
            this.PriceLbl.TabIndex = 18;
            this.PriceLbl.Text = "Стоимость";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrderDataGrid);
            this.panel1.Controls.Add(this.bindingNavigator2);
            this.panel1.Location = new System.Drawing.Point(27, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 210);
            this.panel1.TabIndex = 19;
            // 
            // OrderDataGrid
            // 
            this.OrderDataGrid.AllowUserToAddRows = false;
            this.OrderDataGrid.AllowUserToDeleteRows = false;
            this.OrderDataGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.OrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDataGrid.GridColor = System.Drawing.Color.Lavender;
            this.OrderDataGrid.Location = new System.Drawing.Point(0, 25);
            this.OrderDataGrid.Name = "OrderDataGrid";
            this.OrderDataGrid.ReadOnly = true;
            this.OrderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGrid.Size = new System.Drawing.Size(530, 185);
            this.OrderDataGrid.TabIndex = 18;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderUslugaAddButton,
            this.OrderUslugaDeleteButton});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(530, 25);
            this.bindingNavigator2.TabIndex = 3;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // OrderUslugaAddButton
            // 
            this.OrderUslugaAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrderUslugaAddButton.Image = ((System.Drawing.Image)(resources.GetObject("OrderUslugaAddButton.Image")));
            this.OrderUslugaAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrderUslugaAddButton.Name = "OrderUslugaAddButton";
            this.OrderUslugaAddButton.Size = new System.Drawing.Size(23, 22);
            this.OrderUslugaAddButton.Text = "toolStripButton2";
            this.OrderUslugaAddButton.Click += new System.EventHandler(this.OrderUslugaAddButton_Click);
            // 
            // OrderUslugaDeleteButton
            // 
            this.OrderUslugaDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrderUslugaDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("OrderUslugaDeleteButton.Image")));
            this.OrderUslugaDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrderUslugaDeleteButton.Name = "OrderUslugaDeleteButton";
            this.OrderUslugaDeleteButton.Size = new System.Drawing.Size(23, 22);
            this.OrderUslugaDeleteButton.Text = "toolStripButton8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Услуги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Клиент";
            // 
            // FullOrderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderDateLbl);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.KlientBox);
            this.Controls.Add(this.CompleteDateBox);
            this.Name = "FullOrderEditor";
            this.Text = "FullOrderEditor";
            this.Load += new System.EventHandler(this.FullOrderEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OrderDateLbl;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TextBox KlientBox;
        private System.Windows.Forms.DateTimePicker CompleteDateBox;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView OrderDataGrid;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton OrderUslugaAddButton;
        private System.Windows.Forms.ToolStripButton OrderUslugaDeleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}