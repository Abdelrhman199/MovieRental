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
    public partial class BrowsMoviesV2 : Form
    {
        public BrowsMoviesV2()
        {
            InitializeComponent();
        }

        private void BrowsMoviesV2_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Gener")
            {
                this.dataTable1BindingSource.Filter = "[MOVIE_GERE]='" + textBox1.Text + "'";
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Actor")
            {
                this.dataTable1BindingSource.Filter = "[MAIN_ACTORS]='" + textBox1.Text + "'";
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Year")
            {
                this.dataTable1BindingSource.Filter = "[RELEASE_YEAR]='" + textBox1.Text + "'";
            }
            this.dataTable1TableAdapter.Fill(this.movieRentalDataSet1.DataTable1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm frm = new AdminForm();
            frm.Show();
            this.Hide();
        }
    }
}
