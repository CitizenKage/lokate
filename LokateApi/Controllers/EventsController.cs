using System.Collections.Generic;
using LokateApi.DAL;
using LokateApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace LokateApi.Controllers
{
    [Produces("application/json")]
    [Route("api/events")]
    public class EventsController : Controller
    {
        private readonly IEventsRepository _repository;

        public EventsController(IEventsRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _repository.GetEvents();
        }

        [HttpGet("{id}", Name = "GetEvent")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Event value)
        {
            _repository.InsertEvent(value);
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
