using HospitalMenegment.DAL.DbModels;
using HospitalMenegment.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NursesController : ControllerBase
    {
        private readonly INurseRepostory _nurseRepostory;
        public NursesController(INurseRepostory nurseRepostory)
        {
            _nurseRepostory = nurseRepostory;
        }


        [HttpGet]
        public List<Nurse> GetNurse()
        {
            var response = _nurseRepostory.GetNurse();
            return response;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Nurse> GetNurseById(int id)

        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _nurseRepostory.GetNurseById(id);
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost]
        public ActionResult<Nurse> Create(Nurse nurse)
        {

            var response = _nurseRepostory.AddNurse(nurse);
            return Ok(response);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Nurse> Update(int id, [FromBody] Nurse obj)
        {
            if (id == 0 || id != obj.Id)
            {
                return BadRequest();
            }

            var response = _nurseRepostory.GetNurseById(id);
            if (response == null)
            {
                return NotFound();
            }
            response = _nurseRepostory.UpdateNurse(obj);
            return Ok(response); ;
        }

        [HttpDelete("{id:int}")]

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var response = _nurseRepostory.GetNurseById(id);
            if (response == null)
            {
                return NotFound();
            }

            _nurseRepostory.DeleteNurse(id);
            return NoContent();
        }
    }
}
