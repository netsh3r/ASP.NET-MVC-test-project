using NetElement.Entities;
using NetElement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Test.Mocks
{
	internal class NetElementServiceMoq : INetElementService
	{
		public void AddEmployee(Employee employee)
		{
			
		}

		public void AddEmployee(Employee employee, string languageId)
		{
			
		}

		public void DeleteEmployee(int id)
		{
			
		}

		public void EditEmployee(Employee employee)
		{
			
		}

		public List<T> GetAll<T, IdT>() where T : Entity
		{
			return null;
		}

		public T GetById<T, IdT>(IdT id) where T : Entity
		{
			return null;
		}

		public WorkExperience GetWorkExperienceByNaturalId(int naturalId)
		{
			return null;
		}
	}
}
