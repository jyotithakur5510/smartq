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
    public partial class Serviceform : Form
    {
        public Serviceform()
        {
            InitializeComponent();

            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            var serviveList = smartQDBEntities.Services.ToList();
        }

        private void ServiceName_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Id = Guid.NewGuid();
            service.ServiceName = txtServiceName.Text;
            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            smartQDBEntities.Services.Add(service);
            smartQDBEntities.SaveChanges();
        }

    }
}
