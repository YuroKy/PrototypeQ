using System.Collections.Generic;
using PrototypeQ.Data.Entities;

namespace PrototypeQ.Services.Abstractions.Services
{
	public interface IAliasService
	{
		AliasEntity Get(int id);
		List<AliasEntity> GetAll();
		void Create(string name, string[] aliases);
		void Delete(int id);
		void Update(int id, string name, string[] aliases);
		void RemoveFromAliases(int id, string alias);
		void AddToAliases(int id, string alias);
	}
}
