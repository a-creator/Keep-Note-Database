using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class LabelRepositary : ILabelRepositary
    {
        private readonly NoteDbContext context;
        public LabelRepositary(NoteDbContext labelDbContext)
        {
            context = labelDbContext;
        }
        public int CreatLabel(Label label)
        {
            context.Labels.Add(label);
            return context.SaveChanges();
        }

        public List<Label> GetLabel()
        {
            return context.Labels.ToList();
        }

        public int RemoveLabel(int LabelId)
        {
            var label = context.Labels.Find(LabelId);
            context.Labels.Remove(label);
            return context.SaveChanges();
        }

        public int UpdateLabel(Label label)
        {
            context.Entry<Label>(label).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return context.SaveChanges();
        }
    }
}
