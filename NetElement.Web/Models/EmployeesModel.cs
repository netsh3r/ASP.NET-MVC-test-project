using NetElement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetElement.Web.Models
{
	//</inheritdoc>
	public class EmployeesModel : EntitiesDataModel
	{
		
		//</inheritdoc>
		public List<Employee> Employees { get; set; }
	}
}