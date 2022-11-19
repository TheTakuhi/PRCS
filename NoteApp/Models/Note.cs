namespace NoteApp.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string NoteDescription { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string NoteState { get; set; }
        public string NoteUserId { get; set; }

        public Note()
        {

        }

    }
}
