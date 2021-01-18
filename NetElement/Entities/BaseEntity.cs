using NetElement.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities
{
	//</inheritdoc>
	public abstract class BaseEntity : IBaseEntity
	{
		//</inheritdoc>
		public abstract int Id { get; set; }
	}
}
