using Labb4API.Models;

namespace Labb4API.Services
{
    public interface IPersonrepository
    {
        List<Person> GetAll();
        Person GetSinglePerson(int id);
        Person AddPerson(Person newperson);
        void DeletePerson(Person DeletedPerson);
        Person UpdatePerson(Person UpdatePerson);
    }
}
