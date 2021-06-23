using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonService
    {
        IDataResult<List<Person>> GetAll();
        IDataResult<List<Person>> GetAllByPositionId(int positionId);

        IDataResult<List<PersonDetailDto>> GetPersonDetails();
        IDataResult<Person> GetById(int personId);
        IResult Add(Person person);
        IResult Update(Person person);
        //IResult AddTransactionalTest(Person person);

    }
}
