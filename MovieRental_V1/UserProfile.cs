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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }
        public static string username = "";


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            if (comboBox1.SelectedIndex > -1)
            {
                if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Email")
                {
                    CommandObj.CommandText = "Update NEW_USER set EMAIL=('" + textBox1.Text + "') where USERNAME=('" + username + "')";
                    CommandObj.ExecuteNonQuery();

                    ConnectionObj.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Password")
                {
                    CommandObj.CommandText = "Update NEW_USER set USERPAss=('" + textBox1.Text + "') where USERNAME=('" + username + "')";
                    CommandObj.ExecuteNonQuery();

                    ConnectionObj.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Age")
                {
                    CommandObj.CommandText = "Update NEW_USER set AGE=('" + textBox1.Text + "') where USERNAME=('" + username + "')";
                    CommandObj.ExecuteNonQuery();

                    ConnectionObj.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "First Name")
                {
                    CommandObj.CommandText = "Update NEW_USER set Fname=('" + textBox1.Text + "') where USERNAME=('" + username + "')";
                    CommandObj.ExecuteNonQuery();

                    ConnectionObj.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Last Name")
                {
                    CommandObj.CommandText = "Update NEW_USER set Lname=('" + textBox1.Text + "') where USERNAME=('" + username + "')";
                    CommandObj.ExecuteNonQuery();

                    ConnectionObj.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Phone")
                {
                    CommandObj.CommandText = "Update NEW_USER set PHONE=('" + textBox1.Text + "') where USERNAME=('" + username + "')";
                    CommandObj.ExecuteNonQuery();

                    ConnectionObj.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "St_Address")
                {
                    CommandObj.CommandText = "Update NEW_USER set ST_ADDRESS=('" + textBox1.Text + "') where USERNAME=('" + username + "')";
                    CommandObj.ExecuteNonQuery();

                    ConnectionObj.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "City")
                {
                    CommandObj.CommandText = "Update NEW_USER set CITY=('" + textBox1.Text + "') where USERNAME=('" + username + "')";
                    CommandObj.ExecuteNonQuery();

                    ConnectionObj.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "ZipCode")
                {
                    CommandObj.CommandText = "Update NEW_USER set ZIPCODE=('" + textBox1.Text + "') where USERNAME=('" + username + "')";
                    CommandObj.ExecuteNonQuery();

                    ConnectionObj.Close();
                }
                else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Country")
                {
                    CommandObj.CommandText = "Update NEW_USER set COUNTRY=('" + textBox1.Text + "') where USERNAME=('" + username + "')";
                    CommandObj.ExecuteNonQuery();

                    ConnectionObj.Close();
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            username = Form2.USERNAME;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            frm.Show();
            this.Hide();
        }
    }
}
