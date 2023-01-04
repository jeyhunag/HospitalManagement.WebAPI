using HospitalMenegment.DAL.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.Interfaces
{
    public interface IMedicineRepostory
    {
        public Medicine AddItem(Medicine obj);
        public List<Medicine> GetItem();
        public Medicine GetItemById(int id);
        public Medicine UpdateItem(Medicine medicine);

        public void DeleteItem(int id);
    }
}
