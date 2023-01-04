using HospitalManagement.WebAPI.Data;
using HospitalMenegment.DAL.DbModels;
using HospitalMenegment.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentRepostroy _appointment;
        public AppointmentsController(IAppointmentRepostroy appointment)
        {
            _appointment = appointment;
        }


        [HttpGet]
        public List<Appointment> GetItem()
        {
            var response = _appointment.GetItem();
            return response;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Appointment> GetItemById(int id)

        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _appointment.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost]
        public ActionResult<Appointment> Create(Appointment appointment)
        {
            var response = _appointment.AddItem(appointment);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Appointment> Update(int id, [FromBody] Appointment obj)
        {
            if (id == 0 || id != obj.Id)
            {
                return BadRequest();
            }

            var response = _appointment.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }
            response = _appointment.UpdateItem(obj);
            return Ok(response); ;
        }

        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _appointment.GetItemById(id);
            if (response == null)
            {
                return NotFound();
            }

            _appointment.DeleteItem(id);
            return NoContent();
        }
    }
}
