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
    public partial class RecordPassenger : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC-I\Documents\AirplaneDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public RecordPassenger()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPassengerID.Text == "" || txtPassengerName.Text == "" || label.Text=="" || txtPassportNumber.Text=="" || txtPhoneNo.Text == "")
            {
                MessageBox.Show("Kindly fill all given fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into PassengerTbl values(" + txtPassengerID.Text + ",'" + txtPassengerName.Text + "','" + txtPassportNumber.Text + "','" + txtPassengerAddress.Text + "','" + nationalityComboBox.SelectedItem.ToString() + "','" + GenderComboBox.SelectedItem.ToString() + "','" + txtPhoneNo.Text + "','"+txtAge.Text+"')";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    con.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

        private void RecordPassenger_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewPassenger view = new ViewPassenger();
            view.Show();
            this.Hide();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void RecordPassenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
