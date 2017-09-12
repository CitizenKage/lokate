using System;
using System.Collections.Generic;
using LokateApi.DTO;

namespace LokateApi.DAL
{
    public interface IUsersRepository : IGraphRepository, IDisposable
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int userId);
        void InsertUser(User user);
        void DeleteUser(int userId);
        void UpdateUser(User user);
        void Save();
    }
}
