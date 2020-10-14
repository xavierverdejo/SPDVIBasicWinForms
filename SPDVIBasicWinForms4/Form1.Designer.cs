namespace SPDVIBasicWinForms4
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
            this.sumButton = new System.Windows.Forms.Button();
            this.subsButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.operandBox1 = new System.Windows.Forms.TextBox();
            this.operandBox2 = new System.Windows.Forms.TextBox();
            this.operationBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(519, 153);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(206, 64);
            this.sumButton.TabIndex = 0;
            this.sumButton.Text = "SUM";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // subsButton
            // 
            this.subsButton.Location = new System.Drawing.Point(519, 254);
            this.subsButton.Name = "subsButton";
            this.subsButton.Size = new System.Drawing.Size(206, 60);
            this.subsButton.TabIndex = 1;
            this.subsButton.Text = "SUBSTRACT";
            this.subsButton.UseVisualStyleBackColor = true;
            this.subsButton.Click += new System.EventHandler(this.subsButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(1143, 550);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(138, 51);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // operandBox1
            // 
            this.operandBox1.Location = new System.Drawing.Point(132, 186);
            this.operandBox1.Name = "operandBox1";
            this.operandBox1.Size = new System.Drawing.Size(100, 31);
            this.operandBox1.TabIndex = 3;
            // 
            // operandBox2
            // 
            this.operandBox2.Location = new System.Drawing.Point(132, 269);
            this.operandBox2.Name = "operandBox2";
            this.operandBox2.Size = new System.Drawing.Size(100, 31);
            this.operandBox2.TabIndex = 4;
            // 
            // operationBox
            // 
            this.operationBox.Enabled = false;
            this.operationBox.Location = new System.Drawing.Point(579, 397);
            this.operationBox.Name = "operationBox";
            this.operationBox.Size = new System.Drawing.Size(100, 31);
            this.operationBox.TabIndex = 5;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(897, 186);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 31);
            this.resultBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(132, 461);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(206, 60);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 623);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.operationBox);
            this.Controls.Add(this.operandBox2);
            this.Controls.Add(this.operandBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.subsButton);
            this.Controls.Add(this.sumButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button subsButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox operandBox1;
        private System.Windows.Forms.TextBox operandBox2;
        private System.Windows.Forms.TextBox operationBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

