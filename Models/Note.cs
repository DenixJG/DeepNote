using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNote.Models
{
    public class Note : INotifyPropertyChanged, IDataErrorInfo, ICloneable
    {
        public User User { get; set; }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Title"));
            }
        }

        private string body;
        public string Body
        {
            get { return body; }
            set
            {
                body = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Body"));
            }
        }

        private bool isCompleted;
        public bool IsCompleted
        {
            get { return isCompleted; }
            set
            {
                isCompleted = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("IsCompleted"));
            }
        }

        private string prioridad;
        public string Prioridad
        {
            get { return prioridad; }
            set
            {
                prioridad = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Prioridad"));
            }
        }
        public DateTime Date { get; set; }

        public string Error { get { return ""; } }

        /// <summary>
        /// Comprueba errores de los inputs de title y body
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public string this[string columnName]
        {
            get
            {
                string res = "";
                if (columnName == "Title")
                {
                    if (string.IsNullOrWhiteSpace(Title))
                    {
                        res = "EL titulo no puede estar vacio";
                    }
                }
                if (columnName == "Body")
                {
                    if (string.IsNullOrWhiteSpace(Body))
                    {
                        res = "El cuerpo de la nota no puede estar vacio";
                    }
                }
                return res;
            }
        }


        /// <summary>
        /// Constructor de la clase <see cref="Note"/>
        /// </summary>
        public Note()
        {
            this.isCompleted = false;
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
            this.title = title;
            this.isCompleted = false;
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
            this.title = title;
            this.body = body;
            this.isCompleted = false;
            this.Date = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Clona el objeto actual
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
