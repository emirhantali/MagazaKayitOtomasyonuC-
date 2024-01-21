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

namespace GiyimMağazası
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=MağazaKayit;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifreyi al
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            // Veritabanında kontrol işlemi
            if (CheckUserCredentials(userName, password))
            {
                // Giriş başarılı ise Form2'yi aç
                Form2 form2 = new Form2();
                this.Visible = false;
                form2.Visible = true;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.");
            }
        }

        private bool CheckUserCredentials(string userName, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Name = @UserName AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Eğer veritabanında eşleşen bir kayıt varsa, giriş başarılı kabul edilir.
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
