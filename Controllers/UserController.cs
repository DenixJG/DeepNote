using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeepNote.Models;

namespace DeepNote.Controllers
{
    public class UserController
    {
        public User user { get; set; }
        private static List<User> Users = new List<User>();

        public UserController()
        {
            AddTestUsers();
        }

        /// <summary>
        /// Add a new user In-Memory list.
        /// </summary>
        /// <param name="user"></param>
        public bool SaveUser(User user)
        {
            if (!Users.Contains(user))
            {
                Users.Add(user);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Find user In-Memory list by the Username
        /// </summary>
        /// <param name="user"></param>
        /// <returns><see cref="User"/> if exist or <c>null</c> if not </returns>
        public User FindUser(User user)
        {
            return Users.Find(u => u.Username == user.Username);
        }

        public User FindUserByUsername(string username)
        {
            return Users.Find(u => u.Username == username);
        }

        private void AddTestUsers()
        {
            Users.Add(new User("juan", "juan@gmail.xyz", "juan"));
            Users.Add(new User("pedro", "pedro@gmail.xyz", "pedro"));
            Users.Add(new User("jose", "jose@gmail.xyz", "jose"));
        }
    }
}
