using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
   public interface INotemanagement
    {
        Note GetNoteById(int NoteId);
        List<Note> GetNote();
        int UpdateNote(Note Note);
        int CreatNote(Note Note);
        int RemoveNote(int NoteId);
    }
}
