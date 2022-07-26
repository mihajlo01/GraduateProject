using GraduateProject.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraduateProject.Logic.Interfaces
{
    public interface IUsersInterface
    {
        Task<List<User>> GetAllUsers();
        Task<User> ValidateUserLogin(string username, string enteredPassword);
        Task<bool> InsertUser(User userToInsert);
        Task<User> GetUserByUsername(string username);
        Task<User> GetUserById(ObjectId id);
        Task<ReplaceOneResult> UpdateUser(ObjectId id, User userToUpdate);
        Task<bool> DeleteUser(ObjectId id);
    }
}
