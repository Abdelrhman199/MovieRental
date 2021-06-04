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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public static string x0 = "";

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;


            if (checkBox1.Checked == true)
            {
                CommandObj.CommandText = "insert into NEW_USER Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + "Admin" + "')" +
                    "insert into NEWADMIN VALUES('" + textBox1.Text + "')";
                x0 = textBox1.Text;
               // MessageBox.Show(x0);
                

                    CommandObj.ExecuteNonQuery();
                    ConnectionObj.Close();
                    MessageBox.Show("Registering Completed");
                    frm.Show();
                    this.Hide();
               
            }
            else if (checkBox2.Checked == true)
            {
                x0 = textBox1.Text;
                CommandObj.CommandText = "insert into NEW_USER Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + "Customer" + "')" +
                    "insert into CUSTOMER VALUES('" + textBox1.Text + "')";
                CommandObj.ExecuteNonQuery();
                ConnectionObj.Close();
                MessageBox.Show("Registering Completed");

                frm.Show();
                this.Hide();
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
