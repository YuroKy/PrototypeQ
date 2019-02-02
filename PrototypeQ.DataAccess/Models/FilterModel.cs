using PrototypeQ.Data.Enums;

namespace PrototypeQ.Data.Models
{
	public class FilterModel
	{
		public string Title { get; set; }
		public FilterValueType ValueType { get; set; }
		public FilterConditionType ConditionType { get; set; }
	}
}
