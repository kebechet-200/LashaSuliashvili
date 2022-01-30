using PersonService.Abstractions;
using PersonService.Exceptions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonService
{
    public class PersonsService : IPersonsService
    {
        private readonly List<Person> _people;

        public PersonsService()
        {
            _people = new List<Person>()
            {
                new Person
                {
                    Age = 19,
                    BankCard = "bankcard",
                    Email = "Example@gmail.com",
                    FirstName = "Lasha",
                    LastName = "Suliashvili",
                    PersonalNumber = "23142141",
                    PersonalWebsite = "Example.com",
                    PhoneNumber = "5151-521-5-125"
                }
            };

        }

        public async Task AddAsync(Person person)
        {
            _people.Add(person);

            await Task.CompletedTask;
        }
        
        public async Task<Person> GetAsync(string personalNumber)
        {
            var person = (from p in _people 
                          where p.PersonalNumber == personalNumber
                          select p).FirstOrDefault();

            if (person == null)
                throw new PersonCouldNotFoundException("This Person Could Not Found");

            return await Task.FromResult(person);
        }

        public async Task<List<Person>> GetAllAsync()
        {
            if (!_people.Any())
                throw new Exceptions.EmptyDataException("There is no data");

            return await Task.FromResult(_people);
        }

    }
}
