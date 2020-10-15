using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIBasicWinForms9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertNumbers(true);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            insertNumbers(false);
        }
        private void insertNumbers(bool even)
        {
            comboBox1.Items.Clear();
            for(int i = 0; i<10; i++)
            {
                if (i % 2 == 0 && even)
                    comboBox1.Items.Add("Nº" + i);
                else if (i % 2 != 0 && !even)
                    comboBox1.Items.Add("Nº" + i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
