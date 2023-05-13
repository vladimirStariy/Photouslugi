namespace Фотоуслуги
{
    partial class UslugaEditor
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UslugaTypeBox = new System.Windows.Forms.ComboBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.StoimBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(87, 90);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(117, 20);
            this.NameBox.TabIndex = 0;
            // 
            // UslugaTypeBox
            // 
            this.UslugaTypeBox.FormattingEnabled = true;
            this.UslugaTypeBox.Location = new System.Drawing.Point(87, 140);
            this.UslugaTypeBox.Name = "UslugaTypeBox";
            this.UslugaTypeBox.Size = new System.Drawing.Size(117, 21);
            this.UslugaTypeBox.TabIndex = 1;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(87, 232);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(117, 33);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "button1";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // StoimBox
            // 
            this.StoimBox.Location = new System.Drawing.Point(87, 185);
            this.StoimBox.Name = "StoimBox";
            this.StoimBox.Size = new System.Drawing.Size(117, 20);
            this.StoimBox.TabIndex = 3;
            // 
            // UslugaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.StoimBox);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.UslugaTypeBox);
            this.Controls.Add(this.NameBox);
            this.Name = "UslugaEditor";
            this.Text = "UslugaEditor";
            this.Load += new System.EventHandler(this.UslugaEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ComboBox UslugaTypeBox;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.TextBox StoimBox;
    }
}