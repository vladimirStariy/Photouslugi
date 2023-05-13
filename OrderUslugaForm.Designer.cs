namespace Фотоуслуги
{
    partial class OrderUslugaForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.UslugaSlcBtn = new System.Windows.Forms.Button();
            this.UslugaBox = new System.Windows.Forms.TextBox();
            this.MaterialSlcBtn = new System.Windows.Forms.Button();
            this.MaterialZakaza = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(45, 273);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(200, 23);
            this.AcceptButton.TabIndex = 10;
            this.AcceptButton.Text = "button3";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // UslugaSlcBtn
            // 
            this.UslugaSlcBtn.Location = new System.Drawing.Point(215, 97);
            this.UslugaSlcBtn.Name = "UslugaSlcBtn";
            this.UslugaSlcBtn.Size = new System.Drawing.Size(30, 23);
            this.UslugaSlcBtn.TabIndex = 9;
            this.UslugaSlcBtn.Text = "...";
            this.UslugaSlcBtn.UseVisualStyleBackColor = true;
            this.UslugaSlcBtn.Click += new System.EventHandler(this.UslugaSlcBtn_Click);
            // 
            // UslugaBox
            // 
            this.UslugaBox.Enabled = false;
            this.UslugaBox.Location = new System.Drawing.Point(45, 97);
            this.UslugaBox.Name = "UslugaBox";
            this.UslugaBox.Size = new System.Drawing.Size(164, 20);
            this.UslugaBox.TabIndex = 8;
            // 
            // MaterialSlcBtn
            // 
            this.MaterialSlcBtn.Location = new System.Drawing.Point(215, 164);
            this.MaterialSlcBtn.Name = "MaterialSlcBtn";
            this.MaterialSlcBtn.Size = new System.Drawing.Size(30, 23);
            this.MaterialSlcBtn.TabIndex = 12;
            this.MaterialSlcBtn.Text = "...";
            this.MaterialSlcBtn.UseVisualStyleBackColor = true;
            this.MaterialSlcBtn.Click += new System.EventHandler(this.MaterialSlcBtn_Click);
            // 
            // MaterialZakaza
            // 
            this.MaterialZakaza.Enabled = false;
            this.MaterialZakaza.Location = new System.Drawing.Point(45, 164);
            this.MaterialZakaza.Name = "MaterialZakaza";
            this.MaterialZakaza.Size = new System.Drawing.Size(164, 20);
            this.MaterialZakaza.TabIndex = 11;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(45, 227);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(200, 20);
            this.CountBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Услуга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Материал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Количество";
            // 
            // OrderUslugaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.MaterialSlcBtn);
            this.Controls.Add(this.MaterialZakaza);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.UslugaSlcBtn);
            this.Controls.Add(this.UslugaBox);
            this.Name = "OrderUslugaForm";
            this.Text = "OrderUslugaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button UslugaSlcBtn;
        private System.Windows.Forms.TextBox UslugaBox;
        private System.Windows.Forms.Button MaterialSlcBtn;
        private System.Windows.Forms.TextBox MaterialZakaza;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}