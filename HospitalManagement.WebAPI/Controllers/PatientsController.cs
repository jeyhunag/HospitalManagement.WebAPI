using HospitalMenegment.DAL.DbModels;
using HospitalMenegment.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientRepostory _patientRepostory;
        public PatientsController(IPatientRepostory patientRepostory)
        {
            _patientRepostory = patientRepostory;
        }


        [HttpGet]
        public List<Patient> GetPatients()
        {
            var response = _patientRepostory.GetPatients();
            return response;
        }
        [HttpGet("{id:int}")]
        public ActionResult<Patient> GetPatientById(int id)

        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _patientRepostory.GetPatientById(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost]
        public ActionResult<Patient> Create(Patient patient)
        {

            var response = _patientRepostory.Addpatient(patient);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Patient> Update(int id, [FromBody] Patient obj)
        {
            if (id == 0 || id != obj.Id)
            {
                return BadRequest();
            }

            var response = _patientRepostory.GetPatientById(id);
            if (response == null)
            {
                return NotFound();
            }
            response = _patientRepostory.UpdatePatient(obj);
            return Ok(response); ;
        }

        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _patientRepostory.GetPatientById(id);
            if (response == null)
            {
                return NotFound();
            }

            _patientRepostory.DeletePatient(id);
            return NoContent();
        }
    }
}
