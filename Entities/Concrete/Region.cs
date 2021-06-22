﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Region:IEntity
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public int RegionPaymentRate { get; set; }

    }
}
