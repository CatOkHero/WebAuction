﻿using System;
using System.Collections.Generic;
using DomainModels.Lots;

namespace DomainModels.Guarantee
{
    public class GuaranteeModel
    {
        public GuaranteeModel()
        {
            LotDetailsId = new List<LotDetailsModel>();
        }

        public Guid Id { get; set; }
        public String Condition { get; set; }
        public Int16 GuaranteeLevel { get; set; }
        public virtual ICollection<LotDetailsModel> LotDetailsId { get; set; } 
    }
}
