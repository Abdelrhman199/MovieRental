using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental_V1
{
    public partial class BrowseMovies : Form
    {
        public BrowseMovies()
        {
            InitializeComponent();
        }

        private void BrowseMovies_Load(object sender, EventArgs e)
        {
            

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Gener")
            {
                this.dataTable1BindingSource1.Filter = "[MOVIE_GERE]='" + textBox1.Text + "'";
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Actor")
            {
                this.dataTable1BindingSource1.Filter = "[MAIN_ACTORS]='" + textBox1.Text + "'";
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Year")
            {
                this.dataTable1BindingSource1.Filter = "[RELEASE_YEAR]='" + textBox1.Text + "'";
            }
            this.dataTable1TableAdapter.Fill(this.movieRentalDataSet1.DataTable1);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            frm.Show();
            this.Hide();
        }
    }
}
