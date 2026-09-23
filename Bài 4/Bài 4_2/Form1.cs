using System;
using System.Windows.Forms;

namespace FromCalculator
{
    public partial class Form1 : Form
    {
        private double? storedValue = null;
        private string currentOperator = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            // Cast sender to Button and append its text to the display
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0") txtDisplay.Text = btn.Text;
            else txtDisplay.Text += btn.Text;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            // If there's a pending operator, compute intermediate result
            if (storedValue.HasValue && !string.IsNullOrEmpty(currentOperator) && double.TryParse(txtDisplay.Text, out double right))
            {
                storedValue = Compute(storedValue.Value, right, currentOperator);
                txtDisplay.Text = storedValue.ToString();
            }
            else if (!storedValue.HasValue && double.TryParse(txtDisplay.Text, out double val))
            {
                storedValue = val;
            }

            currentOperator = btn.Text;
            txtDisplay.Clear();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!storedValue.HasValue || string.IsNullOrEmpty(currentOperator)) return;
            if (!double.TryParse(txtDisplay.Text, out double right)) return;

            double result = Compute(storedValue.Value, right, currentOperator);
            txtDisplay.Text = result.ToString();
            // reset
            storedValue = null;
            currentOperator = null;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            storedValue = null;
            currentOperator = null;
        }

        private double Compute(double left, double right, string op)
        {
            return op switch
            {
                "+" => left + right,
                "-" => left - right,
                "*" => left * right,
                "/" => right == 0 ? 0 : left / right,
                _ => right,
            };
        }
    }
}
