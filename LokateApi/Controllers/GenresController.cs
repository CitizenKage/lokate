using System.Collections.Generic;
using LokateApi.DAL;
using LokateApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace LokateApi.Controllers
{
    [Produces("application/json")]
    [Route("api/genres")]
    public class GenresController : Controller
    {
        private readonly IGenresRepository _repository;

        public GenresController(IGenresRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Genre> Get()
        {
            return _repository.GetGenres();
        }

        [HttpGet("{id}", Name = "GetGenre")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Genre value)
        {
            _repository.InsertGenre(value);
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
