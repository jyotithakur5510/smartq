using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.data;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
        private void txtTicketNumber_TextChanged(object sender, EventArgs e)
            { 

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            Ticket ticket = new Ticket();
            ticket.Id = Guid.NewGuid();

            ticket.TicketNumber = txtTicketNumber.Text;
            ticket.Resolution = txtResolution.Text;
            smartQDBEntities.Tickets.Add(ticket);
            smartQDBEntities.SaveChanges();
        }
    }
    }

