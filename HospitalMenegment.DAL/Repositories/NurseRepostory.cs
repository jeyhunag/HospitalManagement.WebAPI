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
    public class NurseRepostory:INurseRepostory
    {
        private readonly AppDbContext _dbContext;

        public NurseRepostory(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Nurse AddNurse(Nurse obj)
        {
            _dbContext.nurses.Add(obj);
            _dbContext.SaveChanges();
            return obj;
        }



        public List<Nurse> GetNurse()
        {
            var nurse = _dbContext.nurses.ToList();
            return nurse;
        }

        public Nurse GetNurseById(int id)
        {
            var nurse = _dbContext.nurses.Find(id);
            return nurse;
        }

        public Nurse UpdateNurse(Nurse nurse)
        {
            var dbNurse = _dbContext.nurses.Find(nurse.Id);
            dbNurse.nurse_name = nurse.nurse_name;
            dbNurse.nurse_email = nurse.nurse_email;
            dbNurse.nurse_duty_hour = nurse.nurse_duty_hour;
            dbNurse.nurse_mobile = nurse.nurse_mobile;
            dbNurse.nurse_username = nurse.nurse_username;
            dbNurse.nurse_password = nurse.nurse_password;
            dbNurse.nurse_address = nurse.nurse_address;
            dbNurse.UpdateDate = DateTime.Now;
            _dbContext.nurses.Update(nurse);
            _dbContext.SaveChanges();
            return nurse;
        }

        public void DeleteNurse(int id)
        {
            var dbNurse = _dbContext.nurses.Find(id);
            _dbContext.nurses.Remove(dbNurse);
            _dbContext.SaveChanges();
        }
    }
}
