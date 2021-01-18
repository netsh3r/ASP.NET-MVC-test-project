using NetElement.Attributes;
using NetElement.Entities;
using NetElement.Entities.Context;
using NetElement.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Context
{
	/// <summary>
	/// Контекст данных сотрудников
	/// </summary>
	public class NetElementContext : DbContext
	{
		static NetElementContext()
		{
			Database.SetInitializer<NetElementContext>(new NetElementContextInitializer());
		}
		public NetElementContext() : base("NetElementDB")
		{
		}
		/// <summary>
		/// Пользователи
		/// </summary>
		public DbSet<Employee> Employes { get; set; }
		/// <summary>
		/// Отделы
		/// </summary>
		public DbSet<Department> Departments { get; set; }
		/// <summary>
		/// Языки
		/// </summary>
		public DbSet<ProgrammingLanguage> Languages { get; set; }
		/// <summary>
		/// Опыт работы
		/// </summary>
		public DbSet<WorkExperience> WorkExperiences { get; set; }
	}
}
