using Bussiness.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class PersonManager : IPersonService
    {
        public IResult Add(Person person)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Person>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Person>> GetAllByPositionId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Person> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
