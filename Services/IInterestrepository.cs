using Labb4API.Models;

namespace Labb4API.Services
{
    public interface IInterestrepository
    {
        List<Interest> GetInterest(int ID);
        Link AddInterest(Link link);

    }
}
