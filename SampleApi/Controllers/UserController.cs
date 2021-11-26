using Microsoft.AspNetCore.Mvc;
using SampleApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static readonly List<User> listUsers = new List<User>()
        { 
            new User() {  Id = 1, FirstName = "Sam Jordan", LastName = "MgGonall", Country = "Canada",
            State = "Vancuver", Email = "emiliano.0218@gmail.com", Password = "asdfqwer" },
            new User() {  Id = 2, FirstName = "Sarah", LastName = "McKensy", Country = "USA",
            State = "Miami", Email = "sarah.McKensy@gmail.com", Password = "asdfgfdgh" },
            new User() {  Id = 3, FirstName = "Andrew", LastName = "Mochenr", Country = "USA",
            State = "Los Angeles", Email = "adrew.Mochenr@gmail.com", Password = "asdfqwer" },
            new User() {  Id = 4, FirstName = "Mathew", LastName = "Suolivan", Country = "Canada",
            State = "Otawa", Email = "mathew.Suolivan@gmail.com", Password = "asdfqwer" },
            new User() {  Id = 5, FirstName = "Jennifer", LastName = "McLos", Country = "Canada",
            State = "Vancuver", Email = "Jennifer.maclos@gmail.com", Password = "asdfqwer" },
        };

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {  
            return listUsers;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var res = listUsers.Find(x => x.Id == id);
            return res;
        }

        // POST api/<UserController>
        [HttpPost]
        public long Post([FromBody] User user)
        {
            Random rnd = new Random();
            user.Id = rnd.Next(1, 10000);
            listUsers.Add(user);
            return user.Id;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listUsers.Remove(Get(id));
        }
    }
}
