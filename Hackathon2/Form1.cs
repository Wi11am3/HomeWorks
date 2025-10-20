namespace Hackathon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (double.TryParse(textBox1.Text, out double value))

                {
                    double fahrenheit = value * 9 / 5 + 32;
                    label1.Text = $"���G : {textBox1.Text} �XC = {fahrenheit:F2} �XF";
                }
                else
                {
                    label1.Text = "�п�J���ļƦr";
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (double.TryParse(textBox1.Text, out double value))
                {
                    double celsius = (value - 32) * 5 / 9;
                    label1.Text = $"���G : {textBox1.Text} �XF = {celsius:F2} C";
                }
                else
                {
                    label1.Text = "�п�J���ļƦr";
                }
            }
            else
            {
                label1.Text = "�п�ܧA�Q�n�ഫ���ū׳��";
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Tag.ToString();
        }
    }
}
