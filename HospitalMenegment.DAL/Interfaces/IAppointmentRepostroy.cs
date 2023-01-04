using HospitalMenegment.DAL.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMenegment.DAL.Interfaces
{
    public interface IAppointmentRepostroy
    {
        public Appointment AddItem(Appointment obj);
        public List<Appointment> GetItem();
        public Appointment GetItemById(int id);
        public Appointment UpdateItem(Appointment medicine);

        public void DeleteItem(int id);
    }
}
