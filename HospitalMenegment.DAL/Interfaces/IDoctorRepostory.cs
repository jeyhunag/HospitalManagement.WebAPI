using HospitalMenegment.DAL.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.Interfaces
{
    public interface IDoctorRepostory
    {
        public Doctor AddItem(Doctor obj);
        public List<Doctor> GetItem();
        public Doctor GetItemById(int id);
        public Doctor UpdateItem(Doctor medicine);

        public void DeleteItem(int id);
    }
}
