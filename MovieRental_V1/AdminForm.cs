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
    public partial class AdminForm : Form
    {
       
        public AdminForm()
        {
            InitializeComponent();
        }
        
        public static string x2="";


        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRentalDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.movieRentalDataSet1.DataTable1);

            x2 = Form2.USERNAME;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddMovie addmovie = new AddMovie();
            MessageBox.Show(x2); 
            addmovie.Show();
           
            this.Hide();
        }

       

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateMovie update = new UpdateMovie();
            update.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserProfile user = new UserProfile();
            user.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BrowsMoviesV2 browse = new BrowsMoviesV2();
            browse.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminRenting frm = new AdminRenting();
            frm.Show();
            this.Hide();
        }
    }
}
