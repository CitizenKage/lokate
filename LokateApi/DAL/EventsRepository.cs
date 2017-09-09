using System;
using System.Collections.Generic;
using System.Linq;
using LokateApi.DAL;
using LokateApi.DTO;
using Neo4jClient;

namespace LokateApi.DAL
{
    public class EventsRepository : GraphRepository, IEventsRepository
    {
        public EventsRepository(IGraphClient graphClient) : base(graphClient)
        {
        }

        public void Dispose()
        {
        }

        public IEnumerable<Event> GetEvents()
        {
            var query = GraphClient.Cypher
                .Match("(ev:Event)-[:HELD_AT]->(venue:Venue)")
                .OptionalMatch("(ev)-[:IS_OF_GENRE *1..4]->(tag:Tag)")
                .Return((ev, venue, tag) => new
                {
                    Event = ev.As<Event>(),
                    Venue = venue.As<Venue>(),
                    Tags = tag.CollectAsDistinct<Tag>()
                });


            var result = query.Results.ToList();

            result.ForEach(x =>
            {
                if (x?.Venue != null)
                {
                    x.Event.Venue = x.Venue;
                }
                if (x?.Tags != null)
                {
                    x.Event.Tags = x.Tags;
                }
            });
            return result.Select(x => x.Event);
        }

        public Event GetEventById(int eventId)
        {
            throw new System.NotImplementedException();
        }

        public void InsertEvent(Event ev)
        {
            //TODO: Add validation here
            if (ev.Venue?.Guid == null)
            {
                throw new ArgumentException();
            }

            var eventId = Guid.NewGuid();

            GraphClient.Cypher
                    .Match("(v:Venue {Guid:{venueGuid}})")
                    .WithParam("venueGuid", ev.Venue.Guid)
                    .Merge("(e:Event {Guid: {ev}.Guid})-[:HELD_AT]->(v)")
                    .Set("e.Name= {evName}, e.StartDate= {evStartDate}, e.EndDate= {evEndDate}, e.ImageUrl= {evImageUrl}")
                    .WithParams(new
                    {
                        evGuid = eventId,
                        evName = ev.Name,
                        evStartDate = ev.StartDate,
                        evEndDate = ev.EndDate,
                        evImageUrl = ev.ImageUrl
                    })
                    .ExecuteWithoutResults();
        }

        public void DeleteEvent(int eventId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEvent(Event ev)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
