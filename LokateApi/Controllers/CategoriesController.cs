using System.Collections.Generic;
using System;
using LokateApi.DAL;
using LokateApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace LokateApi.Controllers
{
    [Produces("application/json")]
    [Route("api/categories")]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesRepository _repository;

        public CategoriesController(ICategoriesRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _repository.GetCategories();
        }

        [HttpGet("{id}", Name = "GetCategory")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Category value)
        {
            if(value.Guid == Guid.Empty)
            {
                value.Guid = Guid.NewGuid();
            }
            _repository.InsertCategory(value);
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
