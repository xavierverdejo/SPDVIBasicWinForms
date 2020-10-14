using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIBasicWinForms4
{
    public partial class Form1 : Form
    {
        int operationType = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            operationType = 0;
            operationBox.Text = "+";
        }

        private void subsButton_Click(object sender, EventArgs e)
        {
            operationType = 1;
            operationBox.Text = "-";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(operandBox1.Text);
                int b = Convert.ToInt32(operandBox2.Text);
                if (operationType == -1)
                    MessageBox.Show("Please choose an operator.");
                else if (operationType == 0)
                    resultBox.Text = (a + b)+"";
                else
                    resultBox.Text = (a - b)+"";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please type the two numbers.");
            }
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            operandBox1.Clear();
            operandBox2.Clear();
            operationBox.Clear();
            resultBox.Clear();
            operationType = -1;
        }
    }
}
