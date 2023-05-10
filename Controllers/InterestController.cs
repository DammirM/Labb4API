using Labb4API.Models;
using Labb4API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labb4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        private IPersonrepository _personRepository;
        private IInterestrepository _interestRepository;

        public InterestController(IPersonrepository personRepository, IInterestrepository interestRepository)
        {

            _personRepository = personRepository;
            _interestRepository = interestRepository;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetPersonHobbies(int id)
        {
            var personHobbies = _interestRepository.GetHobbiesOfPerson(id);
            if (personHobbies == null)
            {
                return NotFound($"Person with id {id} not found");
            }
            return Ok(personHobbies);
        }


        [HttpPost]
        public IActionResult AddHobbieToPerson(Link link)
        {
            var result = _personRepository.GetSinglePerson(link.ID);
            if (result != null)
            {
                _interestRepository.AddHobbieToPerson(link);
                return Created(HttpContext.Request.Scheme +
                    "://" +
                    HttpContext.Request.Host +
                    HttpContext.Request.Path +
                    "/" +
                    link.ID, link);
            }
            return NotFound($"Person with id {link.PersonId} not found");
        }

    }
}
