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
    public partial class AdminRentingMovie : Form
    {
        public AdminRentingMovie()
        {
            InitializeComponent();
        }
        public static string AdminUsername = "";
        public static string Test = "";
        private void AdminRentingMovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRentalDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.movieRentalDataSet1.DataTable1);
            AdminUsername = Form2.USERNAME;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            DateTime start_date = DateTime.Now;
            DateTime return_date = start_date.AddDays(Convert.ToDouble(textBox2.Text));
            
            CommandObj.CommandText = "select [MOVIE_PRICE] from MOVIE where MOVIE_ID='" + textBox1.Text + "'";
            Test = CommandObj.ExecuteScalar().ToString();

            MessageBox.Show(Test);
            CommandObj.CommandText = "insert into RENT Values('" + textBox1.Text + "','" + AdminUsername + "','" + start_date + "','" + return_date + "','" + Test + "','" + textBox2.Text + "')";
            CommandObj.ExecuteNonQuery();
            ConnectionObj.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminRenting frm = new AdminRenting();
            frm.Show();
            this.Hide();
        }
    }
}
