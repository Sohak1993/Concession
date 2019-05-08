using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet_MMehdy_LOGary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=Sohak-PC\SQLEXPRESS;Initial Catalog=BDDprojet;Integrated Security=True;Pooling=False");
            SqlDataAdapter login = new SqlDataAdapter("Select Count (*) From [Table] Where USER ='"+textBox1.Text+"'AND PASSWORD='"+textBox2.Text+"'", con);
            DataTable dt = new DataTable();
            login.Fill(dt);
            MessageBox.Show(dt.Rows[0][1].ToString());
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Vous êtes connecté");
            }
            else
            {
                MessageBox.Show("Utilisez un compte administrateur");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
