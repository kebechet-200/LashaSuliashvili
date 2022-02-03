using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonService.Abstractions
{
    public interface IPersonsService
    {
        Task AddAsync(Person person);
        Task<List<Person>> GetAllAsync();
        Task<Person> GetAsync(string personalNumber);
    }
}