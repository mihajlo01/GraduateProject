using GraduateProject.Logic.Interfaces;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GraduateProject.Logic.Controllers
{
    public class PasswordController: IPasswordInterface
    {
        IUsersInterface usersInterface;

        public void Initialize()
        {
            usersInterface = new UsersController();
        }

        public string CreatePassword(string password)
        {
            Initialize();
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }
        public async Task<bool> CheckPassword(string username, string password)
        {
            Initialize();
            var user = await usersInterface.GetUserByUsername(username);

            if (user == null)
                return false;

            byte[] hashBytes = Convert.FromBase64String(user.Password);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;
            return true;
        }
    }
}
