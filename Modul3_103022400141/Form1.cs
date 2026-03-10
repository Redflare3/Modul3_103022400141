namespace Modul3_103022400141
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu.");
                return;
            }
            else if (!double.TryParse(textBox1.Text, out double nilai))
            {
                MessageBox.Show("Masukkan nilai yang valid.");
                return;
            }
            else
            {
                if (comboBox1.SelectedItem.ToString() == "Celsius" && comboBox2.SelectedItem.ToString() == "Fahrenheit")
                {
                    double celsius = double.Parse(textBox1.Text);
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    textBox2.Text = fahrenheit.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Fahrenheit" && comboBox2.SelectedItem.ToString() == "Celsius")
                {
                    double fahrenheit = double.Parse(textBox1.Text);
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    textBox2.Text = celsius.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Celsius" && comboBox2.SelectedItem.ToString() == "Kelvin")
                {
                    double celsius = double.Parse(textBox1.Text);
                    double kelvin = celsius + 273;
                    textBox2.Text = kelvin.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Kelvin" && comboBox2.SelectedItem.ToString() == "Celsius")
                {
                    double kelvin = double.Parse(textBox1.Text);
                    double celsius = kelvin - 273;
                    textBox2.Text = celsius.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Fahrenheit" && comboBox2.SelectedItem.ToString() == "Kelvin")
                {
                    double fahrenheit = double.Parse(textBox1.Text);
                    double kelvin = (fahrenheit - 32) * 5 / 9 + 273;
                    textBox2.Text = kelvin.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Kelvin" && comboBox2.SelectedItem.ToString() == "Fahrenheit")
                {
                    double kelvin = double.Parse(textBox1.Text);
                    double fahrenheit = (kelvin - 273) * 9 / 5 + 32;
                    textBox2.Text = fahrenheit.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Reamur" && comboBox2.SelectedItem.ToString() == "Fahrenheit")
                {
                    double reamur = double.Parse(textBox1.Text);
                    double fahrenheit = (reamur * 9 / 4) + 32;
                    textBox2.Text = fahrenheit.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Fahrenheit" && comboBox2.SelectedItem.ToString() == "Reamur")
                {
                    double fahrenheit = double.Parse(textBox1.Text);
                    double reamur = (fahrenheit - 32) * 4 / 9;
                    textBox2.Text = reamur.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Reamur" && comboBox2.SelectedItem.ToString() == "Celsius")
                {
                    double reamur = double.Parse(textBox1.Text);
                    double celsius = reamur * 5 / 4;
                    textBox2.Text = celsius.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Celsius" && comboBox2.SelectedItem.ToString() == "Reamur")
                {
                    double celsius = double.Parse(textBox1.Text);
                    double reamur = celsius * 4 / 5;
                    textBox2.Text = reamur.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Reamur" && comboBox2.SelectedItem.ToString() == "Kelvin")
                {
                    double reamur = double.Parse(textBox1.Text);
                    double kelvin = (reamur * 5 / 4) + 273;
                    textBox2.Text = kelvin.ToString();
                }
                else if (comboBox1.SelectedItem.ToString() == "Kelvin" && comboBox2.SelectedItem.ToString() == "Reamur")
                {
                    double kelvin = double.Parse(textBox1.Text);
                    double reamur = (kelvin - 273) * 4 / 5;
                    textBox2.Text = reamur.ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
