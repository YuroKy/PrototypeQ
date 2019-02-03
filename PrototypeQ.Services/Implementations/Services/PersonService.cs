using System;
using System.Collections.Generic;
using System.Linq;
using PrototypeQ.Data.Contexts;
using PrototypeQ.Data.Models;
using PrototypeQ.Services.Abstractions.Services;
using PrototypeQ.Services.Implementations.Mappers;

namespace PrototypeQ.Services.Implementations.Services
{
	public class PersonService : IPersonService
	{
		private readonly ApplicationContext _dbContext;

		public PersonService(ApplicationContext dbContext)
		{
			_dbContext = dbContext;
		}

		public List<PersonWithIdModel> GetAll()
		{
			return _dbContext.People
				.Select(PersonMapper.ToPersonWithIdModel)
				.ToList();
		}

		public List<PersonWithIdModel> GetByFilters(List<FilterModel> filters)
		{
			throw new System.NotImplementedException();
		}

		public void Create(PersonModel model)
		{
			_dbContext.People.Add(PersonMapper.ToPersonEntity(model));
		}

		public void Delete(int id)
		{
			var person = _dbContext.People.FirstOrDefault(p => p.Id == id);
			if (person == null)
			{
				throw new Exception("Incorrect person id, please try again with correct id");
			}

			_dbContext.People.Remove(person);
			_dbContext.SaveChanges();
		}
	}
}