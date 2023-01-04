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
    public class DoctorRepostory:IDoctorRepostory
    {
        private readonly AppDbContext _dbContext;

        public DoctorRepostory(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Doctor AddItem(Doctor obj)
        {
            _dbContext.doctors.Add(obj);
            _dbContext.SaveChanges();
            return obj;
        }



        public List<Doctor> GetItem()
        {
            var doctor = _dbContext.doctors.ToList();
            return doctor;
        }

        public Doctor GetItemById(int id)
        {
            var doctor = _dbContext.doctors.Find(id);
            return doctor;
        }

        public Doctor UpdateItem(Doctor doctor)
        {
            var dbDoctor = _dbContext.doctors.Find(doctor.Id);
            dbDoctor.doctor_name = doctor.doctor_name;
            dbDoctor.doctor_speciast = doctor.doctor_speciast;
            dbDoctor.doctor_mobile = doctor.doctor_mobile;
            dbDoctor.doctor_email = doctor.doctor_email;
            dbDoctor.doctor_username = doctor.doctor_username;
            dbDoctor.doctor_password = doctor.doctor_password;
            dbDoctor.doctor_address = doctor.doctor_address;
            dbDoctor.UpdateDate = DateTime.Now;
            _dbContext.doctors.Update(doctor);
            _dbContext.SaveChanges();
            return doctor;
        }

        public void DeleteItem(int id)
        {
            var dbDoctor = _dbContext.doctors.Find(id);
            _dbContext.doctors.Remove(dbDoctor);
            _dbContext.SaveChanges();
        }
    }
}
