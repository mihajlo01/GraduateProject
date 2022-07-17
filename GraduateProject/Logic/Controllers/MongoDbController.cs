using GraduateProject.Logic.Interfaces;
using GraduateProject.Models;
using MongoDB.Driver;
using NPOI.SS.Formula.Functions;
using System.Collections.Generic;
using System.Configuration;

namespace GraduateProject.Repository.Controllers
{
    public class MongoDbController: IMongoDbInterface
    {
        MongoClient client;
        IMongoDatabase database;

        public IMongoDatabase Database()
        {
            string connectionString = "mongodb://localhost:27017";
            client = new MongoClient(connectionString);
            database = client.GetDatabase("Graduate");
            return database;
        }
    }
}
