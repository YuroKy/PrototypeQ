using System;
using System.Collections.Generic;
using PrototypeQ.Data.Models;

namespace PrototypeQ.Services.Abstractions.Services
{
	public interface IFilterService
	{
		List<FilterAvailabilityModel> GetAvailableFilters(Type type);
	}
}