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
    
        public Patient AddItem(Patient obj);
        public List<Patient> GetItem();
        public Patient GetItemById(int id);
        public Patient UpdateItem(Patient medicine);

        public void DeleteItem(int id);
    }
}
