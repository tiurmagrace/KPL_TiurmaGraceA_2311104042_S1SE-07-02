using System;
using System.Windows.Forms;

namespace KPL_TiurmaGraceA_2311104042_S1SE_07_02
{
    public partial class Form1 : Form
    {
        private string currentInput = "";
        private string operand1 = "";
        private string operation = "";

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
                currentInput += buttonText;
                labelOutput.Text = currentInput;
            }
            else if (buttonText == "+")
            {
                if (!string.IsNullOrEmpty(currentInput))
                {
                    operand1 = currentInput;
                    currentInput = "";
                    operation = buttonText;
                    labelOutput.Text = "0";
                }
            }
            else if (buttonText == "=")
            {
                if (!string.IsNullOrEmpty(operand1) && !string.IsNullOrEmpty(currentInput))
                {
                    int result = 0;

                    if (operation == "+")
                    {
                        result = int.Parse(operand1) + int.Parse(currentInput);
                    }

                    labelOutput.Text = result.ToString();

                    currentInput = "";
                    operand1 = "";
                    operation = "";
                }
            }
        }
    }
}
