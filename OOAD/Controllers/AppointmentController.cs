using Microsoft.EntityFrameworkCore;
using OOAD.Data;
using OOAD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.Controllers
{
    public class AppointmentController
    {
        public readonly OoadContext _context;
        
        public AppointmentController() 
        {
            _context = new OoadContext();
        }
        public List<Appointment> GetAppointmentList(User a)
        {
            return _context.Appointments.Where(x => x.Userid == a.Userid).ToList();
        }
        public Appointment DuplicateCheck(AppointmentModel appointmentModel)
        {
            var check = _context.Appointments.SingleOrDefault(x => x.AptLocation == appointmentModel.AptLocation && x.AptName == appointmentModel.AptName);
            if(check != null)
            {
                return check;
            }
            else return null;
        }
        public bool AddGM(GroupMeetingModel groupMeetingModel)
        {
            var check = _context.Appointments.SingleOrDefault(x => x.AptId == groupMeetingModel.AptId && x.Userid == groupMeetingModel.UserId);
            if(check != null)
            {
                return false;
            }
            else
            {
                Groupmeeting groupmeeting = new Groupmeeting
                {
                    AptId = groupMeetingModel.AptId,
                    Userid = groupMeetingModel.UserId
                };
                
                _context.Database.ExecuteSqlAsync($"INSERT INTO GROUPMEETING([APT_ID], [USERID]) VALUES({groupmeeting.AptId}, {groupmeeting.Userid});");
                _context.SaveChanges();
                return true;
            }
        }
        public bool Add(AppointmentModel appointmentModel, ReminderModel reminderModel)
        {
            var check = _context.Appointments.SingleOrDefault(x => x.AptStartTime >= appointmentModel.AptStartTime && x.AptStartTime < appointmentModel.AptEndTime);
            if (check != null)
            {
                return false;
            }
            else
            {
                Appointment appointment = new Appointment 
                { 
                    AptId = _context.Appointments.Count(),
                    AptName = appointmentModel.AptName,
                    AptLocation = appointmentModel.AptLocation,
                    AptStartTime = appointmentModel.AptStartTime,
                    AptEndTime = appointmentModel.AptEndTime,
                    Userid = appointmentModel.Userid
                };
                _context.Appointments.Add(appointment);
                if (reminderModel.IsTurnedOn == true)
                {
                    Reminder reminder = new Reminder
                    {
                        RmdTime = reminderModel.RmdTime,
                        AptId = appointment.AptId,
                    };
                    _context.Reminders.Add(reminder);
                }
                _context.SaveChanges();
                return true;
            }
        }
        public void Replace(AppointmentModel appointmentModel, ReminderModel reminderModel)
        {
            var check = _context.Appointments.SingleOrDefault(x => x.AptStartTime >= appointmentModel.AptStartTime && x.AptStartTime < appointmentModel.AptEndTime);
            Appointment appointment = new Appointment
            {
                AptId = check.AptId,
                AptName = appointmentModel.AptName,
                AptLocation = appointmentModel.AptLocation,
                AptStartTime = appointmentModel.AptStartTime,
                AptEndTime = appointmentModel.AptEndTime,
                Userid = appointmentModel.Userid
            };
            check = null;
            _context.Update(appointment);
            var RemindCheck = _context.Reminders.SingleOrDefault(x => x.AptId == appointment.AptId);
            if(reminderModel.IsTurnedOn == true) 
            {
                Reminder reminder = new Reminder
                {
                    RmdTime = reminderModel.RmdTime,
                    AptId = appointment.AptId
                };
            _context.Update(reminder);
            }
            _context.SaveChanges();
        }
    }
}
