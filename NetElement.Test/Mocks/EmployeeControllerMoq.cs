using NetElement.Service;
using NetElement.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Test.Mocks
{
	public class EmployeeControllerMoq : EmployeeController
	{
		public override INetElementService NetElementService { get; set; }
	}
}
