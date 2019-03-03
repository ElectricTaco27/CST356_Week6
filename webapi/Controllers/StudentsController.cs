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
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return Ok(_dbContext.Students.ToList());
            //return Ok(_dbContext.Student.Include(s => s.StudentId).ToList());
            //return Ok(_dbContext.Student.Include(s => s.Person).ToList());
        }

        [HttpGet("{studentId}")]
        public ActionResult<Student> GetStudent(int studentId)
        {
            var student = _dbContext.Students
                .SingleOrDefault(s => s.StudentId == studentId);

            if (student != null) {
                return student;
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Student> AddStudent(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();

            // return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        [HttpDelete("{studentId}")]
        public ActionResult DeleteStudent(int studentId)
        {
            var student = new Student { StudentId = studentId };

            _dbContext.Students.Attach(student);
            _dbContext.Students.Remove(student);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut("{studentId}")]
        public ActionResult UpdateStudent(int studentId, Student studentUpdate)
        {
            var student = _dbContext.Students
                .SingleOrDefault(s => s.StudentId == studentId);

            if (student != null)
            {
                student.Email = studentUpdate.Email;

                _dbContext.Update(student);

                _dbContext.SaveChanges();
            }

            return NoContent();
        }
    }
}