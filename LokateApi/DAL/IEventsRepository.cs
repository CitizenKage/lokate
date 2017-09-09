using System;
using System.Collections.Generic;
using LokateApi.DTO;

namespace LokateApi.DAL
{
    public interface IEventsRepository : IDisposable
    {
        IEnumerable<Event> GetEvents();
        Event GetEventById(int eventId);
        void InsertEvent(Event student);
        void DeleteEvent(int eventId);
        void UpdateEvent(Event student);
        void Save();
    }
}
