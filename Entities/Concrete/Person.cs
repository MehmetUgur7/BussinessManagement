using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Person:IEntity
    {
        public int PersoneId { get; set; }
        public long IdentityNumber { get; set; }
        public long RegistrationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PositionId { get; set; }
        public long EmailAdress { get; set; }
        public long CellPhone { get; set; }
        public string EmergencyContact { get; set; }
        public long EmergencyNumber { get; set; }

    }
}
