using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Class_Project
{
    public partial class Form1 : Form
    {
        private double input1;
        private string sing;
        private double lastInput2 = 0;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txInput.Text == "0")
            {
                txInput.Text = "";
            }
            txInput.Text += btn.Text;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NumberButton_Click(sender, e);
        }

        private void btAc_Click(object sender, EventArgs e)
        {
            txInput.Text = "0";
            label1.Text = "";
            label2.Text = "";
            this.lastInput2 = 0;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txInput.Text, out double input))
            {
                this.input1 = input;
                this.sing = "+";
                label1.Text = txInput.Text + " " + sing;  // Update label to show calculation in progress
                txInput.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btsub_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txInput.Text, out double input))
            {
                this.input1 = input;
                this.sing = "-";
                label1.Text = txInput.Text + " " + sing;
                txInput.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btmul_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txInput.Text, out double input))
            {
                this.input1 = input;
                this.sing = "X";
                label1.Text = txInput.Text + " " + sing;
                txInput.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void budiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txInput.Text, out double input))
            {
                this.input1 = input;
                this.sing = "/";
                label1.Text = txInput.Text + " " + sing;
                txInput.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txInput.Text.Contains("."))
            {
                if (txInput.Text == "0")
                {
                    txInput.Text = "0.";
                }
                else
                {
                    txInput.Text += ".";
                }
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            double input2;
            if (double.TryParse(txInput.Text, out input2)) // Parsing the second number
            {
                double result = 0;

                // Perform the operation based on the selected operator
                switch (this.sing)
                {
                    case "+":
                        result = input1 + input2;
                        break;
                    case "-":
                        result = input1 - input2;
                        break;
                    case "X":
                        result = input1 * input2;
                        break;
                    case "/":
                        if (input2 != 0)
                        {
                            result = input1 / input2;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Invalid operation.");
                        return;
                }

                // Display the result
                txInput.Text = result.ToString();
                label1.Text = label1.Text + " " + input2.ToString() + " ="; // Show the complete equation
                this.input1 = result; // Store the result for future calculations
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            
        }
    }
}