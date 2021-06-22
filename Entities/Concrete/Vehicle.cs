using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Vehicle:IEntity
    {
        public int VehicleId { get; set; }
        public string PlateNo { get; set; }
        public string BrandName { get; set; }
    }
}
