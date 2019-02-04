using System.Linq;
using System.Reflection;

namespace PrototypeQ.Services.Implementations.Extensions
{
	public static class FieldExtension
	{
		public static string GetFieldName(this FieldInfo fieldInfo)
		{
			return fieldInfo.Name.Split('>').First().Substring(1);
		}
	}
}
