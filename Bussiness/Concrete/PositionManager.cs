using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PositionManager : IPositionService
    {

        IPositionDal _positionDal;

        public PositionManager(IPositionDal positionDal)
        {
            _positionDal = positionDal;
        }

        public IDataResult<List<Position>> GetAll()
        {
            return new SuccessDataResult<List<Position>>(_positionDal.GetAll());
        }

        public IDataResult<Position> GetById(int positionId)
        {
            return new SuccessDataResult<Position>(_positionDal.Get(c => c.PositionId == positionId));
        }
    }
}
