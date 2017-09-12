using System;
using System.Collections.Generic;
using LokateApi.DTO;
using Neo4jClient;

namespace LokateApi.DAL
{
    public class GenresRepository : GraphRepository, IGenresRepository
    {
        public GenresRepository(IGraphClient graphClient) : base(graphClient)
        {
        }

        public void DeleteGenre(int genreId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public Genre GetGenreById(int genreId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetGenres()
        {
            return GraphClient.Cypher
                .Match("(g:Genre)")
                .Return(genre => genre.As<Genre>())
                .Results;
        }

        public void InsertGenre(Genre genre)
        {
            GraphClient.Cypher
                .Create("(g:Genre {genre})")
                .WithParams(new { genre })
                .ExecuteWithoutResults();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateGenre(Genre genre)
        {
            throw new NotImplementedException();
        }
    }
}
