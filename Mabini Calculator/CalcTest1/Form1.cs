using System;
using System.Windows.Forms;

namespace CalcTest1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double result;
        string _operator;

        #region Button Click Events
        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void addition_Click(object sender, EventArgs e)
        {
            textBox1.Text += " + ";
            _operator = "+";
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            textBox1.Text += " - ";
            _operator = "-";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            textBox1.Text += " * ";
            _operator = "*";
        }

        private void division_Click(object sender, EventArgs e)
        {
            textBox1.Text += " / ";
            _operator = "/";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (_operator == "/")
            {
                int findZero = textBox1.Text.IndexOf("/");
                if (Convert.ToDouble(textBox1.Text.Substring(findZero + 2)) == 0) // TODO: find "/" and scan if 0 is divisor.
                {
                    textBox1.Text = "Cannot divide by zero";
                }
            }
            else
            {
                result = Evaluate(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
            }
        }
        #endregion


        // Evaluate function taken from my gist: https://gist.github.com/GReturn/4a0feb0940c4926bc56898e53fffb239

        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}