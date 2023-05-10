using Labb4API.Context;
using Labb4API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4API.Services
{
    public class PersonRepo : IPersonrepository
    {

        private ApiDbContext _Apicontext;

        public PersonRepo(ApiDbContext apiDbcontext)
        {
            _Apicontext = apiDbcontext;
        }

        public Person AddPerson(Person newPerson)
        {
            _Apicontext.Persons.Add(newPerson);
            _Apicontext.SaveChanges();
            return newPerson;
        }

        public List<Person> GetAll()
        {
            return _Apicontext.Persons.ToList();
        }


        public Person GetSinglePerson(int id)
        {
            return _Apicontext.Persons.FirstOrDefault(p => p.ID == id);
        }

        public void DeletePerson(Person Delete)
        {
            _Apicontext.Persons.Remove(Delete);
            _Apicontext.SaveChanges();
        }


        public Person UpdatePerson(Person UpdatedPerson)
        {
            var result = _Apicontext.Persons.Find(UpdatedPerson.ID);
            if (result != null)
            {
                result.FirstName = UpdatedPerson.FirstName;
                result.Phone = UpdatedPerson.Phone;
                _Apicontext.Persons.Update(result);
                _Apicontext.SaveChanges();
            }
            return UpdatedPerson;
        }
    }
}
