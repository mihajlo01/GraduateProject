using System.Threading.Tasks;

namespace GraduateProject.Logic.Interfaces
{
    public interface IPasswordInterface
    {
        string CreatePassword(string password);
        Task<bool> CheckPassword(string username, string password);
    }
}
