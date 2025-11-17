using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO___FarMoo.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = tbUsername.Text;
            string pass = tbPassword.Text;

            string koneksi = @"Data Source=.\SQLEXPRESS;Initial Catalog=db_login;Integrated Security=True";
            SqlConnection con = new SqlConnection(koneksi);

            try
            {
                con.Open();
                string query = "SELECT * FROM users WHERE username=@user AND password=@pass";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login Berhasil!");
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
