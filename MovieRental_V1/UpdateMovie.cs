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
    public partial class UpdateMovie : Form
    {
        public UpdateMovie()
        {
            InitializeComponent();
        }

        private void UpdateMovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRentalDataSet.MOVIE' table. You can move, or remove it, as needed.
            this.mOVIETableAdapter.Fill(this.movieRentalDataSet.MOVIE);

        }
        public static string id = "";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            CommandObj.CommandText = "select MOVIE_ID from MOVIE where MOVIE_ID='" + textBox1.Text + "'";
            if (CommandObj.ExecuteScalar() != null)
            {
                if (comboBox1.SelectedIndex > -1)
                {


                    if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Movie Name")
                    {
                        CommandObj.CommandText = "Update MOVIE set Movie_NAME=('" + textBox2.Text + "') where MOVIE_ID=('" + textBox1.Text + "')";

                        CommandObj.ExecuteNonQuery();

                        ConnectionObj.Close();
                        MessageBox.Show("Updated Successfuly");

                    }
                    else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Rate")
                    {
                        CommandObj.CommandText = "Update MOVIE set RATE=('" + textBox2.Text + "') where MOVIE_ID=('" + textBox1.Text + "')";
                        CommandObj.ExecuteNonQuery();

                        ConnectionObj.Close();
                        MessageBox.Show("Updated Successfuly");
                    }
                    else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Release Year")
                    {
                        CommandObj.CommandText = "Update MOVIE set RELEASE_YEAR=('" + textBox2.Text + "') where MOVIE_ID=('" + textBox1.Text + "')";


                        CommandObj.ExecuteNonQuery();

                        ConnectionObj.Close();
                        MessageBox.Show("Updated Successfuly");

                    }
                    else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Duration")
                    {


                        CommandObj.CommandText = "Update MOVIE set DURATION=('" + textBox2.Text + "') where MOVIE_ID=('" + textBox1.Text + "')";


                        CommandObj.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfuly");



                    }
                    else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Video Quality")
                    {
                        CommandObj.CommandText = "Update MOVIE set VIDEO_QUALITY=('" + textBox2.Text + "') where MOVIE_ID=('" + textBox1.Text + "')";
                        CommandObj.ExecuteNonQuery();

                        ConnectionObj.Close();
                        MessageBox.Show("Updated Successfuly");
                    }
                    else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Number of Versions")
                    {
                        CommandObj.CommandText = "Update MOVIE set NO_VERSIONS=('" + textBox2.Text + "') where MOVIE_ID=('" + textBox1.Text + "')";
                        CommandObj.ExecuteNonQuery();

                        ConnectionObj.Close();
                        MessageBox.Show("Updated Successfuly");
                    }
                    else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Rent Price")
                    {
                        CommandObj.CommandText = "Update MOVIE set MOVIE_PRICE=('" + textBox2.Text + "') where MOVIE_ID=('" + textBox1.Text + "')";
                        CommandObj.ExecuteNonQuery();

                        ConnectionObj.Close();
                        MessageBox.Show("Updated Successfuly");
                    }
                }
            }
                 else
            {
                MessageBox.Show("Movie ID is Incorrect");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Hide();
        }
    }
}
