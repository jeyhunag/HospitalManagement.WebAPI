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
    public class HospitalRepostory:IHospitalRepostory
    {
        private readonly AppDbContext _dbContext;

        public HospitalRepostory(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Hospital AddItem(Hospital obj)
        {
            _dbContext.hospitals.Add(obj);
            _dbContext.SaveChanges();
            return obj;
        }



        public List<Hospital> GetItem()
        {
            var hospital = _dbContext.hospitals.ToList();
            return hospital;
        }

        public Hospital GetItemById(int id)
        {
            var hospital = _dbContext.hospitals.Find(id);
            return hospital;
        }

        public Hospital UpdateItem(Hospital hospital)
        {
            var dbHospital = _dbContext.hospitals.Find(hospital.Id);
            dbHospital.hospital_name = hospital.hospital_name;
            dbHospital.hospital_place = hospital.hospital_place;
            dbHospital.hospital_type = hospital.hospital_type;
            dbHospital.hospital_description = hospital.hospital_description;
            dbHospital.hospital_address = hospital.hospital_address;
            dbHospital.hospital_address = hospital.hospital_address;
            dbHospital.UpdateDate = DateTime.Now;
            _dbContext.hospitals.Update(hospital);
            _dbContext.SaveChanges();
            return hospital;
        }

        public void DeleteItem(int id)
        {
            var dbHospital = _dbContext.hospitals.Find(id);
            _dbContext.hospitals.Remove(dbHospital);
            _dbContext.SaveChanges();
        }
    }
}
