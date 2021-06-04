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
    public partial class rentMovie : Form
    {
        public rentMovie()
        {
            InitializeComponent();
        }
        public static string CustomerUsername = "";
        public static string Test = "";

        private void rentMovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRentalDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.movieRentalDataSet1.DataTable1);
            CustomerUsername = Form2.USERNAME;
           // MessageBox.Show(CustomerUsername);


        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            DateTime start_date = DateTime.Now;
            DateTime return_date = start_date.AddDays(Convert.ToDouble(textBox2.Text));
            Test = "End Game";

            CommandObj.CommandText = "select [MOVIE_PRICE] from MOVIE where MOVIE_ID='" + textBox1.Text + "'";
            if (CommandObj.ExecuteScalar() == null)
            {
                MessageBox.Show("The Movie ID Not Found");
            }
            else
            {

                MessageBox.Show(Test);
                CommandObj.CommandText = "insert into RENT Values('" + textBox1.Text + "','" + CustomerUsername + "','" + start_date + "','" + return_date + "','" + Test + "','" + textBox2.Text + "')";
                CommandObj.ExecuteNonQuery();
                ConnectionObj.Close();
                MessageBox.Show("Renting Completed");
                    
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Renting frm = new Renting();
            frm.Show();
            this.Hide();
        }
    }
}
