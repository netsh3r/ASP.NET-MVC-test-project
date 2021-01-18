using NetElement.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities.Context
{
	/// <summary>
	/// Инициализировать бд
	/// </summary>
	public class NetElementContextInitializer : CreateDatabaseIfNotExists<NetElementContext>
	{
		protected override void Seed(NetElementContext db)
		{
			List<Department> departments = new List<Department>()
			{
				new Department(){ Id=1, Level = 1, Name = "Тестирование"},
				new Department(){ Id=2, Level = 2, Name = "Внедрение"},
				new Department(){ Id=3, Level = 3, Name = "Проектный офис"}
			};

			List<ProgrammingLanguage> pLangs = new List<ProgrammingLanguage>()
			{
				new ProgrammingLanguage() { Id=1, Name = "Java" },
				new ProgrammingLanguage() { Id=2, Name = "Java Script" },
				new ProgrammingLanguage() { Id=3, Name = ".Net" },
				new ProgrammingLanguage() { Id=4, Name = "Python" },
				new ProgrammingLanguage() { Id=5, Name = "Sql" }
			};
			
			db.Languages.AddRange(pLangs);
			
			db.SaveChanges();
			db.Departments.AddRange(departments);
			db.SaveChanges();
		}
	}
}
