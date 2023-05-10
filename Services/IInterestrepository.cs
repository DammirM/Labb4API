using Labb4API.Models;

namespace Labb4API.Services
{
    public interface IInterestrepository
    {
        List<Interest> GetHobbiesOfPerson(int ID);
        Link AddHobbieToPerson(Link link);

    }
}
