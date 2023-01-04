using HospitalMenegment.DAL.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.Interfaces
{
    public interface IHospitalRepostory
    {
        public Hospital AddItem(Hospital obj);
        public List<Hospital> GetItem();
        public Hospital GetItemById(int id);
        public Hospital UpdateItem(Hospital medicine);

        public void DeleteItem(int id);
    }
}
