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
    public partial class AdminRenting : Form
    {
        public AdminRenting()
        {
            InitializeComponent();
        }

        private void AdminRenting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRentalDataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.movieRentalDataSet1.DataTable2);
            // TODO: This line of code loads data into the 'movieRentalDataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.movieRentalDataSet1.DataTable2);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminRentingMovie frm = new AdminRentingMovie();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminExtendingMovie frm = new AdminExtendingMovie();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminReturnMovie frm = new AdminReturnMovie();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm frm = new AdminForm();
            frm.Show();
            this.Hide();
        }
    }
}
