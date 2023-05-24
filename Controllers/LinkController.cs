using Labb4API.Models;
using Labb4API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Labb4API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private ILinkRepository _linkrepo;
        private IPersonrepository _personrepo;

        public LinkController(ILinkRepository linkrepo, IPersonrepository personrepo)
        {
             _linkrepo= linkrepo;
            _personrepo= personrepo;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetLink(int id)
        {
            var personHobbieLinks = _linkrepo.LinkPerson(id);
            if (personHobbieLinks == null)
            {
                return NotFound($"Person with id {id} not found");
            }
            return Ok(personHobbieLinks);
        }


        [HttpPost]
        public IActionResult AddLink(Link link)
        {
            var result = _personrepo.GetSinglePerson(link.ID);
            if (result != null)
            {
                _linkrepo.AddLinkToPerson(link);
                return Created(HttpContext.Request.Scheme +
                    "://" +
                    HttpContext.Request.Host +
                    HttpContext.Request.Path +
                    "/" +
                    link.ID, link);
            }
            return NotFound($"Person with with id {link.PersonId} found");
        }

    }
}
