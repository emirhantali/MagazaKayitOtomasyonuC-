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


    public partial class Form4 : Form
    {

        private string connectionString = "Data Source=localhost;Initial Catalog=MağazaKayit;Integrated Security=True;";


        public Form4()
        {
            InitializeComponent();
            this.FormClosing += Form4_FormClosing;
        }

       
        private void UpdateDataGridView()
        {
            try
            {
                // DataSource'ı temizle
                dataGridView1.DataSource = null;

                // Veritabanından verileri çek ve DataGridView'e ekle
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT StokNo, ÜrünAdi, Beden, Renk, StokAdedi FROM Ürünler";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // DataSource'ı güncelle
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }




        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'mağazaKayitDataSet4.Ürünler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünlerTableAdapter1.Fill(this.mağazaKayitDataSet4.Ürünler);
            // TODO: This line of code loads data into the 'mağazaKayitDataSet3.Ürünler' table. You can move, or remove it, as needed.
            

        }

        private void btnRmove_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçili satırın indeksini al
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;

                    // DataGridView'den seçili satırı al
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedIndex];

                    // DataRowView'dan DataRow'a dönüştür
                    DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                    if (rowView != null)
                    {
                        DataRow selectedRowData = rowView.Row;

                        // Veritabanında silme işlemi yap
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM Ürünler WHERE StokNo = @StokNo";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@StokNo", selectedRowData["StokNo"]);

                                command.ExecuteNonQuery();
                            }
                        }

                        // DataGridView'i güncelle
                        UpdateDataGridView();

                       
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek bir ürün seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }




        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form form3 = Application.OpenForms["Form3"];
            if (form3 != null)
            {
                form3.Visible = true;
            }
            else
            {
                Form3 newForm3 = new Form3();
                newForm3.Show();
            }

            // Mevcut formu gizle
            this.Hide();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form2 = Application.OpenForms["Form2"];
            if (form2 != null)
            {
                form2.Visible = true;
            }
            else
            {
                Form2 newForm2 = new Form2();
                newForm2.Show();
            }

            // Mevcut formu gizle
            this.Hide();


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT StokNo, ÜrünAdi, Beden, Renk, StokAdedi FROM Ürünler WHERE StokNo LIKE @SearchText OR ÜrünAdi LIKE @SearchText OR Beden LIKE @SearchText OR Renk LIKE @SearchText OR StokAdedi LIKE @SearchText";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + txtSearch.Text + "%");

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
             Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult mesajSonucu = MessageBox.Show("Programı Kapatmak İstediğinize Emin Misiniz?",
               "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mesajSonucu == DialogResult.Yes)
            {
                Application.Exit();
            }



        }
    }
}
