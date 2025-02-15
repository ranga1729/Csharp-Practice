namespace Calculator_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn7.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn6.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn3.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + btn0.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(display.Text);
            display.Clear();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(display.Text);
            display.Clear();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            option = "x";
            num1 = int.Parse(display.Text);
            display.Clear();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(display.Text);
            display.Clear();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(display.Text);

            switch (option)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "x":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            display.Text = Convert.ToString(result);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            display.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }
    }
}
