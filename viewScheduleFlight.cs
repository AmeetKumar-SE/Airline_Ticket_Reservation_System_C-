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
    public partial class viewScheduleFlight : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC-I\Documents\AirplaneDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public viewScheduleFlight()
        {
            InitializeComponent();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightGridView.DataSource = ds.Tables[0];
            con.Close();

        }
        private void viewScheduleFlight_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            recordNewFlight recordNewFlight = new recordNewFlight();
            recordNewFlight.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFlightCode.Text = "";
            sourceComboBox.Text = "";
            DestinationComboBox.Text = "";
            txtSeats.Text = "";

        }

        private void FlightGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFlightCode.Text = FlightGridView.SelectedRows[0].Cells[0].Value.ToString();
            sourceComboBox.SelectedItem = FlightGridView.SelectedRows[0].Cells[1].Value.ToString();
            DestinationComboBox.SelectedItem = FlightGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtSeats.Text = FlightGridView.SelectedRows[0].Cells[4].Value.ToString(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFlightCode.Text == "")
            {
                MessageBox.Show("Enter Flight Code");
            }
            else
            {
                try
                {//edit this
                    con.Open();
                    string query = "delete from FlightTbl where Fcode='" + txtFlightCode.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight deleted suceesfully");
                    con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFlightCode.Text == "" || txtSeats.Text == "" || dateTimePicker1.Text == "" || sourceComboBox.Text == "" || DestinationComboBox.Text == "")
            {
                MessageBox.Show("Include all information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update FlightTbl set Fsrc='" + sourceComboBox.SelectedItem.ToString() + "',FDest='" + DestinationComboBox.SelectedItem.ToString() + "',FDate='" + dateTimePicker1.Value.ToString() + "',Fcap='" + txtSeats.Text + "' where Fcode='" +txtFlightCode.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Updated Successfully");
                    con.Close();
                    populate();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void viewScheduleFlight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
