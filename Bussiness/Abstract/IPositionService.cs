using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IPositionService
    {
        IDataResult<List<Position>> GetAll();
        IDataResult<Position> GetById(int categoryId);
    }
}
