using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GiyimMağazası
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=MağazaKayit;Integrated Security=True;";
        private List<Stok> stokList;

        public Form2()
        {
            InitializeComponent();
            InitializeList();
           
            this.FormClosing += Form2_FormClosing;
        }

        





        private void InitializeList()
        {
            stokList = new List<Stok>();
        }

       

       

        private void UpdateDataGridView()
        {
            try
            {
                // Datasource ı temizle
                dataGridView1.DataSource = null;

                // Veritabanından verileri al ve datagridview e ekleme
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT StokNo, ÜrünAdi, Beden, Renk, StokAdedi FROM Ürünler";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Datasourceı güncelle
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
           
            txtStokAdedi.Clear();
        }

        private class Stok
        {
            public int StokNo { get; set; }
            public string UrunAdi { get; set; }
            public string Beden { get; set; }
            public string Renk { get; set; }
            public int StokAdedi { get; set; }

            public Stok(string urunAdi, string beden, string renk, int stokAdedi)
            {
                UrunAdi = urunAdi;
                Beden = beden;
                Renk = renk;
                StokAdedi = stokAdedi;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'mağazaKayitDataSet4.Ürünler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünlerTableAdapter1.Fill(this.mağazaKayitDataSet4.Ürünler);
            // TODO: This line of code loads data into the 'mağazaKayitDataSet3.Ürünler' table. You can move, or remove it, as needed.
           
        }


       




       

       
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

       
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string urunAdi = cmbAdd.Text; 
                string beden = cmbSize.Text; 
                string renk = cmbColor.Text; 
                int stokAdedi = Convert.ToInt32(txtStokAdedi.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Ürünler (ÜrünAdi, Beden, Renk, StokAdedi) VALUES (@UrunAdi, @Beden, @Renk, @StokAdedi)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UrunAdi", urunAdi);
                        command.Parameters.AddWithValue("@Beden", beden);
                        command.Parameters.AddWithValue("@Renk", renk);
                        command.Parameters.AddWithValue("@StokAdedi", stokAdedi);

                        command.ExecuteNonQuery();
                    }
                }

                stokList.Add(new Stok(urunAdi, beden, renk, stokAdedi));
                UpdateDataGridView();
                ClearTextBoxes(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            Form form4 = Application.OpenForms["Form4"];
            if (form4 != null)
            {
                form4.Visible = true;
            }
            else
            {
                Form4 newForm4 = new Form4();
                newForm4.Show();
            }

            // Mevcut formu gizle
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult mesajSonucu = MessageBox.Show("Programı Kapatmak İstediğinize Emin Misiniz?",
                "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mesajSonucu == DialogResult.Yes)
            {
                Application.Exit();
            }



        }

        private void cmbAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
