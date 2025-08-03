using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    public class User
    {
        public string UserName { get; }
        public byte[] PasswordHash { get; }
        public byte[] PasswordSalt { get; }

        public User(string userName, byte[] hash, byte[] salt)
        {
            UserName = userName;
            PasswordHash = hash;
            PasswordSalt = salt;
        }
    }
}
