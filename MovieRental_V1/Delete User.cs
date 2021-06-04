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
    public partial class Delete_User : Form
    {
        public Delete_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            CommandObj.CommandText = "select USERNAME FROM NEW_USER WHERE USERNAME='" + textBox1.Text + "'";
            CommandObj.ExecuteScalar();
            if (CommandObj.ExecuteScalar() != null)
            {
                CommandObj.CommandText = "Delete from NEW_USER where USERNAME='" + textBox1.Text + "'";
                CommandObj.ExecuteNonQuery();
                ConnectionObj.Close();
                MessageBox.Show("Deleted Successfuly");
            }
            else
            {
                MessageBox.Show("No Matching Username");
            }
        }
    }
}
