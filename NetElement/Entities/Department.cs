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
	[Table("Department")]
	public class Department : Entity, IDepartment
	{
		//</inheritdoc>
		public string Name { get; set; }
		//</inheritdoc>
		public int Level { get; set; }
		//</inheritdoc>
		public virtual ICollection<Employee> Employes { get; set; }
		public Department()
		{
			Employes = new List<Employee>();
		}
	}
}
