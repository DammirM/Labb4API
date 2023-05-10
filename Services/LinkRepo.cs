using Labb4API.Context;
using Labb4API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4API.Services
{
    public class LinkRepo : ILinkRepository
    {

        private ApiDbContext _Apicontext;

        public LinkRepo(ApiDbContext apicontext)
        {
            _Apicontext = apicontext;
        }

        public Link AddLinkToPerson(Link link)
        {
            _Apicontext.Links.Add(link);
            _Apicontext.SaveChanges();
            return link;
        }

        public List<string> LinkPerson(int ID)
        {
            return _Apicontext.Links.Where(p => p.PersonId == ID).Select(s => s.Url).ToList();
        }
    }
}
