using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentmanagement_PT
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=studentdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        private void Student_Load(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            SqlCommand cnn = new SqlCommand("Select * from empttab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into empttab(id,studentname,course,dob,section,gender,age) values(@id,@studentname,@course,@dob,@section,@gender,@age)", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@studentname", (textBox2.Text));

            cnn.Parameters.AddWithValue("@course", (textBox3.Text));

            cnn.Parameters.AddWithValue("@dob", DateTime.Parse(textBox6.Text));

            cnn.Parameters.AddWithValue("@section", (textBox5.Text));

            cnn.Parameters.AddWithValue("@gender", (textBox4.Text));

            cnn.Parameters.AddWithValue("@age", int.Parse(textBox7.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=studentdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete empttab where id=@id",con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("selected id data has been deleted");

        }
    }
}