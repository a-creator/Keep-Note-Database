﻿using System;
using System.Collections.Generic;
using Entities;
using BusinessLayer.Exception;
using DataAccess;

namespace BusinessLayer
{
    public class LabelManagement : ILabelManagement
    {
        private readonly ILabelRepositary repositary;
        public LabelManagement(ILabelRepositary labelRepositary)
        {
            repositary = labelRepositary;
        }
        public int CreatLabel(Label label)
        {
            return repositary.CreatLabel(label);
        }

        public List<Label> GetLabel()
        {
            return repositary.GetLabel();
        }

        public int RemoveLabel(int LabelId)
        {
           return repositary.RemoveLabel(LabelId) ;
        }

        public int UpdateLabel(Label label)
        {
            return repositary.UpdateLabel(label);
        }
    }
}
