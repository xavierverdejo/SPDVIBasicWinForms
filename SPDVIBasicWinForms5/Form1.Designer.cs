namespace SPDVIBasicWinForms5
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
            this.mouseCheckBox = new System.Windows.Forms.CheckBox();
            this.catCheckBox = new System.Windows.Forms.CheckBox();
            this.dogCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mouseCheckBox
            // 
            this.mouseCheckBox.AutoSize = true;
            this.mouseCheckBox.Location = new System.Drawing.Point(51, 41);
            this.mouseCheckBox.Name = "mouseCheckBox";
            this.mouseCheckBox.Size = new System.Drawing.Size(109, 29);
            this.mouseCheckBox.TabIndex = 0;
            this.mouseCheckBox.Text = "Mouse";
            this.mouseCheckBox.UseVisualStyleBackColor = true;
            // 
            // catCheckBox
            // 
            this.catCheckBox.AutoSize = true;
            this.catCheckBox.Location = new System.Drawing.Point(51, 251);
            this.catCheckBox.Name = "catCheckBox";
            this.catCheckBox.Size = new System.Drawing.Size(77, 29);
            this.catCheckBox.TabIndex = 1;
            this.catCheckBox.Text = "Cat";
            this.catCheckBox.UseVisualStyleBackColor = true;
            // 
            // dogCheckBox
            // 
            this.dogCheckBox.AutoSize = true;
            this.dogCheckBox.Location = new System.Drawing.Point(51, 445);
            this.dogCheckBox.Name = "dogCheckBox";
            this.dogCheckBox.Size = new System.Drawing.Size(83, 29);
            this.dogCheckBox.TabIndex = 2;
            this.dogCheckBox.Text = "Dog";
            this.dogCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(51, 520);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(176, 60);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK!";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(51, 628);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(594, 40);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 726);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dogCheckBox);
            this.Controls.Add(this.catCheckBox);
            this.Controls.Add(this.mouseCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox mouseCheckBox;
        private System.Windows.Forms.CheckBox catCheckBox;
        private System.Windows.Forms.CheckBox dogCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

