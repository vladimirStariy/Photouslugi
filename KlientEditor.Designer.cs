namespace Фотоуслуги
{
    partial class KlientEditor
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
            this.FamBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PotBox = new System.Windows.Forms.TextBox();
            this.AdrBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FamBox
            // 
            this.FamBox.Location = new System.Drawing.Point(81, 42);
            this.FamBox.Name = "FamBox";
            this.FamBox.Size = new System.Drawing.Size(100, 20);
            this.FamBox.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(81, 82);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            // 
            // PotBox
            // 
            this.PotBox.Location = new System.Drawing.Point(81, 130);
            this.PotBox.Name = "PotBox";
            this.PotBox.Size = new System.Drawing.Size(100, 20);
            this.PotBox.TabIndex = 2;
            // 
            // AdrBox
            // 
            this.AdrBox.Location = new System.Drawing.Point(81, 188);
            this.AdrBox.Name = "AdrBox";
            this.AdrBox.Size = new System.Drawing.Size(100, 20);
            this.AdrBox.TabIndex = 3;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(81, 237);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneBox.TabIndex = 4;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(81, 287);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 5;
            this.AcceptButton.Text = "button1";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // KlientEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 365);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.AdrBox);
            this.Controls.Add(this.PotBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.FamBox);
            this.Name = "KlientEditor";
            this.Text = "KlientEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FamBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PotBox;
        private System.Windows.Forms.TextBox AdrBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Button AcceptButton;
    }
}