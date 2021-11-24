using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNote.Models
{
    public class Note
    {
        public User User { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsCompleted { get; set; }
        public string Prioridad { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Constructor de la clase <see cref="Note"/>
        /// </summary>
        public Note()
        {
            IsCompleted = false;
            this.Date = DateTime.Now;
        }

        /// <summary>
        /// Constructor de la clase <see cref="Note"/>
        /// </summary>
        /// <param name="user"></param>
        /// <param name="title"></param>
        public Note(User user, string title)
        {
            User = user;
            Title = title;
            IsCompleted = false;
            this.Date = DateTime.Now;
        }

        /// <summary>
        /// Constructor de la clase <see cref="Note"/>
        /// </summary>
        /// <param name="user"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        public Note(User user, string title, string body)
        {
            User = user;
            Title = title;
            Body = body;
            IsCompleted = false;
            this.Date = DateTime.Now;
        }

    }
}
