namespace counterapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(label1.Text)+ 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(label1.Text) - 1).ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}