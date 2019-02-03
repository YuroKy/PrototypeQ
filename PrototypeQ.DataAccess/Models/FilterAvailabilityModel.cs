using System.Collections.Generic;
using PrototypeQ.Data.Enums;

namespace PrototypeQ.Data.Models
{
	public class FilterAvailabilityModel
	{
		public string Title { get; set; }
		public List<FilterValueType> AvailableValueTypes { get; set; }
		public List<FilterConditionType> AvailableConditionTypes { get; set; }
	}
}