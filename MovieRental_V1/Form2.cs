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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       /// public static string Customer="";
        public static string USERNAME = "";


        private void Form2_Load(object sender, EventArgs e)
        {
                     
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            if(checkBox2.Checked==true)
            {
               
                CommandObj.CommandText = "select* from NEW_USER where (USERNAME='" + textBox1.Text + "'And USERPAss='" + textBox2.Text + "'And USER_ROLE='Customer')";
                
                int User_Exist;

                if (CommandObj.ExecuteScalar() != null)
                {
                    User_Exist = 1;
                    CommandObj.ExecuteNonQuery();
                }
                else
                { User_Exist = -1; }


                if (User_Exist > 0)
                {
                    USERNAME = textBox1.Text;
                    UserForm form3 = new UserForm();
                    form3.Show();
                    this.Hide();
                    ConnectionObj.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username Or Password");
                }

            }
            else if(checkBox1.Checked==true)
            {
                CommandObj.CommandText = "select* from NEW_USER where (USERNAME='" + textBox1.Text + "'And USERPAss='" + textBox2.Text + "'AND USER_ROLE='Admin')";
               
                int User_Exist;
                

                if (CommandObj.ExecuteScalar() != null)
                {
                    User_Exist = 1;
                    CommandObj.ExecuteNonQuery();
                }
                else
                { User_Exist = -1; }


                if (User_Exist > 0)
                {
                    USERNAME = textBox1.Text;
                   
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                    ConnectionObj.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Username Or Password");
                }
            }
           
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
