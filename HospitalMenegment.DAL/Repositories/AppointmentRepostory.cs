using HospitalManagement.WebAPI.Data;
using HospitalMenegment.DAL.DbModels;
using HospitalMenegment.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.Repositories
{
    public class AppointmentRepostory:IAppointmentRepostroy
    {
        private readonly AppDbContext _dbContext;

        public AppointmentRepostory(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Appointment AddItem(Appointment obj)
        {
            _dbContext.appointments.Add(obj);
            _dbContext.SaveChanges();
            return obj;
        }



        public List<Appointment> GetItem()
        {
            var app = _dbContext.appointments.ToList();
            return app;
        }

        public Appointment GetItemById(int id)
        {
            var app = _dbContext.appointments.Find(id);
            return app;
        }

        public Appointment UpdateItem(Appointment appointment)
        {
            var dbAppointment = _dbContext.appointments.Find(appointment.Id);
            dbAppointment.appointment_number = appointment.appointment_number;
            dbAppointment.appointment_type = appointment.appointment_type;
            dbAppointment.appointment_date = appointment.appointment_date;
            dbAppointment.appointment_description = appointment.appointment_description;
            dbAppointment.DoctorId = appointment.DoctorId;
            dbAppointment.UpdateDate = DateTime.Now;
            _dbContext.appointments.Update(appointment);
            _dbContext.SaveChanges();
            return appointment;
        }

        public void DeleteItem(int id)
        {
            var dbAppointment = _dbContext.appointments.Find(id);
            _dbContext.appointments.Remove(dbAppointment);
            _dbContext.SaveChanges();
        }
    }
}
