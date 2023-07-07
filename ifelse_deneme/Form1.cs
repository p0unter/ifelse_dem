namespace ifelse_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sayi = Convert.ToString(textBox1.Text);

            if (sayi == "Naber")
            {
                label1.Text = "Ýyi";
            }
            else
            {
                label1.Text = "Bi hal hatýr sor bakim!(Naber)";
            }
        }
    }
}