using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDVIBasicWinForms5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string text = "Choosen animals: ";
            if (mouseCheckBox.Checked)
                text = text + " mouse";
            if (catCheckBox.Checked)
                text = text + " cat";
            if (dogCheckBox.Checked)
                text = text + " dog";

            textBox1.Text = text;
        }
    }
}
