using NetElement.Entities;
using NetElement.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetElement.Manager;

namespace NetElement.Service
{
	//</inheritdoc>
	public sealed class NetElementService : INetElementService
	{
		#region Manager
		private EmployeeManager employeeManager;
		private DepartmentManager departmentManager;
		private ProgrammingLanguageManager programmingLanguageManager;
		private WorkExperienceManager workExperienceManager;
		#endregion

		private static NetElementService _instance;
		public static NetElementService Instance
		{
			get
			{
				return _instance ?? (_instance = new NetElementService());
			}
		}
		//</inheritdoc>
		public NetElementService()
		{
			employeeManager = EmployeeManager.Instance;
			departmentManager = DepartmentManager.Instance;
			programmingLanguageManager = ProgrammingLanguageManager.Instance;
			workExperienceManager = WorkExperienceManager.Instance;
		}
		public WorkExperience GetWorkExperienceByNaturalId(int naturalId)
		{
			return null;
		}

		//</inheritdoc>
		public T GetById<T,IdT>(IdT id) where T:Entity
		{
			return EntityManager<T, IdT>.Instance.FindById(id);
		}
		//</inheritdoc>
		public List<T> GetAll<T, IdT>() where T : Entity
		{
			return EntityManager<T, IdT>.Instance.FindAll();
		}
		//</inheritdoc>
		public void EditEmployee(Employee employee)
		{
			employeeManager.Edit(employee);
		}
		//</inheritdoc>
		public void AddEmployee(Employee employee)
		{
			employeeManager.Add(employee);
		}
		//</inheritdoc>
		public void AddEmployee(Employee employee, string languageId)
		{
			var emp = employeeManager.Add(employee);
			var lang = programmingLanguageManager.FindById(Int32.Parse(languageId));
			var wExp = new WorkExperience()
			{
				Id = emp.Id,
				ProgrammingLanguageId = lang.Id
			};
			workExperienceManager.Add(wExp);
		}
		//</inheritdoc>
		public void DeleteEmployee(int id)
		{
			var emp = new Employee() { Id = id };
			var workExp = new WorkExperience() { Id = id };
			workExperienceManager.Delete(workExp);
			employeeManager.Delete(emp);
		}
	}
}
