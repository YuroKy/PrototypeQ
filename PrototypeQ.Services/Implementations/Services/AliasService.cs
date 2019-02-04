using System;
using System.Collections.Generic;
using System.Linq;
using PrototypeQ.Data.Contexts;
using PrototypeQ.Data.Entities;
using PrototypeQ.Services.Abstractions.Services;

namespace PrototypeQ.Services.Implementations.Services
{
	public class AliasService : IAliasService
	{
		private readonly ApplicationContext _dbContext;

		public AliasService(ApplicationContext dbContext)
		{
			_dbContext = dbContext;
		}

		public AliasEntity Get(int id)
		{
			return _dbContext.Aliases.FirstOrDefault(a => a.Id == id);
		}

		public List<AliasEntity> GetAll()
		{
			return _dbContext.Aliases.ToList();
		}

		public void Create(string name, string[] aliases)
		{
			_dbContext.Aliases.Add(new AliasEntity
			{
				Name = name,
				Alternatives = string.Join(',',aliases)
			});
		}

		public void Delete(int id)
		{
			var alias = _dbContext.Aliases.FirstOrDefault(a => a.Id == id);

			if (alias == null)
			{
				throw new Exception("Not Found");
			}

			_dbContext.Aliases.Remove(alias);
			_dbContext.SaveChanges();
		}

		public void Update(int id, string name, string[] aliases)
		{
			var alias = _dbContext.Aliases.FirstOrDefault(a => a.Id == id);

			if (alias == null)
			{
				throw new Exception("Not Found");
			}

			alias.Name = name;
			alias.Alternatives = string.Join(',', aliases);

			_dbContext.Aliases.Update(alias);
			_dbContext.SaveChanges();
		}

		public void RemoveFromAliases(int id, string alias)
		{
			var aliasEntity = _dbContext.Aliases.FirstOrDefault(a => a.Id == id);

			if (aliasEntity == null)
			{
				throw new Exception("Not Found");
			}

			var alternatives = aliasEntity.Alternatives.Split(',').Where(a => a != alias).ToList();
			aliasEntity.Alternatives = string.Join(',', alternatives);

			_dbContext.Aliases.Update(aliasEntity);
			_dbContext.SaveChanges();
		}

		public void AddToAliases(int id, string alias)
		{
			var aliasEntity = _dbContext.Aliases.FirstOrDefault(a => a.Id == id);

			if (aliasEntity == null)
			{
				throw new Exception("Not Found");
			}

			var alternatives = aliasEntity.Alternatives.Split(',').ToList();
			alternatives.Add(alias);
			aliasEntity.Alternatives = string.Join(',', alternatives);

			_dbContext.Aliases.Update(aliasEntity);
			_dbContext.SaveChanges();
		}
	}
}
