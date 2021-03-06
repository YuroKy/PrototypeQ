﻿namespace PrototypeQ.Data.Models
{
	public class PersonModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public int Age { get; set; }
	}

	public class PersonWithIdModel : PersonModel
	{
		public int Id { get; set; }
	}
}