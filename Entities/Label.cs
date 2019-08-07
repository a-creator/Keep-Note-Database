using Newtonsoft.Json;

namespace Entities
{
    public  class Label
    {
        public int LabelId { get; set; }
        public string Description { get; set; }
        public int NoteId { get; set; }
        [JsonIgnore]
        public virtual Note note { get; set; }
    }
}
