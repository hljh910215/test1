namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = waTextBox1.GetValue();
            string b = waCheckBox1.GetValue();
        }

        private void waCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
