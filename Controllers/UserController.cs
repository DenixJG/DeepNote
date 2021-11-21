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
        private User user;
        private List<User> users;

        public UserController()
        {
            this.users = new List<User>();
            AddTestUsers();
        }

        /// <summary>
        /// Add a new user In-Memory list.
        /// </summary>
        /// <param name="user"></param>
        public bool SaveUser(User user)
        {
            if (!users.Contains(user))
            {
                users.Add(user);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Find user In-Memory list by the Username
        /// </summary>
        /// <param name="user"></param>
        /// <returns><see cref="User"/> if exist or <c>null</c> if not </returns>
        public User FindUserByUsername(User user)
        {
            return this.users.Find(u => u.Username == user.Username);
        }

        private void AddTestUsers()
        {
            users.Add(new User("juan", "juan@gmail.xyz", "juan"));
            users.Add(new User("pedro", "pedro@gmail.xyz", "pedro"));
            users.Add(new User("jose", "jose@gmail.xyz", "jose"));
        }
    }
}
