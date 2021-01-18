using NetElement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Attributes
{
	public class TypeContextAttribute : System.Attribute
	{
		public Type Type { get; set; }
		public Entity Entity { get; set; }
		public TypeContextAttribute(Type type)
		{
			this.Type = type;
		}
		public TypeContextAttribute(Entity entity)
		{
			this.Entity = entity;
		}
	}
}
