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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRentalDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.movieRentalDataSet1.DataTable1);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BrowseMovies browse = new BrowseMovies();
            browse.Show();
            this.Hide();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserProfile user = new UserProfile();
            user.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Renting frm = new Renting();
            frm.Show();
            this.Hide();
        }
    }
}
