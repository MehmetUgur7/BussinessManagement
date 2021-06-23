using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryPersonDal : IPersonDal
    {
        List<Person> _persons;
        public InMemoryPersonDal()
        {
            //Oracle, Sql Server, Postgres, MongoDb
            _persons = new List<Person> {
                new Person{PersonId=1,PositionId=1,FirstName="Mehmet", LastName="Uğur", IdentityNumber=12345},
                new Person{PersonId=2,PositionId=2,FirstName="Gökhan", LastName="Kerman", IdentityNumber=125693},
                new Person{PersonId=3,PositionId=3,FirstName="Çiğdem", LastName="Karadağ", IdentityNumber=5699872},
                new Person{PersonId=4,PositionId=4,FirstName="Rukiye", LastName="Yiğit", IdentityNumber=54544565},
                new Person{PersonId=5,PositionId=5,FirstName="Rüstem", LastName="Bütün", IdentityNumber=989875521}
            };
        }
        public void Add(Person person)
        {
            _persons.Add(person);
        }

        public void Delete(Person person)
        {
            Person personToDelete = _persons.SingleOrDefault(p=>p.PersonId==person.PersonId);
            _persons.Remove(personToDelete);
        }

        public Person Get(Expression<Func<Person, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return _persons;
        }

        public List<Person> GetAll(Expression<Func<Person, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAllByPosition(int positionId)
        {
            return _persons.Where(p => p.PositionId == positionId).ToList();
        }

        public List<PersonDetailDto> GetPersonDetails()
        {
            throw new NotImplementedException();
        }


        public void Update(Person person)
        {
            //Gönderdiğim ürün id sine sahip olan listedeki ürünü bul demek
            Person personToUpdate = _persons.SingleOrDefault(p => p.PersonId == person.PersonId);
            personToUpdate.FirstName = person.FirstName;
            personToUpdate.LastName = person.LastName;
            personToUpdate.PositionId = person.PositionId;
            personToUpdate.IdentityNumber = person.IdentityNumber;
            personToUpdate.RegistrationNumber = person.RegistrationNumber;


        }
    }
}
