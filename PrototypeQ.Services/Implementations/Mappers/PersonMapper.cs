using PrototypeQ.Data.Entities;
using PrototypeQ.Data.Models;

namespace PrototypeQ.Services.Implementations.Mappers
{
	public static class PersonMapper
	{
		public static PersonModel ToPersonModel(string[] columns)
		{
			return new PersonModel
			{
				FirstName = columns[0],
				LastName = columns[1],
				Email = columns[2],
				Phone = columns[3],
				Age = int.Parse(columns[4])
			};
		}

		public static PersonModel ToPersonModel(PersonEntity entity)
		{
			return new PersonModel
			{
				FirstName = entity.FirstName,
				LastName = entity.LastName,
				Email = entity.Email,
				Phone = entity.Phone,
				Age = entity.Age
			};
		}

		public static PersonWithIdModel ToPersonWithIdModel(PersonEntity entity)
		{
			return new PersonWithIdModel
			{
				Id = entity.Id,
				FirstName = entity.FirstName,
				LastName = entity.LastName,
				Email = entity.Email,
				Phone = entity.Phone,
				Age = entity.Age
			};
		}

		public static PersonEntity ToPersonEntity(PersonModel model)
		{
			return new PersonEntity
			{
				FirstName = model.FirstName,
				LastName = model.LastName,
				Email = model.Email,
				Phone = model.Phone,
				Age = model.Age
			};
		}
	}
}
