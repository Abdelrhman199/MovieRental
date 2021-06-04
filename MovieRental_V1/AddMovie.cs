using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
   
namespace MovieRental_V1
{
   

    public partial class AddMovie : Form
    {


        public static string selectData = "";
        public AddMovie()
        {
            InitializeComponent();
        }
        public static string x3="";

        private void AddMovie_Load(object sender, EventArgs e)
        {
            x3 = Form2.USERNAME;
        }
        public AdminForm getText=new AdminForm();
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            CommandObj.CommandText = "insert into MOVIE Values('"+textBox9.Text+"','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "', '" +x3+"')";
            selectData = textBox9.Text;
            CommandObj.ExecuteNonQuery();
           
            ConnectionObj.Close();
            AddGenreAndActor add = new AddGenreAndActor();
            add.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminForm admin = new AdminForm();
            admin.Show();
            this.Hide();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
