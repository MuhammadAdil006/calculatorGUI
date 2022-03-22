namespace Calculator
{
   

    public partial class Form1 : Form
    {
        private decimal firstN;
        private decimal secondN;
        private decimal Ans;
        private bool gotcha;
        private char Operation;
        public Form1()
        {
            gotcha = false;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text == "0" && DisplayTerminal.Text.Length == 1)
            {
                DisplayTerminal.Text = "1";//simply erase the zero
            }
            else if (gotcha)
            {
                gotcha = false;
                DisplayTerminal.Text = "1";
            }
            else
            {
                DisplayTerminal.Text += "1";
            }
           
        }


        private void button31_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text == "0" && DisplayTerminal.Text.Length == 1)
            {
                DisplayTerminal.Text = "2";//simply erase the zero
            }
            else if (gotcha)
            {
                gotcha = false;
                DisplayTerminal.Text = "2";
            }
            else
            {
                DisplayTerminal.Text += "2";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text == "0" && DisplayTerminal.Text.Length == 1)
            {
                DisplayTerminal.Text = "3";//simply erase the zero
            }
            else if (gotcha)
            {
                gotcha = false;
                DisplayTerminal.Text = "3";
            }
            else
            {
                DisplayTerminal.Text += "3";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text == "0" && DisplayTerminal.Text.Length == 1)
            {
                DisplayTerminal.Text = "4";//simply erase the zero
            }
            else if (gotcha)
            {
                gotcha = false;
                DisplayTerminal.Text = "4";
            }
            else
            {
                DisplayTerminal.Text += "4";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text == "0" && DisplayTerminal.Text.Length == 1)
            {
                DisplayTerminal.Text = "5";//simply erase the zero
            }
            else if (gotcha)
            {
                gotcha = false;
                DisplayTerminal.Text = "5";
            }
            else
            {
                DisplayTerminal.Text += "5";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text == "0" && DisplayTerminal.Text.Length == 1)
            {
                DisplayTerminal.Text = "6";//simply erase the zero
            }
            else if (gotcha)
            {
                gotcha = false;
                DisplayTerminal.Text = "6";
            }
            else
            {
                DisplayTerminal.Text += "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text == "0" && DisplayTerminal.Text.Length == 1)
            {
                DisplayTerminal.Text = "7";//simply erase the zero
            }
            else if (gotcha)
            {
                gotcha = false;
                DisplayTerminal.Text = "7";
            }
            else
            {
                DisplayTerminal.Text += "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text == "0" && DisplayTerminal.Text.Length == 1)
            {
                DisplayTerminal.Text = "8";//simply erase the zero
            }
            else if (gotcha)
            {
                gotcha = false;
                DisplayTerminal.Text = "8";
            }
            else
            {
                DisplayTerminal.Text += "8";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text == "0" && DisplayTerminal.Text.Length == 1)
            {
                DisplayTerminal.Text = "9";//simply erase the zero
            }
            else if (gotcha)
            {
                gotcha = false;
                DisplayTerminal.Text = "9";
            }
            else
            {
                DisplayTerminal.Text += "9";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text == "0" && DisplayTerminal.Text.Length == 1)
            {
                DisplayTerminal.Text = "0";//simply erase the zero
            }else if(gotcha)
            {
                gotcha = false;
                DisplayTerminal.Text = "0";
            }
            else
            {
                DisplayTerminal.Text += "0";
            }
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(DisplayTerminal.Text.Length==1 && DisplayTerminal.Text=="0")
            {
                firstN = 0;
            }else if(DisplayTerminal.Text.Length>=1)
            {
                firstN=Convert.ToDecimal(DisplayTerminal.Text);
                //DisplayTerminal.Text = "";
                gotcha = true;
            }
            Operation = '+';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text.Length == 1 && DisplayTerminal.Text == "0")
            {
                firstN = 0;
            }
            else if (DisplayTerminal.Text.Length >= 1)
            {
                firstN = Convert.ToDecimal(DisplayTerminal.Text);
                //DisplayTerminal.Text = "";
                gotcha = true;
            }
            Operation = '-';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text.Length == 1 && DisplayTerminal.Text == "0")
            {
                firstN = 0;
            }
            else if (DisplayTerminal.Text.Length >= 1)
            {
                firstN = Convert.ToDecimal(DisplayTerminal.Text);
                //DisplayTerminal.Text = "";
                gotcha = true;
            }
            Operation = '*';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (DisplayTerminal.Text.Length == 1 && DisplayTerminal.Text == "0")
            {
                firstN = 0;
            }
            else if (DisplayTerminal.Text.Length >= 1)
            {
                firstN = Convert.ToDecimal(DisplayTerminal.Text);
                //DisplayTerminal.Text = "";
                gotcha = true;
            }
            Operation = '/';
        }

        private void button20_Click(object sender, EventArgs e)
        {
            secondN = Convert.ToDecimal(DisplayTerminal.Text);
            if(Operation=='+')
            {
                Ans = firstN + secondN;
            }else if(Operation=='-')
            {
                Ans = firstN  - secondN;
            }else if(Operation=='*')
            {
                Ans = firstN * secondN;
            }else if(Operation=='/')
            {
                Ans = firstN / secondN;
            }
            Operation = ' ';
            firstN = Ans;
            DisplayTerminal.Text = Convert.ToString(Ans);
            secondN = 0;

        }
    }
}