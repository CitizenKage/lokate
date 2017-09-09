using System;
using System.Collections.Generic;
using LokateApi.DTO;

namespace LokateApi.DAL
{
    public interface IVenuesRepository : IGraphRepository, IDisposable
    {
        IEnumerable<Venue> GetVenues();
        Venue GetVenueById(int venueId);
        void InsertVenue(Venue venue);
        void DeleteVenue(int venueId);
        void UpdateVenue(Venue venue);
        void Save();
    }
}
