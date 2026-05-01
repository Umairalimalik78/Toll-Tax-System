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
    public partial class Form2 : Form
    {
        Form1 mainForm;

        public Form2(Form1 callingForm)
        {
            InitializeComponent();
            mainForm = callingForm;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*if (txtDriverName.Text == "" || txtDriverNIC.Text == "" || cmbVehicle.SelectedIndex == -1 ||
                cmbFromCity.SelectedIndex == -1 || cmbToCity.SelectedIndex == -1 ||
                txtTollTax.Text == "" || txtPassengers.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }*/

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TollTaxDB;Integrated Security=True;"))
                {
                    string query = "INSERT INTO Drivers (DriverName, DriverNIC, CrossingVehicle, FromCity, ToCity, TravelDate, TollTAX, Passengers) " +
                                   "VALUES (@name, @nic, @vehicle, @from, @to, @date, @tax, @pass)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtDriverName.Text);
                        cmd.Parameters.AddWithValue("@nic", txtDriverNIC.Text);
                        cmd.Parameters.AddWithValue("@vehicle", cmbVehicle.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@from", cmbFromCity.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@to", cmbToCity.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@date", dtTravelDate.Value);
                        cmd.Parameters.AddWithValue("@tax", Convert.ToInt32(txtTollTax.Text));
                        cmd.Parameters.AddWithValue("@pass", Convert.ToInt32(txtPassengers.Text));

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Driver record added successfully.");

                        mainForm.LoadDriverData();
                        this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
                else if (ctrl is DateTimePicker)
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cmbToCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFromCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
