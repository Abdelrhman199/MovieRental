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
    public partial class ExtendRent : Form
    {
        public ExtendRent()
        {
            InitializeComponent();
        }
        public static string Test = "";
        private void button2_Click(object sender, EventArgs e)
        {
            Renting frm = new Renting();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection ConnectionObj = new SqlConnection("Data Source=DESKTOP-85QS9MQ;Initial Catalog=MovieRental;Integrated Security=True");
            SqlCommand CommandObj = new SqlCommand();
            ConnectionObj.Open();
            CommandObj.Connection = ConnectionObj;
            CommandObj.CommandText = "select RETURN_DATE from RENT where MOVIE_ID='" + textBox1.Text + "'";
            Test = CommandObj.ExecuteScalar().ToString();
            MessageBox.Show(Test);
            DateTime obj = Convert.ToDateTime(Test);
            obj = obj.AddDays(Convert.ToDouble(textBox2.Text));
            CommandObj.CommandText = " update RENT set RETURN_DATE='"+obj+ "',DURATION=DURATION+'" + textBox2.Text + "'where MOVIE_ID='" + textBox1.Text + "'";
            CommandObj.ExecuteNonQuery();
            ConnectionObj.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
