using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PrototypeQ.Data.Enums;
using PrototypeQ.Data.Models;
using PrototypeQ.Services.Abstractions.Services;

namespace PrototypeQ.Services.Implementations.Services
{
	public class FilterService : IFilterService
	{
		private static readonly List<Type> NumberTypes = new List<Type>
		{
			typeof(int),
			typeof(decimal),
			typeof(float),
			typeof(byte),
			typeof(long)
		};

		public List<FilterAvailabilityModel> GetAvailableFilters(Type type)
		{
			return type
				.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
				.Select(field => new FilterAvailabilityModel
				{
					Title = field.Name.Split('>').First().Substring(1),
					AvailableConditionTypes = GetFilterConditionType(field.FieldType),
					AvailableValueTypes = GetAvailableValueTypes(field.FieldType)
				})
				.ToList();
		}

		private List<FilterValueType> GetAvailableValueTypes(Type type)
		{
			var filterValueTypes = new List<FilterValueType>
			{
				FilterValueType.OneValue
			};

			if (NumberTypes.Contains(type))
			{
				filterValueTypes.Add(FilterValueType.Range);
			}

			return filterValueTypes;
		}

		private List<FilterConditionType> GetFilterConditionType(Type type)
		{
			var filterConditionTypes = new List<FilterConditionType>
			{
				FilterConditionType.Equal,
				FilterConditionType.NotEqual,
				FilterConditionType.IsNotNull,
				FilterConditionType.IsNull
			};

			if (NumberTypes.Contains(type))
			{
				filterConditionTypes.Add(FilterConditionType.Greater);
				filterConditionTypes.Add(FilterConditionType.Less);
				filterConditionTypes.Add(FilterConditionType.Between);
			}
			else
			{
				filterConditionTypes.Add(FilterConditionType.In);
				filterConditionTypes.Add(FilterConditionType.NotIn);
			}

			return filterConditionTypes;
		}
	}
}
