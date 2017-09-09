using System;
using System.Collections.Generic;
using LokateApi.DTO;
using Neo4jClient;

namespace LokateApi.DAL
{
    public class VenuesRepository : GraphRepository, IVenuesRepository
    {
        public VenuesRepository(IGraphClient graphClient) : base(graphClient)
        {
        }

        public void DeleteVenue(int venueId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public Venue GetVenueById(int venueId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Venue> GetVenues()
        {
            return GraphClient.Cypher
                .Match("(venue:Venue)")
                .Return(venue => venue.As<Venue>())
                .Results;
        }

        public void InsertVenue(Venue venue)
        {
            GraphClient.Cypher
                .Create("(n:Venue {venue})")
                .WithParams(new { venue })
                .ExecuteWithoutResults();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateVenue(Venue venue)
        {
            throw new NotImplementedException();
        }
    }
}
