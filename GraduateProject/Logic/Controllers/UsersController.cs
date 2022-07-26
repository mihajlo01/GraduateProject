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
            var users = await user.Find(x => true).ToListAsync();
            return users;
        }

        public async Task<User> ValidateUserLogin(string username, string enteredPassword)
        {
            Initialize();
            var fetchedUser = await user.Find(x => x.Username == username).FirstOrDefaultAsync();

            if (fetchedUser != null)
                if(await passwordInterface.CheckPassword(username, enteredPassword))
                    return fetchedUser;

            return null;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            Initialize();
            var fetchedUser = await user.Find(x => x.Username == username).FirstOrDefaultAsync();

            if (fetchedUser != null)
                return fetchedUser;

            return null;
        }

        public async Task<bool> InsertUser(User userToInsert)
        {
            Initialize();
            if(await GetUserByUsername(userToInsert.Username) == null)
            {
                userToInsert.Password = passwordInterface.CreatePassword(userToInsert.Password);
                await user.InsertOneAsync(userToInsert);

                return true;
            }
            return false;
        }

        public async Task<User> GetUserById(ObjectId id)
        {
            Initialize();
            var fetchedUser = await user.Find(x => x._id == id).FirstOrDefaultAsync();

            if (fetchedUser != null)
                return fetchedUser;

            return null;
        }

        public async Task<ReplaceOneResult> UpdateUser(ObjectId id, User userToUpdate)
        {
            var filter = Builders<User>.Filter.Eq(s => s._id, id);
            var result = await user.ReplaceOneAsync(filter, userToUpdate);

            return result;
        }

        public async Task<bool> DeleteUser(ObjectId id)
        {
            var filter = Builders<User>.Filter.Eq(s => s._id, id);
            if (await user.FindOneAndDeleteAsync(filter) != null)
                return true;
            else
                return false;
        }
    }
}
