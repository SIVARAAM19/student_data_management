namespace studentmanagement_PT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student studentinfo = new student();

            studentinfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentinfo studentinfo = new studentinfo();

            studentinfo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}