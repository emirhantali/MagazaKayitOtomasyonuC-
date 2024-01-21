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
    public partial class Form3 : Form
    {

        private string connectionString = "Data Source=localhost;Initial Catalog=MağazaKayit;Integrated Security=True;";


        public Form3()
        {
            InitializeComponent();
            this.FormClosing += Form3_FormClosing;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Dataset'ten seçili satırın verilerini al
                DataRow selectedRowData = (DataRow)selectedRow.DataBoundItem;

                // Kontrolleri doldur
                cmbUpdateName.Text = selectedRowData["ÜrünAdi"].ToString();
                cmbUpdateSize.Text = selectedRowData["Beden"].ToString();
                cmbUpdateColor.Text = selectedRowData["Renk"].ToString();
                txtUpdateStokAdedi.Text = selectedRowData["StokAdedi"].ToString();
            }
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

        private void ClearTextBoxes()
        {

            txtUpdateStokAdedi.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'mağazaKayitDataSet4.Ürünler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ürünlerTableAdapter1.Fill(this.mağazaKayitDataSet4.Ürünler);
            // TODO: This line of code loads data into the 'mağazaKayitDataSet31.Ürünler' table. You can move, or remove it, as needed.
            

        }

        private void txtUpdateStokNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUpdateName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUpdateSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUpdateColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUpdateStokAdedi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

                        // Veritabanında güncelleme işlemi yap
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "UPDATE Ürünler SET ÜrünAdi = @UrunAdi, Beden = @Beden, Renk = @Renk, StokAdedi = @StokAdedi WHERE StokNo = @StokNo";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@StokNo", selectedRowData["StokNo"]);
                                command.Parameters.AddWithValue("@UrunAdi", cmbUpdateName.Text);
                                command.Parameters.AddWithValue("@Beden", cmbUpdateSize.Text);
                                command.Parameters.AddWithValue("@Renk", cmbUpdateColor.Text);
                                command.Parameters.AddWithValue("@StokAdedi", Convert.ToInt32(txtUpdateStokAdedi.Text));

                                command.ExecuteNonQuery();
                            }
                        }

                        // DataGridView'i güncelle
                        UpdateDataGridView();

                        // TextBox'ları ve ComboBox'ları temizle
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen güncellenecek bir ürün seçin.");
                }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // DataRowView'dan DataRow'a dönüştür
                DataRowView rowView = row.DataBoundItem as DataRowView;

                if (rowView != null)
                {
                    DataRow selectedRowData = rowView.Row;

                    // Kontrolleri doldur
                    txtUpdateStokNo.Text = selectedRowData["StokNo"].ToString();
                    cmbUpdateName.Text = selectedRowData["ÜrünAdi"].ToString();
                    cmbUpdateSize.Text = selectedRowData["Beden"].ToString();
                    cmbUpdateColor.Text = selectedRowData["Renk"].ToString();
                    txtUpdateStokAdedi.Text = selectedRowData["StokAdedi"].ToString();
                }

            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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
