using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Assignment:IEntity
    {
        public int AssignmentId { get; set; }
        public DateTime Date { get; set; }
        public int RegionId { get; set; }
        public int VehicleId { get; set; }
        public int DriverId { get; set; }
        public int PassengerId { get; set; }
        public int VehicleStartKm { get; set; }
        public int VehicleReturnKm { get; set; }

    }
}
