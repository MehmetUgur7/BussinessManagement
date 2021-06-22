using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class PersonDetailDto
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PositionName { get; set; }
    }
}
