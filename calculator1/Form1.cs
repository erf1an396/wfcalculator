namespace calculator1
{
    public partial class Form1 : Form
    {

        double num1;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void numbtnclick(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0")
                txtscreen.Text = ((Button)sender).Text;
            else
                txtscreen.Text += ((Button)sender).Text;

            lblscreen.Text += ((Button)sender).Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtscreen.Text);
            num1 = 1 / num1;
            txtscreen.Text = num1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtscreen.Text);
            num1 = Math.Sqrt(num1);
            txtscreen.Text = num1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtscreen.Text);
            num1 = -num1;
            txtscreen.Text = num1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text.Remove(txtscreen.Text.Length - 1);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtscreen.Text);
            op = Convert.ToChar(((Button)sender).Text);
            txtscreen.Text = "0";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double num2;
            num2 = Convert.ToDouble(txtscreen.Text);
            switch (op)
            {
                case '+':
                    num1 = num1 + num2;
                    break;

                case '-':
                    num1 = num1 - num2;
                    break;

                case '*':
                    num1 = num1 * num2;
                    break;

                case '/':
                    num1 = num1 / num2;
                    break;
            }

            txtscreen.Text = num1.ToString();
        }
    }
}
