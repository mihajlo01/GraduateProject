using GraduateProject.Repository.Controllers;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject.Logic.Interfaces
{
    public interface IMongoDbInterface
    {
        IMongoDatabase Database();
    }
}
