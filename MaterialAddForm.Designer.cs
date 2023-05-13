namespace Фотоуслуги
{
    partial class MaterialAddForm
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
            this.NaimBox = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.MaterialTypeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NaimBox
            // 
            this.NaimBox.Location = new System.Drawing.Point(52, 69);
            this.NaimBox.Name = "NaimBox";
            this.NaimBox.Size = new System.Drawing.Size(134, 20);
            this.NaimBox.TabIndex = 0;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(52, 108);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(134, 20);
            this.CountBox.TabIndex = 1;
            // 
            // MaterialTypeBox
            // 
            this.MaterialTypeBox.FormattingEnabled = true;
            this.MaterialTypeBox.Location = new System.Drawing.Point(51, 186);
            this.MaterialTypeBox.Name = "MaterialTypeBox";
            this.MaterialTypeBox.Size = new System.Drawing.Size(134, 21);
            this.MaterialTypeBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(52, 147);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(134, 20);
            this.PriceBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип материала";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(52, 245);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(134, 23);
            this.AcceptButton.TabIndex = 8;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // MaterialAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 312);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaterialTypeBox);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.NaimBox);
            this.Name = "MaterialAddForm";
            this.Text = "MaterialAddForm";
            this.Load += new System.EventHandler(this.MaterialAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NaimBox;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.ComboBox MaterialTypeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AcceptButton;
    }
}