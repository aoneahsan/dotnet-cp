using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  // {domain}/api/users
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser?> GetUser(int id)
        {
            return _context.Users.Find(id);
        }

        [HttpPost]
        public ActionResult<bool> CreateUser()
        {
            try
            {
                _context.Users.Add(new AppUser("ahsan"));

                _context.SaveChanges();

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}