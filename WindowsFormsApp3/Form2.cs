using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp3.data;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            WindowsFormsApp3.data.Ticket ticket = new WindowsFormsApp3.data.Ticket();
            ticket.Id = Guid.NewGuid();
            

            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            smartQDBEntities.Tickets.Add(ticket);
            smartQDBEntities.SaveChanges();
        }
    }
}
