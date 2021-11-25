using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeepNote.Models;

namespace DeepNote.Controllers
{
    public class NoteController
    {
        public Note note;
        public ObservableCollection<Note> Notes = new ObservableCollection<Note>();

        public NoteController()
        {
            AddTestNotes();
        }

        public void SaveNote(Note note)
        {
            Notes.Add(note);
        }

        /// <summary>
        /// Busca y devuelve todas las notas de un usuario dado
        /// </summary>
        /// <param name="user"></param>
        /// <returns><see cref="List{T}"/>UserNotes</returns>
        public List<Note> GetNotesFromUser(User user)
        {
            // Lista donde se guarda las notas de un usuario en concreto
            List<Note> UserNotes = new List<Note>();

            // Buscamos en todas las notas si el nombre de usuario coincide con el usuario dado.
            foreach (Note note in Notes)
            {
                if (note.User.Username.Equals(user.Username))
                {
                    UserNotes.Add(note);
                }
            }

            return UserNotes;
        }

        /// <summary>
        /// MOdifica una nota dada la posicion de esta
        /// </summary>
        /// <param name="note"></param>
        /// <param name="pos"></param>
        public void UpdateNote(Note note, int pos)
        {
            Notes[pos] = note;
        }

        private void AddTestNotes()
        {
            // Usuarios de prueba
            User u1 = new User("juan", "juan@localhost", "juan");
            User u2 = new User("jose", "jose@gmail.xyz", "jose");

            // Notas de prueba
            Notes.Add(new Note(u1, "Nota usuario 1-1"));
            Notes.Add(new Note(u1, "Nota usuario 1-2"));
            Notes.Add(new Note(u2, "Nota usuario 2", "Esta es la nota del usuario 2"));
            Notes.Add(new Note(u1, "Nota usuario 1-3"));
        }

    }
}
