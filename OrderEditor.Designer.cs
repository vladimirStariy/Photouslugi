namespace Фотоуслуги
{
    partial class OrderEditor
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
            this.CompleteDateBox = new System.Windows.Forms.DateTimePicker();
            this.KlientSlcBtn = new System.Windows.Forms.Button();
            this.KlientBox = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompleteDateBox
            // 
            this.CompleteDateBox.Location = new System.Drawing.Point(25, 104);
            this.CompleteDateBox.Name = "CompleteDateBox";
            this.CompleteDateBox.Size = new System.Drawing.Size(200, 20);
            this.CompleteDateBox.TabIndex = 1;
            // 
            // KlientSlcBtn
            // 
            this.KlientSlcBtn.Location = new System.Drawing.Point(195, 149);
            this.KlientSlcBtn.Name = "KlientSlcBtn";
            this.KlientSlcBtn.Size = new System.Drawing.Size(30, 23);
            this.KlientSlcBtn.TabIndex = 6;
            this.KlientSlcBtn.Text = "...";
            this.KlientSlcBtn.UseVisualStyleBackColor = true;
            this.KlientSlcBtn.Click += new System.EventHandler(this.KlientSlcBtn_Click);
            // 
            // KlientBox
            // 
            this.KlientBox.Location = new System.Drawing.Point(25, 149);
            this.KlientBox.Name = "KlientBox";
            this.KlientBox.Size = new System.Drawing.Size(164, 20);
            this.KlientBox.TabIndex = 5;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(25, 207);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(200, 23);
            this.AcceptButton.TabIndex = 7;
            this.AcceptButton.Text = "button3";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // OrderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.KlientSlcBtn);
            this.Controls.Add(this.KlientBox);
            this.Controls.Add(this.CompleteDateBox);
            this.Name = "OrderEditor";
            this.Text = "OrderEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker CompleteDateBox;
        private System.Windows.Forms.Button KlientSlcBtn;
        private System.Windows.Forms.TextBox KlientBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label2;
    }
}