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
    public partial class ViewPassenger : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC-I\Documents\AirplaneDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public ViewPassenger()
        {
            InitializeComponent();
        }

       

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            con.Open();
            string query = "select * from PassengerTbl";
             SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengerGridView.DataSource = ds.Tables[0];
            con.Close();
        
        }

      
        private void btnBack_Click(object sender, EventArgs e)
        {
            RecordPassenger record = new RecordPassenger();
            record.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPassengerID.Text == "")
            {
                MessageBox.Show("Enter passenger id to delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from PassengerTbl where PassId=" + txtPassengerID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted suceesfully");
                    con.Close();
                    populate(); 

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PassengerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPassengerID.Text = PassengerGridView.SelectedRows[0].Cells[0].Value.ToString();
            txtPassengerName.Text = PassengerGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtPassportNumber.Text = PassengerGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtPassengerAddress.Text = PassengerGridView.SelectedRows[0].Cells[3].Value.ToString();
            nationalityComboBox.SelectedItem = PassengerGridView.SelectedRows[0].Cells[4].Value.ToString();
            GenderComboBox.SelectedItem = PassengerGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtPhoneNo.Text = PassengerGridView.SelectedRows[0].Cells[6].Value.ToString();
            txtAge.Text = PassengerGridView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassengerID.Text = "";
            txtPassengerName.Text = "";
            txtAge.Text = "";
            txtPassengerAddress.Text = "";
            txtPassportNumber.Text = "";
            txtPhoneNo.Text = "";
            GenderComboBox.Text = "";
            nationalityComboBox.Text = "";

               
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtPassengerID.Text=="" || txtPassengerName.Text=="" || txtPassportNumber.Text=="" || txtPhoneNo.Text=="" || txtPassengerAddress.Text=="" || txtAge.Text == "" || GenderComboBox.SelectedItem=="" || nationalityComboBox.SelectedItem=="")
            {
                MessageBox.Show("Include all information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update PassengerTbl set PassName='" + txtPassengerName.Text + "',Passport='" + txtPassportNumber.Text + "',PassAd='" + txtPassengerAddress.Text + "',PassNat='" + nationalityComboBox.SelectedItem.ToString() + "',PassGender='" + GenderComboBox.SelectedItem.ToString() + "',PassPhone='" + txtPhoneNo.Text + "',PassAge='" + txtAge.Text + "'where PassId=" + txtPassengerID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                    populate();
                    

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ViewPassenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
