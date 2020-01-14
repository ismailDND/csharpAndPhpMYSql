using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp5
{



    public partial class Form1 : Form
    {

        MySqlConnection db = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=12345678;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            db.Open();
            MySqlCommand com = new MySqlCommand("SELECT * from uye where email=@email and sifre=@sifre", db);
            com.Parameters.AddWithValue("@email", email.Text);
            com.Parameters.AddWithValue("@sifre", sifre.Text);

            MySqlDataReader rok = com.ExecuteReader();

            if (rok.Read())
            {

                MessageBox.Show("Hoş Geldin =" + rok[1].ToString());



            }
            else
            {

                MessageBox.Show("Giriş Başarısız!");


            }


            db.Close();


        }
    }
}
