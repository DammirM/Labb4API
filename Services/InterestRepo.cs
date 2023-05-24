using Labb4API.Context;
using Labb4API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4API.Services
{
    public class InterestRepo : IInterestrepository
    {

        private ApiDbContext _Apicontext;

        public InterestRepo(ApiDbContext context)
        {
            _Apicontext = context;
        }

        public Link AddInterest(Link link)
        {
            _Apicontext.Links.Add(link);
            _Apicontext.SaveChanges();
            return link;
        }

        public List<Interest> GetInterest(int ID)
        {
            return _Apicontext.Links.Where(p => p.PersonId == ID).Select(h => h.Interest).ToList();
        }
    }
}
