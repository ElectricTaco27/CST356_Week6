using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public PersonController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Person>> GetAllPersons()
        {
            // Person p = new Person();
            // p.FirstName = "Riggs";
            // p.MiddleName = "DeWitt";
            // p.LastName = "Burnam";
            // return Ok(p);

            return Ok(_dbContext.Persons.ToList());
            //return Ok(_dbContext.Person.ToList());
            //return Ok(_dbContext.Person.Include(p => p.PersonId).ToList());
            //return Ok(_dbContext.Person.Include(p => p.Student).ToList());
        }

        [HttpGet("{personId}")]
        public ActionResult<Person> GetPerson(int personId)
        {
            var person = _dbContext.Persons
                .SingleOrDefault(p => p.PersonId == personId);

            if (person != null) {
                return person;
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Person> AddPerson(Person person)
        {
            _dbContext.Persons.Add(person);
            _dbContext.SaveChanges();

            // return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        [HttpDelete("{personId}")]
        public ActionResult DeletePerson(int personId)
        {
            var person = new Person { PersonId = personId };

            _dbContext.Persons.Attach(person);
            _dbContext.Persons.Remove(person);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut("{personId}")]
        public ActionResult UpdatePerson(int personId, Person personUpdate)
        {
            var person = _dbContext.Persons
                .SingleOrDefault(p => p.PersonId == personId);

            if (person != null)
            {
                person.FirstName = personUpdate.FirstName;
                person.MiddleName = personUpdate.MiddleName;
                person.LastName = personUpdate.LastName;

                _dbContext.Update(person);

                _dbContext.SaveChanges();
            }

            return NoContent();
        }
    }
}