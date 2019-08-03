using Entities;
using System;
using System.Collections.Generic;
using System.Text;

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
