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
    public partial class Renting : Form
    {
        public Renting()
        {
            InitializeComponent();
        }

        public static string CustomerRent = "";
        private void Renting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieRentalDataSet1.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.movieRentalDataSet1.DataTable2);
            CustomerRent = Form2.USERNAME;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rentMovie frm = new rentMovie();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExtendRent frm = new ExtendRent();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReturnMovie frm = new ReturnMovie();
            frm.Show();
            this.Hide();
        }
    }
}
