using System.Collections.Generic;
using LokateApi.DAL;
using LokateApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace LokateApi.Controllers
{
    [Produces("application/json")]
    [Route("api/venues")]
    public class VenuesController : Controller
    {
        private readonly IVenuesRepository _repository;

        public VenuesController(IVenuesRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Venue> Get()
        {
            return _repository.GetVenues();
        }

        [HttpGet("{id}", Name = "GetVenue")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Venue value)
        {
            _repository.InsertVenue(value);
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
