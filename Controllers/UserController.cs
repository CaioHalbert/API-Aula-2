using API_Aula_2.Data;
using API_Aula_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Aula_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        [HttpGet]
        public IEnumerable<User> getAll()
        {
            return _context.Users.ToList();
        }
        [HttpPost]
        public void Add([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        [HttpPut]
        public void Update(User entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        [HttpDelete]
        public void Delete(User entity) 
        {
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }
        [HttpGet("/{id}")]
        public User GetById(int id)
        {
            var user = _context.Users.Find(id);
            
            return Ok();
        }
    }
}
