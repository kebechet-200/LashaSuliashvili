using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonService;
using PersonService.Abstractions;
using Practice_1.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonsService _personService;

        public PersonsController(IPersonsService personsService)
        {
            _personService = personsService;
        }

        [HttpGet("{personalNumber}")]
        public async Task<IActionResult> GetPersonAsync(string personalNumber)
        {
            var person = await _personService.GetAsync(personalNumber);

            var personDTO = person.Adapt<GetPersonDTO>();

            return Ok(personDTO);

        }

        [HttpGet]
        public async Task<List<GetPersonDTO>> GetAllPersonAsync()
        {
            var person = await _personService.GetAllAsync();

            var personDTO = person.Adapt<List<GetPersonDTO>>();

            return personDTO;
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson([FromBody] CreatePersonDTO person)
        {
            var mappingPerson = person.Adapt<Person>();

            await _personService.AddAsync(mappingPerson);

            return Ok();
        }
    }
}
