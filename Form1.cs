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


namespace Student_Registration_Managment
{
    public partial class Form1 : Form
    {
        DataTable driverTable; // Globally declared

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDriverData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["AID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TollTaxDB;Integrated Security=True"))
                    {
                        string sql = "DELETE FROM Drivers WHERE AID = @AID";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@AID", id);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadDriverData();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().Replace("'", "''");

            if (driverTable != null)
            {
                driverTable.DefaultView.RowFilter =
                    $"[DriverName] LIKE '%{keyword}%' OR [DriverNIC] LIKE '%{keyword}%'";
            }

        }



        public void LoadDriverData()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TollTaxDB;Integrated Security=True;";
            string query = "SELECT * FROM Drivers";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                driverTable = new DataTable(); // GLOBAL DATA TABLE
                da.Fill(driverTable);
                dataGridView1.DataSource = driverTable;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Form2 vehicleForm = new Form2(this);
            vehicleForm.Show();
        }
    }

}
