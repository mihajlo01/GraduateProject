using GraduateProject.Logic.Interfaces;
using GraduateProject.Models;
using GraduateProject.Repository.Controllers;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject.Logic.Controllers
{
    public class UsersController: IUsersInterface
    {
        IMongoDbInterface mongoInterface;
        IPasswordInterface passwordInterface;
        IMongoCollection<User> user;
        IMongoDatabase database;

        public void Initialize()
        {
            mongoInterface = new MongoDbController();
            passwordInterface = new PasswordController();
            database = mongoInterface.Database();
            user = database.GetCollection<User>("User");
        }

        public async Task<List<User>> GetAllUsers()
        {
            Initialize();
            var users = user.AsQueryable();
            return users.ToList();
        }

        public async Task<User> ValidateUserLogin(string username, string enteredPassword)
        {
            Initialize();
            var fetchedUser = user.AsQueryable().Where(x => x.Username == username);

            if (fetchedUser != null)
                if(await passwordInterface.CheckPassword(username, enteredPassword))
                    return fetchedUser.FirstOrDefault();

            return null;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            Initialize();
            var fetchedUser = user.AsQueryable().Where(x => x.Username == username);

            if (fetchedUser != null)
                return fetchedUser.FirstOrDefault();

            return null;
        }

        public async Task<bool> InsertUser(User userToInsert)
        {
            Initialize();
            if(await GetUserByUsername(userToInsert.Username) == null)
            {
                userToInsert.Password = await passwordInterface.CreatePassword(userToInsert.Password);
                await user.InsertOneAsync(userToInsert);

                return true;
            }
            return false;
        }

        public async Task<User> GetUserById(ObjectId id)
        {
            Initialize();
            var fetchedUser = user.AsQueryable().Where(x => x._id == id);

            if (fetchedUser != null)
                return fetchedUser.FirstOrDefault();

            return null;
        }

        public async Task<ReplaceOneResult> UpdateUser(ObjectId id, User userToUpdate)
        {
            var filter = Builders<User>.Filter.Eq(s => s._id, id);
            var result = await user.ReplaceOneAsync(filter, userToUpdate);

            return result;
        }
    }
}
