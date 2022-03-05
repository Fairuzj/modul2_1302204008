namespace modul2_1302204008
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string input1 = string.Empty ;
        string input2 = string.Empty ;
        char operasi;
        int hitung = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            input1 = input ;
            operasi = '+';
            input = string.Empty ;  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.hasil.Text = "";
            input += "1";
            this.hasil.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.hasil.Text = "";
            input += "2";
            this.hasil.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.hasil.Text = "";
            input += "3";
            this.hasil.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.hasil.Text = "";
            input += "0";
            this.hasil.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.hasil.Text = "";
            input += "4";
            this.hasil.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.hasil.Text = "";
            input += "5";
            this.hasil.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.hasil.Text = "";
            input += "6";
            this.hasil.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.hasil.Text = "";
            input += "7";
            this.hasil.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.hasil.Text = "";
            input += "8";
            this.hasil.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.hasil.Text = "";
            input += "9";
            this.hasil.Text += input;
        }
        private void btnHasil_Click(object sender, EventArgs e)
        {
            input2 = input;
            int angka1, angka2;
            int.TryParse(input1, out angka1);
            int.TryParse(input2, out angka2);

            hitung = angka1 + angka2;
            hasil.Text = hitung.ToString();
        }

    }
}