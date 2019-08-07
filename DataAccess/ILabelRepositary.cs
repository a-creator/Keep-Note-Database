using Entities;
using System.Collections.Generic;

namespace DataAccess
{
    public interface ILabelRepositary
    {
        List<Label> GetLabel();
        int UpdateLabel(Label label);
        int CreatLabel(Label label);
        int RemoveLabel(int LabelId);
    }
}
