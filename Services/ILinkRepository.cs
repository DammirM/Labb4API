using Labb4API.Models;

namespace Labb4API.Services
{
    public interface ILinkRepository
    {

        List<string> LinkPerson(int ID);
        Link AddLinkToPerson(Link link);
    }
}
