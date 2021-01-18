using NetElement.Entities.Enums;
using NetElement.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities
{
	//</inheritdoc>
	[Table("Employee")]
	public class Employee : Entity, IEmployee
	{
		//</inheritdoc>
		public string Name { get; set; }
		//</inheritdoc>
		public string LastName { get; set; }
		//</inheritdoc>
		public int Age { get; set; }
		//</inheritdoc>
		public Sex Sex { get; set; }
		//</inheritdoc>
		public int? DepartmentId { get; set; }
		public virtual Department Department { get; set; }
		//</inheritdoc>
		public virtual WorkExperience WorkExperience { get; set; }
	}
}
