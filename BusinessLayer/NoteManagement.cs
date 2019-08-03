using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Exception;
using DataAccess;
using Entities;

namespace BusinessLayer
{
    
   public class NoteManagement : INotemanagement
    {
        private readonly INoteRepositary repositary;
        public NoteManagement(INoteRepositary noteRepositary)
        {
            repositary = noteRepositary;
        }
            public int CreatNote(Note Note)
        {
            var _Note = repositary.GetNoteById(Note.NoteId);
            if(_Note == null)
            {
                return repositary.CreatNote(Note);
            }
            else
            {
                throw new NoteAlreadyExistException($"Note with id {Note.NoteId} already exists");
            }
            
        }

        public List<Note> GetNote()
        {
            return repositary.GetNote();
        }

        public Note GetNoteById(int NoteId)
        {
            var _Note = repositary.GetNoteById(NoteId);
            if (_Note == null)
            {
                throw new NoteAlreadyExistException($"Note with id {NoteId} already exists");
            }
            else
                return _Note;
        }

        public int RemoveNote(int NoteId)
        {
            var _Note = repositary.GetNoteById(NoteId);
            if (_Note == null)
            {
                throw new NoteAlreadyExistException($"Note with id {NoteId} already exists");
            }
            else
                return repositary.RemoveNote(NoteId);
        }

        public int UpdateNote(Note Note)
        {
            var _Note = repositary.GetNoteById(Note.NoteId);
            if (_Note == null)
            {
                throw new NoteAlreadyExistException($"Note with id {Note.NoteId} already exists");
            }
            else
            {
                _Note.Text = Note.Text;
                _Note.Title = Note.Title;
                return repositary.UpdateNote(_Note);
            }
        }
    }
}
