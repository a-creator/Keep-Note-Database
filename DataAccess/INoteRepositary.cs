using Entities;
using System.Collections.Generic;

namespace DataAccess
{
    public interface INoteRepositary
    {
        Note GetNoteById(int NoteId);
        List<Note> GetNote();
        int UpdateNote(Note Note);
        int CreatNote(Note Note);
        int RemoveNote(int NoteId);
    }
}
