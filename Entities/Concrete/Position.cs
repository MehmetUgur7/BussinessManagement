using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Position:IEntity
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public int PositionPaymentRate { get; set; }
    }
}
