using GraduateProject.Logic.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject.Logic.Interfaces
{
    public interface IPasswordInterface
    {
        Task<string> CreatePassword(string password);
        Task<bool> CheckPassword(string username, string password);
    }
}
