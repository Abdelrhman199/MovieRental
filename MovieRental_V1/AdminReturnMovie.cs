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
    public partial class AdminReturnMovie : Form
    {
        public AdminReturnMovie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            CommandObj.CommandText = "Delete from Rent where MOVIE_ID='" + textBox1.Text + "'";
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
