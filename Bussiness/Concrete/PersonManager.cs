using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;
        IPositionService _positionService;

        public PersonManager(IPersonDal personDal, IPositionService positionService)
        {
            _personDal = personDal;
            _positionService = positionService;
        }

        [SecuredOperation("person.add,admin")]
        [ValidationAspect(typeof(PersonValidator))]
        [CacheRemoveAspect("IPersonService.Get")]
        public IResult Add(Person person)
        {
            IResult result = BusinessRules.Run(CheckIfPersonIdExists(person.PersonId));

            if (result != null)
            {
                return result;
            }

            _personDal.Add(person);
            return new SuccessResult(Messages.PersonAdded);
        }

        public IDataResult<List<Person>> GetAll()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAll(), Messages.PersonsListed);
        }

        public IDataResult<List<Person>> GetAllByPositionId(int positionId)
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAll(p => p.PositionId == positionId));
        }

        public IDataResult<Person> GetById(int personId)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p => p.PersonId == personId));
        }

        public IDataResult<List<PersonDetailDto>> GetPersonDetails()
        {
            return new SuccessDataResult<List<PersonDetailDto>>(_personDal.GetPersonDetails());
        }

        [ValidationAspect(typeof(PersonValidator))]
        [CacheRemoveAspect("IPersonService.Get")]
        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new SuccessResult(Messages.PersonUpdated);
        }

        
        private IResult CheckIfPersonIdExists(int personId)
        {
            var result = _personDal.GetAll(p => p.PersonId == personId).Any();
            if (result)
            {
                return new ErrorResult(Messages.PersonNameAlreadyExists);
            }
            return new SuccessResult();
        }

    }
}
