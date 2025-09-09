using System;
using System.Data;
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
        bool isError = false;

        #region Button Click Events
        private void n1_Click(object sender, EventArgs e)
        {
            clearError(textBox1);
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
            clearError(textBox1);
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
            clearError(textBox1);
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
            clearError(textBox1);
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
            clearError(textBox1);
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
            clearError(textBox1);
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
            clearError(textBox1);
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
            clearError(textBox1);
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
            clearError(textBox1);
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
            clearError(textBox1);
            textBox1.Text = textBox1.Text + "0";
        }

        private void point_Click(object sender, EventArgs e)
        {
            clearError(textBox1);
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
            isError = false;
            textBox1.Text = "0";
        }

        private void addition_Click(object sender, EventArgs e)
        {
            clearError(textBox1);
            textBox1.Text += " + ";
            _operator = "+";
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            clearError(textBox1);
            textBox1.Text += " - ";
            _operator = "-";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            clearError(textBox1);
            textBox1.Text += " * ";
            _operator = "*";
        }

        private void division_Click(object sender, EventArgs e)
        {
            clearError(textBox1);
            textBox1.Text += " / ";
            _operator = "/";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            clearError(textBox1);
            try
            {
                result = Evaluate(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
            }
            catch(Exception ex) when (ex is DivideByZeroException || (ex is EvaluateException))
            {
                textBox1.Text = "Cannot divide by zero";
                isError = true;
            }
            catch(Exception ex)
            {
                textBox1.Text = "An error occurred";
                isError = true;
                Console.WriteLine(ex.Message);
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
            double result = double.Parse((string)row["expression"]);

            if(double.IsInfinity(result) || double.IsNaN(result))
            {
                throw new DivideByZeroException();
            }
            return result;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void clearError(TextBox textBox)
        {
            if(isError)
            {
                textBox.Text = "0";
                isError = false;
            }
        }
    }
}