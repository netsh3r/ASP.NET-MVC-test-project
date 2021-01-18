using NetElement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetElement.Web.Models
{
	public class EntitiesDataModel
	{
		//</inheritdoc>
		public List<Department> Departments { get; set; }
		//</inheritdoc>
		public List<ProgrammingLanguage> Languages { get; set; }
	}
}