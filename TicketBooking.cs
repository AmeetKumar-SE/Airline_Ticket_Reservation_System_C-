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
    public partial class TicketBooking : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC-I\Documents\AirplaneDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public TicketBooking()
        {
            InitializeComponent();
        }

        private void fillPassengerComboBox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTbl", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(rdr);
            PassIDCB.ValueMember = "PassId";
            PassIDCB.DataSource=dt;
            con.Close();

        }

        private void fillFlightComboBox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FlightCodeCB.ValueMember = "Fcode";
            FlightCodeCB.DataSource = dt;
            con.Close();
        }
        string pname, ppass, padd, pnat,pgen;
        int age; 

        private void PassIDCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PassengerDataCollect();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassengerName.Text = "";
            txtPassportNumber.Text = "";
            txtTicketID.Text = "";
            txtAge.Text = "";
            txtAmount.Text = "";
            txtGender.Text = "";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

       

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtTicketID.Text == "" || txtPassengerName.Text == "" || txtAmount.Text=="")
            {
                MessageBox.Show("Kindly fill all given fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into TicketTbl values(" + txtTicketID.Text + ",'" + FlightCodeCB.SelectedValue.ToString() + "','" + PassIDCB.SelectedValue.ToString() + "','" +txtPassengerName.Text + "','"+txtGender.Text+"','" + txtPassportNumber.Text + "','"+nationalityComboBox.SelectedItem.ToString()+"','" + txtAge.Text + "'," + txtAmount.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Recorded Successfully");
                    con.Close();

                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void TicketBooking_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void PassengerDataCollect()
        {
            con.Open();
            string query = "select * from PassengerTbl where PassId="+PassIDCB.SelectedValue.ToString()+"";//error here
            SqlCommand command = new SqlCommand(query,con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["PassName"].ToString();
                ppass = dr["Passport"].ToString();
                pnat = dr["PassNat"].ToString();
                age =Convert.ToInt32( dr["PassAge"].ToString());
                pgen = dr["PassGender"].ToString();

                int a = nationalityComboBox.Items.IndexOf(pnat);
                txtPassengerName.Text = pname;
                txtAge.Text = age.ToString();
                txtPassportNumber.Text = ppass;
                nationalityComboBox.SelectedIndex = a;
                nationalityComboBox.SelectedItem = nationalityComboBox.SelectedIndex;
                txtGender.Text = pgen;


            }



            con.Close();
        }

       
        private void populate()
        {
            con.Open();
            string query = "select * from TicketTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketBookingGridView.DataSource = ds.Tables[0];
            con.Close();

        }
        private void TicketBooking_Load(object sender, EventArgs e)
        {

            fillPassengerComboBox();
            fillFlightComboBox();
            populate();
        }
    }
}
