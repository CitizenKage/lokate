using System;
using System.Collections.Generic;
using LokateApi.DTO;

namespace LokateApi.DAL
{
    public interface IGenresRepository : IDisposable
    {
        IEnumerable<Genre> GetGenres();
        Genre GetGenreById(int GenreId);
        void InsertGenre(Genre student);
        void DeleteGenre(int GenreId);
        void UpdateGenre(Genre student);
        void Save();
    }
}
