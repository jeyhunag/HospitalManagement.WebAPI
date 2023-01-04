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
    public class MedicineRepostory:IMedicineRepostory
    {
        private readonly AppDbContext _dbContext;

        public MedicineRepostory(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public Medicine AddItem(Medicine obj)
        {
            _dbContext.medicines.Add(obj);
            _dbContext.SaveChanges();
            return obj;
        }



        public List<Medicine> GetItem()
        {
            var medicine = _dbContext.medicines.ToList();
            return medicine;
        }

        public Medicine GetItemById(int id)
        {
            var medicine = _dbContext.medicines.Find(id);
            return medicine;
        }

        public Medicine UpdateItem(Medicine medicine)
        {
            var dbMedicine = _dbContext.medicines.Find(medicine.Id);
            dbMedicine.medicine_name = medicine.medicine_name;
            dbMedicine.medicine_company = medicine.medicine_company;
            dbMedicine.medicine_composition = medicine.medicine_composition;
            dbMedicine.medicine_cost = medicine.medicine_cost;
            dbMedicine.medicine_type = medicine.medicine_type;
            dbMedicine.medicine_dose = medicine.medicine_dose;
            dbMedicine.medicine_description = medicine.medicine_description;
            dbMedicine.UpdateDate = DateTime.Now;
            _dbContext.medicines.Update(medicine);
            _dbContext.SaveChanges();
            return medicine;
        }

        public void DeleteItem(int id)
        {
            var dbMedicine = _dbContext.medicines.Find(id);
            _dbContext.medicines.Remove(dbMedicine);
            _dbContext.SaveChanges();
        }
    }
}
