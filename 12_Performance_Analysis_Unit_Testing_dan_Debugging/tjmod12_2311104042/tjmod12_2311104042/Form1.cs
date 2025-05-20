using System;
using System.Windows.Forms;

namespace tjmod12_2311104042
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(textBox1.Text, out a) || !int.TryParse(textBox2.Text, out b))
            {
                label1.Text = "Input harus berupa angka";
                return;
            }

            int hasil = PangkatHelper.CariNilaiPangkat(a, b);

            switch (hasil)
            {
                case -1:
                    label1.Text = "Input b negatif";
                    break;
                case -2:
                    label1.Text = "Input tidak sesuai ketentuan (a > 100 atau b > 10)";
                    break;
                case -3:
                    label1.Text = "Hasil melebihi batas maksimum int";
                    break;
                default:
                    label1.Text = $"Hasil: {hasil}";
                    break;
            }
        }
    }
}
