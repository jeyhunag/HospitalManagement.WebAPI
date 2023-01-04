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
        public Nurse AddNurse(Nurse obj);
        public List<Nurse> GetNurse();
        public Nurse GetNurseById(int id);
        public Nurse UpdateNurse(Nurse nurse);

        public void DeleteNurse(int id);
    }
}
