using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation_System
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnFlights_Click(object sender, EventArgs e)
        {
            recordNewFlight flight = new recordNewFlight();
            flight.Show();
            this.Hide();
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            RecordPassenger record = new RecordPassenger();
            record.Show();
            this.Hide();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            TicketBooking ticket = new TicketBooking();
            ticket.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TicketCanceling canceling = new TicketCanceling();
            canceling.Show();
            this.Hide();
        }

       

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
