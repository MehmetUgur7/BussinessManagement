using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonDal : EFEntityRepositoryBase<Person, ManagementContext>, IPersonDal
    {
        public List<PersonDetailDto> GetPersonDetails()
        {
            using (ManagementContext context = new ManagementContext())
            {
                var result = from p in context.Persons
                             join c in context.Positions
                             on p.PositionId equals c.PositionId
                             select new PersonDetailDto
                             {
                                 PersonId = p.PersonId,
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 PositionName = c.PositionName
                             };
                return result.ToList();

            }
        }
    }
}
