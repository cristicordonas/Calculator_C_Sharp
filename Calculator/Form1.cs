namespace Calculator
{
    public partial class Form1 : Form
    {
        float operand1 = 0;
        float operand2 = 0;
        string operation = "";
        string trigon = "";
        bool enter_value = false;
        bool press_equal = false;
        bool par_mode = false;
        public Form1()
        {
            InitializeComponent();
            StandardToolStripMenuItem_Click(this, new EventArgs());
        }
        private void ButtonsNumC_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (!par_mode)
            {
                if (textBox.Text == "0" || enter_value)
                    textBox.Clear();
                enter_value = false;
                if (num.Text == ",")
                {
                    if (!textBox.Text.Contains(","))
                    {
                        if (textBox.Text == "")
                            textBox.Text = "0,";
                        else
                            textBox.Text += num.Text;
                    }
                }
                else
                {
                    textBox.Text += num.Text;
                    operand2 = float.Parse(textBox.Text);
                }
            }
            else
            {
                if (num.Text == ",")
                    textBox.Text += ".";
                else
                    textBox.Text += num.Text;
            }
        }
        private void Operators_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (!par_mode)
            {
                if (label.Text == "")
                    operand1 = float.Parse(textBox.Text);
                if (press_equal)
                {
                    operand2 = operand1;
                    operand1 = float.Parse(textBox.Text);
                    press_equal = false;
                }
                else
                    Calculate();
                operation = num.Text;
                if (operation == "Mod")
                    operation = "%";
                if (operation == "x^y")
                    operation = "^";
                if (operation == "x^(1/y)")
                    operation = "yroot";
                if (operation == "logx(y)")
                    operation = "log base";
                label.Text = operand1.ToString() + operation;
                enter_value = true;
            }
            else
                textBox.Text += num.Text;
        }
        void Calculate()
        {
            switch (operation)
            {
                case "+":
                    operand1 += operand2;
                    textBox.Text = operand1.ToString();
                    break;
                case "-":
                    operand1 -= operand2;
                    textBox.Text = operand1.ToString();
                    break;
                case "*":
                    operand1 *= operand2;
                    textBox.Text = operand1.ToString();
                    break;
                case "/":
                    operand1 /= operand2;
                    textBox.Text = operand1.ToString();
                    break;
                case "%":
                    operand1 %= operand2;
                    textBox.Text = operand1.ToString();
                    break;
                case "^":
                    operand1 = (float)Math.Pow(operand1, operand2);
                    textBox.Text = operand1.ToString();
                    break;
                case "yroot":
                    operand1 = (float)Math.Pow(operand1, 1 / operand2);
                    textBox.Text = operand1.ToString();
                    break;
                case "log base":
                    operand1 = (float)Math.Log(operand1, operand2);
                    textBox.Text = operand1.ToString();
                    break;
            }
        }
        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            if (!par_mode)
            {
                label.Text = operand1.ToString() + operation + operand2.ToString() + "=";
                Calculate();
                press_equal = true;
            }
            else
            {
                par_mode = false;
                label.Text = textBox.Text + "=";
                var result = new System.Data.DataTable().Compute(textBox.Text, "");
                textBox.Text = result.ToString();
            }
        }
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            operand2 = 0;
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            label.Text = "";
            operand1 = operand2 = 0;
        }
        private void ButtonBS_Click(object sender, EventArgs e)
        {
            int index = textBox.Text.Length;
            index --;
            textBox.Text = textBox.Text.Remove(index);
            if (textBox.Text == "")
                textBox.Text = "0";
            if (!par_mode)
                operand2 = float.Parse(textBox.Text);
        }
        private void ButtonPM_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                operand2 = float.Parse(textBox.Text) * (-1);
                textBox.Text = operand2.ToString();
            }
        }
        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            operand2 = float.Parse(textBox.Text) / 100;
            textBox.Text = operand2.ToString();
        }
        private void ButtonInverse_Click(object sender, EventArgs e)
        {
            operand2 = 1 / float.Parse(textBox.Text);
            textBox.Text = operand2.ToString();
        }
        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            operand2 = float.Parse(textBox.Text) * float.Parse(textBox.Text);
            textBox.Text = operand2.ToString();
        }
        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            operand2 = (float)Math.Sqrt(float.Parse(textBox.Text));
            textBox.Text = operand2.ToString();
        }
        private void StandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 415;
            textBox.Width = 378;
        }
        private void ScientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 805;
            textBox.Width = 762;
        }
        private void ButtonPi_Click(object sender, EventArgs e)
        {
            operand2 = (float)Math.PI;
            textBox.Text = operand2.ToString();
        }
        private void ButtonE_Click(object sender, EventArgs e)
        {
            operand2 = (float)Math.E;
            textBox.Text=operand2.ToString(); 
        }
        private void ButtonAbs_Click(object sender, EventArgs e)
        {
            operand2 = (float)Math.Abs(float.Parse(textBox.Text));
            textBox.Text = operand2.ToString();
        }
        private void ButtonFact_Click(object sender, EventArgs e)
        {
            long f = 1;
            for (int i = 1; i <= operand2; i++)
                f *= i;
            operand2 = f;
            textBox.Text = f.ToString();
        }
        private void ButtonExp_Click(object sender, EventArgs e)
        {
            textBox.Text += ",e+";
        }
        private void RadiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trigon != "rad")
                radiansToolStripMenuItem.Text += " •";
            degreesToolStripMenuItem.Text = "Degrees";
            trigon = "rad";
        }
        private void DegreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trigon != "deg")
                degreesToolStripMenuItem.Text += " •";
            radiansToolStripMenuItem.Text = "Radians";         
            trigon = "deg";
        }
        private void ButtonSin_Click(object sender, EventArgs e)
        {
            label.Text = "sin(" + textBox.Text + ")";
            operand2 = float.Parse(textBox.Text);
            if (trigon == "rad")
                operand2 = (float)Math.Sin(operand2);
            else
                operand2 = (float)Math.Sin(operand2 * Math.PI / (float)180);
            textBox.Text = operand2.ToString();
        }
        private void ButtonSinh_Click(object sender, EventArgs e)
        {
            label.Text = "sinh(" + textBox.Text + ")";
            operand2 = float.Parse(textBox.Text);
            operand2 = (float)Math.Sinh(operand2);
            textBox.Text = operand2.ToString();
        }
        private void ButtonCos_Click(object sender, EventArgs e)
        {
            label.Text = "cos(" + textBox.Text + ")";
            operand2 = float.Parse(textBox.Text);
            if (trigon == "rad")
                operand2 = (float)Math.Cos(operand2);
            else
                operand2 = (float)Math.Cos(operand2 * Math.PI / 180);
            textBox.Text = operand2.ToString();
        }
        private void ButtonCosh_Click(object sender, EventArgs e)
        {
            label.Text = "cosh(" + textBox.Text + ")";
            operand2 = float.Parse(textBox.Text);
            operand2 = (float)Math.Cosh(operand2);
            textBox.Text = operand2.ToString();
        }
        private void ButtonAsin_Click(object sender, EventArgs e)
        {
            label.Text = "arcsin(" + textBox.Text + ")";
            operand2 = float.Parse(textBox.Text);
            if (trigon == "rad")
                operand2 = (float)Math.Asin(operand2);
            else
                operand2 = 180 * (float)Math.Asin(operand2) / (float)Math.PI;
            textBox.Text = operand2.ToString();
        }
        private void ButtonAcos_Click(object sender, EventArgs e)
        {
            label.Text = "arccos(" + textBox.Text + ")";
            operand2 = float.Parse(textBox.Text);
            if (trigon == "rad")
                operand2 = (float)Math.Acos(operand2);
            else
                operand2 = 180 * (float)Math.Acos(operand2) / (float)Math.PI;
            textBox.Text = operand2.ToString();
        }
        private void ButtonTan_Click(object sender, EventArgs e)
        {
            label.Text = "tan(" + textBox.Text + ")";
            operand2 = float.Parse(textBox.Text);
            if (trigon == "rad")
                operand2 = (float)Math.Tan(operand2);
            else
                operand2 = (float)Math.Tan(operand2 * Math.PI / 180);
            textBox.Text = operand2.ToString();
        }
        private void ButtonCot_Click(object sender, EventArgs e)
        {
            label.Text = "cot(" + textBox.Text + ")";
            operand2 = float.Parse(textBox.Text);
            if (trigon == "rad")
                operand2 = 1 / (float)Math.Tan(operand2);
            else
                operand2 = 1 / (float)Math.Tan(operand2 * Math.PI / 180);
            textBox.Text = operand2.ToString();
        }
        private void ButtonAtan_Click(object sender, EventArgs e)
        {
            label.Text = "arctan(" + textBox.Text + ")";
            operand2 = float.Parse(textBox.Text);
            if (trigon == "rad")
                operand2 = (float)Math.Atan(operand2);
            else
                operand2 = 180 * (float)Math.Atan(operand2) / (float)Math.PI;
            textBox.Text = operand2.ToString();
        }
        private void Button2Powx_Click(object sender, EventArgs e)
        {
            operand2 = (float)Math.Pow(2, operand2);
            textBox.Text = operand2.ToString();
        }
        private void ButtonePowx_Click(object sender, EventArgs e)
        {
            operand2 = (float)Math.Pow(Math.E, operand2);
            textBox.Text = operand2.ToString();
        }
        private void ButtonLg_Click(object sender, EventArgs e)
        {
            operand2 = (float)Math.Log10(operand2);
            textBox.Text = operand2.ToString();
        }
        private void ButtonLn_Click(object sender, EventArgs e)
        {
            operand2 = (float)Math.Log(operand2);
            textBox.Text = operand2.ToString();
        }
        private void ButtonP1_Click(object sender, EventArgs e)
        {
            if (!par_mode)
            {
                textBox.Text = label.Text;
                label.Text = "";
            }
            par_mode = true;
            textBox.Text += "(";
        }
        private void ButtonP2_Click(object sender, EventArgs e)
        {
            textBox.Text += ")";
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar==',') && !par_mode)
            {
                if (textBox.Text == "0" || enter_value)
                    textBox.Clear();
                enter_value = false;
                if (e.KeyChar == ',')
                {
                    if (!textBox.Text.Contains(","))
                    {
                        if (textBox.Text == "")
                            textBox.Text = "0,";
                        else
                            textBox.Text += e.KeyChar;
                    }
                }
                else
                {
                    textBox.Text += e.KeyChar;
                    operand2 = float.Parse(textBox.Text);
                }
            }
            if("+-*/%".Contains(e.KeyChar) && !par_mode)
            {
                if (label.Text == "")
                    operand1 = float.Parse(textBox.Text); 
                if (press_equal)
                {
                    operand2 = operand1;
                    operand1 = float.Parse(textBox.Text);
                    press_equal = false;
                }
                else
                    Calculate();
                operation = e.KeyChar.ToString();
                if (operation == "Mod")
                    operation = "%";
                label.Text = operand1.ToString() + operation;
                enter_value = true;
            }
            if (e.KeyChar=='=' || e.KeyChar==13)
            {
                ButtonEquals_Click(sender, e);
            } 
            if (e.KeyChar == 8)
            {
                ButtonBS_Click(sender, e);
            }
            if (e.KeyChar == 127)
            {
                ButtonCE_Click(sender, e);
            }
            if (e.KeyChar == '(')
            {
                ButtonP1_Click(sender, e);
            }
            if (par_mode)
            {
                if (e.KeyChar == ')')
                    textBox.Text += ")";
                if (e.KeyChar >= '0' && e.KeyChar <= '9')
                    textBox.Text += e.KeyChar;
                if (e.KeyChar == ',')
                    textBox.Text += ".";
                if ("+-*/%".Contains(e.KeyChar))
                    textBox.Text += e.KeyChar;
            }
        }
        private void complexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}