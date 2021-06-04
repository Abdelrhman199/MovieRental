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
    public partial class AddGenreAndActor : Form
    {
        public AddGenreAndActor()
        {
            InitializeComponent();
        }
        public static string movieID = "";

        private void AddGenreAndActor_Load(object sender, EventArgs e)
        {
            movieID = AddMovie.selectData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMovie frm = new AddMovie();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            CommandObj.CommandText = "insert  into GENER Values('" + movieID + "','" + textBox1.Text + "')";
            CommandObj.ExecuteNonQuery();


            ConnectionObj.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            CommandObj.CommandText = "insert  into MAINACTORS Values('" + movieID + "','" + textBox2.Text + "')";
            CommandObj.ExecuteNonQuery();
            ConnectionObj.Close();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
