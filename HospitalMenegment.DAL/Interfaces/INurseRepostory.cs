using HospitalMenegment.DAL.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.Interfaces
{
    public interface INurseRepostory
    {
        public Nurse AddItem(Nurse obj);
        public List<Nurse> GetItem();
        public Nurse GetItemById(int id);
        public Nurse UpdateItem(Nurse medicine);

        public void DeleteItem(int id);
    }
}
