using System;
using System.Windows.Forms;

namespace KPL_TiurmaGraceA_2311104042_S1SE_07_02
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private int total = 0;  
        private bool isNewInput = true;  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelOutput.Text = "0";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonText = button.Text;

            if (char.IsDigit(buttonText, 0))
            {
                if (isNewInput)
                {
                    currentInput = buttonText;  
                    isNewInput = false;
                }
                else
                {
                    currentInput += buttonText;  
                }
                labelOutput.Text = currentInput;
            }
            else if (buttonText == "+")
            {
                if (!string.IsNullOrEmpty(currentInput))
                {
                    total += int.Parse(currentInput);  
                    currentInput = "";
                    labelOutput.Text = total.ToString();
                    isNewInput = true;  
                }
            }
            else if (buttonText == "=")
            {
                if (!string.IsNullOrEmpty(currentInput))
                {
                    total += int.Parse(currentInput);  
                }

                labelOutput.Text = total.ToString();

                currentInput = "";
                total = 0;
                isNewInput = true;
            }
        }
    }
}
