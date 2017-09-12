using System;
using System.Collections.Generic;
using LokateApi.DTO;
using Neo4jClient;

namespace LokateApi.DAL
{
    public class UsersRepository : GraphRepository, IUsersRepository
    {
        public UsersRepository(IGraphClient graphClient) : base(graphClient)
        {
        }

        public void DeleteUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public User GetUserById(int UserId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            return GraphClient.Cypher
                .Match("(u:User)")
                .Return(u => u.As<User>())
                .Results;
        }

        public void InsertUser(User user)
        {
            GraphClient.Cypher
                .Create("(u:User {user})")
                .WithParams(new { user })
                .ExecuteWithoutResults();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User User)
        {
            throw new NotImplementedException();
        }
    }
}
