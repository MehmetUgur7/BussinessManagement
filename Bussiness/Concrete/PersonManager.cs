using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        

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

        public IDataResult<List<PersonDetailDto>> GetPersonDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
