using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IPersonService
    {
        IDataResult<List<Person>> GetAll();
        IDataResult<List<Person>> GetAllByPositionId(int id);

        IDataResult<List<PersonDetailDto>> GetProductDetails();
        IDataResult<Person> GetById(int productId);
        IResult Add(Person person);
        IResult Update(Person person);
        //IResult AddTransactionalTest(Person person);

    }
}
