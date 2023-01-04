using HospitalMenegment.DAL.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.Interfaces
{
    public interface IPatientRepostory
    {
        public Patient Addpatient(Patient obj);
        public List<Patient> GetPatients();
        public Patient GetPatientById(int id);
        public Patient UpdatePatient(Patient patient);

        public void DeletePatient(int id);
    }
}
