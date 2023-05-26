namespace Calculator
{
    public partial class Form2 : Form
    {
        Complex c1 = new Complex();
        Complex c2 = new Complex();
        public Form2()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <='9')
            {
                if (textBox1.Text != "0")
                    textBox1.Text += e.KeyChar;
                else
                    textBox1.Text = e.KeyChar.ToString();
                c1.setReal(float.Parse(textBox1.Text));
            }
            if (e.KeyChar == ',')
            {
                if (textBox1.Text == "0" || !textBox1.Text.Contains(','))
                    textBox1.Text += ',';
            }
            if (e.KeyChar == '-' && (textBox1.Text == "" || textBox1.Text == "0"))
                textBox1.Text = "-";
            if (e.KeyChar == 8)
            {
                int index = textBox1.Text.Length;
                index--;
                textBox1.Text = textBox1.Text.Remove(index);
                if (textBox1.Text == "")
                    textBox1.Text = "0";
                c1.setReal(float.Parse(textBox1.Text));
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBox3.Text != "0")
                    textBox3.Text += e.KeyChar;
                else
                    textBox3.Text = e.KeyChar.ToString();
                c2.setReal(float.Parse(textBox3.Text));
            }
            if (e.KeyChar == ',')
            {
                if (textBox3.Text == "0" || !textBox3.Text.Contains(','))
                    textBox3.Text += ',';
            }
            if (e.KeyChar == '-' && (textBox3.Text == "" || textBox3.Text == "0"))
                textBox3.Text = "-";
            if (e.KeyChar == 8)
            {
                int index = textBox3.Text.Length;
                index--;
                textBox3.Text = textBox3.Text.Remove(index);
                if (textBox3.Text == "")
                    textBox3.Text = "0";
                c2.setReal(float.Parse(textBox3.Text));
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBox2.Text != "0")
                    textBox2.Text += e.KeyChar;
                else
                    textBox2.Text = e.KeyChar.ToString();
                c1.setImaginary(float.Parse(textBox2.Text));
            }
            if (e.KeyChar == ',')
            {
                if (textBox2.Text == "0" || !textBox2.Text.Contains(','))
                    textBox2.Text += ',';
            }
            if (e.KeyChar == '-' && (textBox2.Text == "" || textBox2.Text == "0"))
                textBox2.Text = "-";
            if (e.KeyChar == 8)
            {
                int index = textBox2.Text.Length;
                index--;
                textBox2.Text = textBox2.Text.Remove(index);
                if (textBox2.Text == "")
                    textBox2.Text = "0";
                c1.setImaginary(float.Parse(textBox2.Text));
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (textBox4.Text != "0")
                    textBox4.Text += e.KeyChar;
                else
                    textBox4.Text = e.KeyChar.ToString();
                c2.setImaginary(float.Parse(textBox4.Text));
            }
            if (e.KeyChar == ',')
            {
                if (textBox4.Text == "0" || !textBox4.Text.Contains(','))
                    textBox4.Text += ',';
            }
            if (e.KeyChar == '-' && (textBox4.Text == "" || textBox4.Text == "0"))
                textBox4.Text = "-";
            if (e.KeyChar == 8)
            {
                int index = textBox4.Text.Length;
                index--;
                textBox4.Text = textBox4.Text.Remove(index);
                if (textBox4.Text == "")
                    textBox4.Text = "0";
                c2.setImaginary(float.Parse(textBox4.Text));
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Complex c3 = new Complex();
            c3 = c1 + c2;
            textBox5.Text = c3.writeComplex();
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Complex c3 = new Complex();
            c3 = c1 - c2;
            textBox5.Text = c3.writeComplex();
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Complex c3 = new Complex();
            c3 = c1 * c2;
            textBox5.Text = c3.writeComplex();
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Complex c3 = new Complex();
            c3 = c1 / c2;
            textBox5.Text = c3.writeComplex();
        }
        private void buttonMod1_Click(object sender, EventArgs e)
        {
            float m;
            m = c1.modulus();
            textBox5.Text = m.ToString();
        }
        private void buttonMod2_Click(object sender, EventArgs e)
        {
            float m;
            m = c2.modulus();
            textBox5.Text = m.ToString();
        }
        private void buttonSwap_Click(object sender, EventArgs e)
        {
            (textBox1.Text, textBox3.Text) = (textBox3.Text, textBox1.Text);
            c1.setReal(float.Parse(textBox1.Text));
            c2.setReal(float.Parse(textBox3.Text));
            (textBox2.Text, textBox4.Text) = (textBox4.Text, textBox2.Text);
            c1.setImaginary(float.Parse(textBox2.Text));
            c2.setImaginary(float.Parse(textBox4.Text));
        }
    }
}
