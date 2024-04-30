using OOAD.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAD.Views
{
    public partial class ReplaceCheck : Form
    {
        public delegate void Confirm(bool check);
        public Confirm confirm;
        public AppointmentController appointmentController {  get; set; }
        public ReplaceCheck()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            confirm(true);
            this.Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            confirm(false);
            this.Hide();
        }
    }
}
