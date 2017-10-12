using System.Collections.Generic;
using System;
using LokateApi.DAL;
using LokateApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace LokateApi.Controllers
{
    [Produces("application/json")]
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly IUsersRepository _repository;

        public UsersController(IUsersRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _repository.GetUsers();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]User value)
        {
            if (value.Guid == Guid.Empty)
            {
                value.Guid = Guid.NewGuid();
            }
            _repository.InsertUser(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            var test = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
