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

namespace Airline_Reservation_System
{
    public partial class recordNewFlight : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC-I\Documents\AirplaneDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public recordNewFlight()
        {
            InitializeComponent();
        }

       

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            txtFlightCode.Text = "";
            sourceComboBox.Text = "";
            DestinationComboBox.Text = "";
            txtSeats.Text = "";
            

        }

        private void Loginbtn_Click(object sender, EventArgs e)//btnRecord
        {
            if (txtFlightCode.Text == "" || sourceComboBox.Text == "" || DestinationComboBox.Text == "" || dateTimePicker1.Text == "" || txtSeats.Text == "")
            {
                MessageBox.Show("Kindly fill all given fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into FlightTbl values('" + txtFlightCode.Text + "','" + sourceComboBox.SelectedItem.ToString() + "','" + DestinationComboBox.SelectedItem.ToString() + "','" + dateTimePicker1.Value.ToString() + "'," +txtSeats.Text+ ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

       

        private void btnViewFlights_Click(object sender, EventArgs e)
        {
            viewScheduleFlight view = new viewScheduleFlight();
            view.Show();
            this.Hide();
        }

        private void recordNewFlight_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void recordNewFlight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
