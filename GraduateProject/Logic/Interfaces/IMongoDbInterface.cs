using MongoDB.Driver;

namespace GraduateProject.Logic.Interfaces
{
    public interface IMongoDbInterface
    {
        IMongoDatabase Database();
    }
}
