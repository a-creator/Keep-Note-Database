using Entities;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface ILabelManagement
    {
        List<Label> GetLabel();
        int UpdateLabel(Label label);
        int CreatLabel(Label label);
        int RemoveLabel(int LabelId);
    }
}
