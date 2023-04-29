namespace show_me_the_ASCII
{
    partial class Form1
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
            this.ReadAndConverttextBox = new System.Windows.Forms.TextBox();
            this.ReadAndConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadAndConverttextBox
            // 
            this.ReadAndConverttextBox.Location = new System.Drawing.Point(27, 45);
            this.ReadAndConverttextBox.Name = "ReadAndConverttextBox";
            this.ReadAndConverttextBox.Size = new System.Drawing.Size(110, 29);
            this.ReadAndConverttextBox.TabIndex = 0;
            // 
            // ReadAndConvertButton
            // 
            this.ReadAndConvertButton.Location = new System.Drawing.Point(159, 41);
            this.ReadAndConvertButton.Name = "ReadAndConvertButton";
            this.ReadAndConvertButton.Size = new System.Drawing.Size(237, 38);
            this.ReadAndConvertButton.TabIndex = 1;
            this.ReadAndConvertButton.Text = "獲取對應字符或ASCII";
            this.ReadAndConvertButton.UseVisualStyleBackColor = true;
            this.ReadAndConvertButton.Click += new System.EventHandler(this.ReadAndConvertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReadAndConvertButton);
            this.Controls.Add(this.ReadAndConverttextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReadAndConverttextBox;
        private System.Windows.Forms.Button ReadAndConvertButton;
    }
}

