using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void One_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private string NormalizeExpression(string expr)
        {
            if (string.IsNullOrWhiteSpace(expr))
                return expr;

            // remove spaces
            expr = expr.Replace(" ", "");

            // normalize UI symbols to arithmetic symbols
            expr = expr.Replace("×", "*");
            expr = expr.Replace("÷", "/");

            // Insert explicit multiplication for common implicit cases:
            // 1) number or ) followed immediately by (   ->  "9("  or ")("  => "9*("  or ")*("
            expr = Regex.Replace(expr, @"(?<=[0-9\)])\s*\(", "*(");

            // 2) ')' followed by number or '('  -> ")5" => ")*5" (the other case ")(" already handled, this is for ")5")
            expr = Regex.Replace(expr, @"\)\s*(?=[0-9\(])", ")*");

            // 3) number followed by '(' handled by #1, but also handle number followed by unary minus like "2-(" is fine
            //    Edge case: number followed by '(' already done.

            // 4) number followed by a variable or constant (if you had 'pi' or 'e') - not needed here.

            // (Optional) Prevent accidental patterns like "--(" from becoming something weird.
            // We won't change unary minus patterns; they are kept as-is (e.g. "-(3+2)").

            return expr;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                string expr = txtDisplay.Text;
                expr = NormalizeExpression(expr);

                // Quick validation: allow only digits, operators and parentheses and decimal point
                string allowed = "0123456789+-*/().";
                if (expr.Any(ch => !allowed.Contains(ch)))
                {
                    txtDisplay.Text = "Error";
                    return;
                }
                var result = new DataTable().Compute(expr, "");
                txtDisplay.Text = result.ToString();
            }
            catch
            {
                txtDisplay.Text = "Error";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void BackSp_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void Deciminal_Click(object sender, EventArgs e)
        {
            // Prevent adding two decimals inside the same number
            string text = txtDisplay.Text;

            if (text == "" || text.EndsWith("+") || text.EndsWith("-") ||
                text.EndsWith("×") || text.EndsWith("÷") || text.EndsWith("("))
            {
                txtDisplay.Text += "0."; // Example: typing "." becomes "0."
            }
            else
            {
                // Find the last operator to check the current number
                int index =
    Math.Max(text.LastIndexOf('+'),
    Math.Max(text.LastIndexOf('-'),
    Math.Max(text.LastIndexOf('×'),
    Math.Max(text.LastIndexOf('÷'),
             text.LastIndexOf('(')))));

                string currentNumber = text.Substring(index + 1);

                if (!currentNumber.Contains("."))
                    txtDisplay.Text += ".";
            }
        }

        private void OpenBr_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "(";
        }

        private void CloseBr_Click(object sender, EventArgs e)
        {
            string text = txtDisplay.Text;

            int open = text.Count(c => c == '(');
            int close = text.Count(c => c == ')');

            if (open > close)
                txtDisplay.Text += ")";
        }
    }
}
