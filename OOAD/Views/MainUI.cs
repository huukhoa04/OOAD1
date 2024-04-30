using Microsoft.Identity.Client;
using OOAD.Controllers;
using OOAD.Data;
using SQLitePCL;
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
    public partial class MainUI : Form
    {
        AppointmentController appointmentController;
        User _a { get; set; }
        public MainUI(User a)
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
            _a = a;
            nameLbl.Text = a.Username;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            DateTime dateTime = monthCalendar1.SelectionRange.Start;
            AddAppointment addAppointment = new AddAppointment(_a, dateTime);
            addAppointment.ShowDialog();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            nameLbl.Text = null;
            this.Hide();
            logInForm logInForm = new logInForm();
            logInForm.ShowDialog();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = appointmentController.GetAppointmentList(_a);
        }
    }
}
