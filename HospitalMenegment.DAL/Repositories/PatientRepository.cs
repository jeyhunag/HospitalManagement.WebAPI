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
    public class PatientRepository : IPatientRepostory
    {
        private readonly AppDbContext _dbContext;

        public PatientRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Patient Addpatient(Patient obj)
        {
            _dbContext.patients.Add(obj);
            _dbContext.SaveChanges();
            return obj;
        }



        public List<Patient> GetPatients()
        {
            var patients = _dbContext.patients.ToList();
            return patients;
        }

        public Patient GetPatientById(int id)
        {
            var patient = _dbContext.patients.Find(id);
            return patient;
        }

        public Patient UpdatePatient(Patient patient)
        {
            var dbPatient = _dbContext.patients.Find(patient.Id);
            dbPatient.patient_Name = patient.patient_Name;
            dbPatient.patient_mobile = patient.patient_mobile;
            dbPatient.patient_username = patient.patient_username;
            dbPatient.patient_password = patient.patient_password;
            dbPatient.patient_address = patient.patient_address;
            dbPatient.patient_blood_group = patient.patient_blood_group;
            dbPatient.UpdateDate = DateTime.Now;
            _dbContext.patients.Update(patient);
            _dbContext.SaveChanges();
            return patient;
        }

        public void DeletePatient(int id)
        {
            var dbPatient = _dbContext.patients.Find(id);
            _dbContext.patients.Remove(dbPatient);
            _dbContext.SaveChanges();
        }

    }
}
