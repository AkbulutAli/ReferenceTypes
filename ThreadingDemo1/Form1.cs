namespace ThreadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i�lem 1 �al��t�");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("i�lem 2 �al��t�");
        }
    }
}