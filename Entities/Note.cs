using Newtonsoft.Json;
using System.Collections.Generic;

namespace Entities
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        [JsonIgnore]
        public virtual ICollection<Label> Labels { get; set; }

         
    }
}
