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
    public partial class TicketCanceling : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC-I\Documents\AirplaneDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public TicketCanceling()
        {
            InitializeComponent();
        }

        private void TicketCanceling_Load(object sender, EventArgs e)
        {
            fillTicketComboBox();
            populate();
        }

        private void deleteTicket()
        {
            
                try
                {
                    con.Open();
                    string query = "delete from TicketTbl where TId=" + ticketComboBox.SelectedValue.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            
        }

        private void fillTicketComboBox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select TId from TicketTbl", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TId", typeof(int));
            dt.Load(rdr);
            ticketComboBox.ValueMember = "TId";
            ticketComboBox.DataSource = dt;
            con.Close();
        }

        private void FlightDataCollect()
        {
            con.Open();
            string query = "select * from TicketTbl where TId=" + ticketComboBox.SelectedValue.ToString() + "";
            SqlCommand command = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtFlightCode.Text = dr["Fcode"].ToString();
               

                


            }
            con.Close();
        }

            private void CancelDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ticketComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FlightDataCollect();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFlightCode.Text = "";
            txtCancelID.Text = "";
        }
        private void populate()
        {
            con.Open();
            string query = "select * from CancelTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CancelDataGridView.DataSource = ds.Tables[0];
            con.Close();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtCancelID.Text == "")
            {
                MessageBox.Show("Kindly fill all given fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into CancelTbl values(" + txtCancelID.Text + ",'" + ticketComboBox.SelectedValue.ToString() + "','" + txtFlightCode.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancel Successfully");

                    con.Close();
                    deleteTicket();
                    populate();
                    fillTicketComboBox();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)//delete from records
        {

            try
            {
                con.Open();
                string query = "delete from CancelTbl where CancelId=" + txtCancelID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                populate();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void TicketCanceling_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
