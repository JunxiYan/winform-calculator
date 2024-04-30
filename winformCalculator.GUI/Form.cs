using winformCalculator.Core;
namespace winformCalculator.GUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void buttonSolution_Click(object sender, EventArgs e)
        {
            var calculate = new winformCalculator.Core.CalculatorCore();
            {
                string Expression = textBox.Text;
            };
            var result = calculate.Calculate(textBox.Text);
            textBox.Text = result;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox.Text += "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox.Text += "-";
        }

        private void buttonMultipy_Click(object sender, EventArgs e)
        {
            textBox.Text += "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox.Text += "/";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }

        private void buttonLeftparen_Click(object sender, EventArgs e)
        {
            textBox.Text += "(";
        }

        private void buttonRightparen_Click(object sender, EventArgs e)
        {
            textBox.Text += ")";
        }
    }
}
