using NetElement.Entities;
using NetElement.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Test.Mocks
{
	internal class EntityesMoq
	{
		private List<Employee> employees;

		public EntityesMoq()
		{
			employees = new List<Employee>()
			{
				new Employee()
				{
					Id = 1,
					Age = 18,
					DepartmentId = 1,
					Department = new Department()
					{
						Id  = 1,
						Level = 1,
						Name = "Тест"
					},
					LastName = "Иванов",
					Name = "Иван",
					Sex = Sex.Man

				}
			};
		}
	}
}
