using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class StandardAttribute:IEntity
    {
        public int StandardAttributeId { get; set; }
        public int StandardId { get; set; }
        public string StandardNo { get; set; }
        public string StandardName { get; set; }
        public int PersonId { get; set; }
    }
}
