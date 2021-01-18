using NetElement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetElement.Web.Models
{
	public class AddEmployeeModel : EntitiesDataModel
	{
		public Employee Employee {get; set;}
		//</inheritdoc>
		public string DepratmentId { get; set; }
		//</inheritdoc>
		public string LanguageId { get; set; }
	}
}