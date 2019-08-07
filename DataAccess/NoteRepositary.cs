using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class NoteRepositary : INoteRepositary
    {
        private readonly NoteDbContext context;
        public NoteRepositary(NoteDbContext noteDbContext)
        {
            context = noteDbContext;
        }
        public int CreatNote(Note Note)
        {
            context.Notes.Add(Note);
            return context.SaveChanges();
        }
        public List<Note> GetNote()
        {
            return context.Notes.ToList();
        }
       public Note GetNoteById(int NoteId)
        {
            return context.Notes.Find(NoteId);
        }
        public int RemoveNote(int NoteId)
        {
            var Note = context.Notes.Find(NoteId);
            context.Notes.Remove(Note);
            return context.SaveChanges();
        }
        public int UpdateNote(Note Note)
        {
            context.Entry<Note>(Note).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return context.SaveChanges();
        }
    }
}