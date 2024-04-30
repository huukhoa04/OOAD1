using Microsoft.IdentityModel.Tokens;
using OOAD.Controllers;
using OOAD.Data;
using OOAD.Models;
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
    public partial class AddAppointment : Form
    {
        AppointmentController _appointmentController;
        User _a { get; set; }
        DateTime _dateTime { get; set; }
        bool GlobalCheck { get; set; }
        public AddAppointment(User a, DateTime dateTime)
        {
            _appointmentController = new AppointmentController();
            InitializeComponent();
            CBBInit();
            GlobalCheck = false;
            _a = a;
            _dateTime = dateTime;
            label1.Text = "Add a new Appointment for date: " + _dateTime.ToString();
            hour1TxtBox.Text = _dateTime.Hour.ToString();
            min1TxtBox.Text = _dateTime.Minute.ToString();
            sec1TxtBox.Text = _dateTime.Second.ToString();
            hour2TxtBox.Text = _dateTime.Hour.ToString();
            min2TxtBox.Text = _dateTime.Minute.ToString();
            sec2TxtBox.Text = _dateTime.Second.ToString();
        }
        private void CBBInit()
        {
            List<string> list1 = new List<string>();
            list1.Add("Before 5 minutes");
            list1.Add("Before 15 minutes");
            list1.Add("Before 30 minutes");
            list1.Add("Before 1 hour");
            rmdCbb.Items.AddRange(list1.ToArray());
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            

                ReminderModel reminderModel = new ReminderModel
                {
                    IsTurnedOn = false,
                    RmdTime = _dateTime
                };

                TimeSpan Start_time = new TimeSpan(Convert.ToInt32(hour1TxtBox.Text), Convert.ToInt32(min1TxtBox.Text), Convert.ToInt32(sec1TxtBox.Text));
                TimeSpan End_time = new TimeSpan(Convert.ToInt32(hour2TxtBox.Text), Convert.ToInt32(min2TxtBox.Text), Convert.ToInt32(sec2TxtBox.Text));

                if (appNameTxtBox.Text.IsNullOrEmpty() || lctTxtBox.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("PLEASE ENTER INFORMATION!!");
                    return;
                }

                if (Start_time >= End_time)
                {
                    MessageBox.Show("START TIME MUST BE SMALLER THAN END TIME");

                    return;
                }

                AppointmentModel appointmentModel = new AppointmentModel
                {
                    AptName = appNameTxtBox.Text,
                    AptLocation = lctTxtBox.Text,
                    AptStartTime = _dateTime.Add(Start_time),
                    AptEndTime = _dateTime.Add(End_time),
                    Userid = _a.Userid
                };
                if (rmdCb.Checked)
                {
                    reminderModel.IsTurnedOn = true;
                    if (rmdCbb.SelectedIndex > -1)
                    {
                        TimeSpan timeSpan = new TimeSpan();
                        if (rmdCbb.SelectedIndex == 0)
                        {
                            timeSpan = new TimeSpan(0, 5, 0);
                        }
                        if (rmdCbb.SelectedIndex == 0)
                        {
                            timeSpan = new TimeSpan(0, 15, 0);
                        }
                        if (rmdCbb.SelectedIndex == 0)
                        {
                            timeSpan = new TimeSpan(0, 30, 0);
                        }
                        if (rmdCbb.SelectedIndex == 0)
                        {
                            timeSpan = new TimeSpan(1, 0, 0);
                        }
                        reminderModel.RmdTime = _dateTime.Add(Start_time).Subtract(timeSpan);
                    }
                }
                var DupCheck = _appointmentController.DuplicateCheck(appointmentModel);
                if (DupCheck != null)
                {
                    DuplicateWarning duplicateWarning = new DuplicateWarning();
                    duplicateWarning.confirm = new DuplicateWarning.Confirm(Check);
                    duplicateWarning.ShowDialog();
                    if (GlobalCheck == true)
                    {
                        GroupMeetingModel groupMeetingModel = new GroupMeetingModel
                        {
                            AptId = DupCheck.AptId,
                            UserId = _a.Userid
                        };
                        var AddGM = _appointmentController.AddGM(groupMeetingModel);
                        if (AddGM == true)
                        {
                            MessageBox.Show("SUCCESSFULLY JOINED THIS GROUP MEETING");
                        }
                        else
                        {
                            MessageBox.Show("YOU HAVE ALREADY JOINED THIS GROUP MEETING");
                        }
                        GlobalCheck = false;
                    }
                }
                else
                {
                    var AddAptCheck = _appointmentController.Add(appointmentModel, reminderModel);
                    if (AddAptCheck == true)
                    {
                        MessageBox.Show("SUCCESSFULLY ADDED APPOINTMENT!");
                        this.Close();
                    }
                    else
                    {
                        ReplaceCheck replaceCheck = new ReplaceCheck();
                        replaceCheck.confirm = new ReplaceCheck.Confirm(Check);
                        replaceCheck.ShowDialog();
                        if (GlobalCheck == true)
                        {
                            _appointmentController.Replace(appointmentModel, reminderModel);
                        }
                    }
                }
            

        }
        public void Check(bool a)
        {
            GlobalCheck = a;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
