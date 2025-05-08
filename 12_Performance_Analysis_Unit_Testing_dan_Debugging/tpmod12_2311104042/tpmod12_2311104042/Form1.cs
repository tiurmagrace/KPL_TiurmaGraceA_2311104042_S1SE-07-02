using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmod12_2311104042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(textBox1.Text, out input))
            {
                label1.Text = TandaBilanganHelper.CariTandaBilangan(input);
            }
            else
            {
                label1.Text = "Input tidak valid!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
