using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LokateApi.DTO
{
    public class Venue
    {
        public Guid Guid { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
