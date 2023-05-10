using Labb4API.Models;
using Labb4API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labb4API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonrepository _personrepository;
        public PersonController(IPersonrepository personrepo)
        {
            this._personrepository = personrepo;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(_personrepository.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetSingle(int id)
        {
            var person = _personrepository.GetSinglePerson(id);
            if (person != null)
            {
                return Ok(person);
            }
            return NotFound($"Person with ID {id} not found");
        }


        // osäkert
        [HttpPost]
        public IActionResult AddNewPerson(Person NewPerson)
        {
            _personrepository.AddPerson(NewPerson);
            return Created(HttpContext.Request.Scheme +
                    "://" +
                    HttpContext.Request.Host +
                    HttpContext.Request.Path +
                    "/" +
                    NewPerson.ID, NewPerson);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            var userToDelete = _personrepository.GetSinglePerson(id);
            if (userToDelete != null)
            {
                _personrepository.DeletePerson(userToDelete);
                return Ok();
            }
            return NotFound($"Person with id {id} not found");
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePerson(int id, Person personToUpdate)
        {
            var existingUser = _personrepository.GetSinglePerson(id);
            if (existingUser != null)
            {
                existingUser.ID = personToUpdate.ID;
                existingUser.FirstName= personToUpdate.FirstName;
                _personrepository.UpdatePerson(personToUpdate);
            }
            return Ok();
        }


    }
}
