using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNote.Models
{
    public class User : IDataErrorInfo
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Error { get { return ""; } }

        public User()
        {
        }

        /// <summary>
        /// Constructor de la clase <see cref="User"/>
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public User(string username, string email, string password)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }


        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Username")
                {
                    if (string.IsNullOrWhiteSpace(Username))
                    {
                        result = "EL usuario está vacio.";
                    }
                }
                if (columnName == "Password")
                {
                    if (string.IsNullOrWhiteSpace(Password))
                    {
                        result = "La contraseña no puede estar vacia";
                    }
                }

                return result;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Username == user.Username &&
                   Password == user.Password;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
