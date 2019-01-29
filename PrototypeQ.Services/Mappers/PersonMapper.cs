using PrototypeQ.DataModel.Models;

namespace PrototypeQ.Services.Mappers
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
	}
}
