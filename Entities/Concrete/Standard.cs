using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Standard:IEntity
    {
        public int StandardId { get; set; }
        public string StandardNo { get; set; }
        public string StandardName { get; set; }
    }
}
