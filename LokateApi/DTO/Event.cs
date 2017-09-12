using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LokateApi.DTO
{
    public class Event
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public float Price { get; set; }
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
        public Venue Venue { get; set; }
        public string ImageUrl { get; set; }
    }
}
