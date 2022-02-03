using Mapster;
using PersonManagement.Data;
using PersonManagement.Domain.POCO;
using PersonManagement.Services.Abstractions;
using PersonManagement.Services.Models;
using PersonManagement.Services.Models.@enum;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonManagement.Services.Implementations
{
    public class PersonService : IPersonService
    {
        #region Private Members

        private IPersonRepository _repo;

        #endregion

        #region Ctor
        public PersonService(IPersonRepository repo)
        {
            _repo = repo;
        }


        //todo: Create გადავაკეთო მთლიან პროექტში ისე, რომ დაბრუნდეს ინფორმაცია იმის შესახებ თუ ასეთი ჩანაწერი უკვე არის 

        #endregion

        #region Public Members
        public async Task<(Status, PersonServiceModel)> GetAsync(int id)
        {
            var result = await _repo.GetAsync(id);

            if (result == null)
                return (Status.NotFound, null);

            return (Status.Success, result.Adapt<PersonServiceModel>());
        }

        public async Task<List<PersonServiceModel>> GetAllAsync()
        {
            var result = await _repo.GetAllAsync();
            return result.Adapt<List<PersonServiceModel>>();
        }

        public async Task<(Status, int)> CreateAsync(PersonServiceModel person)
        {
            var personToInsert = person.Adapt<Person>();

            if (await _repo.Exists(personToInsert.Id))
            {
                return (Status.AlreadyExists, 0);
            }

            try
            {
                var insertedId = await _repo.CreateAsync(personToInsert);
                return (Status.Success, insertedId);
            }
            catch (System.Exception)
            {
                return (Status.InternalServerError, 0);
            }
        }

        public async Task<Status> UpdateAsync(PersonServiceModel person)
        {
            if (!await _repo.Exists(person.Id))
                return Status.NotFound;

            var personToUpdate = person.Adapt<Person>();

            await _repo.UpdateAsync(personToUpdate);

            return Status.Success;
        }

        public async Task<Status> DeleteAsync(int id)
        {
            if (!await _repo.Exists(id))
                return Status.NotFound;

            await _repo.DeleteAsync(id);

            return Status.Success;
        }

        #endregion
    }
}
