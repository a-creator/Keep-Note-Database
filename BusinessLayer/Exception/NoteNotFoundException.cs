using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Exception
{
   public class NoteNotFoundException : ApplicationException
    {
        public NoteNotFoundException() { }
        public NoteNotFoundException(string Message) : base(Message) { }
    }
}
