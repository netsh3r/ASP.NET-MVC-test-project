using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities.Interface
{
	/// <summary>
	/// Сущность сотрудник
	/// </summary>
	interface IEmployee : IBaseEntity
	{
		/// <summary>
		/// Имя
		/// </summary>
		string Name { get; set; }
		/// <summary>
		/// Фамилия
		/// </summary>
		string LastName { get; set; }
		/// <summary>
		/// Возраст
		/// </summary>
		int Age { get; set; }
		/// <summary>
		/// Отдел
		/// </summary>
		int? DepartmentId { get; set; }
		/// <summary>
		/// Сущность Отдел
		/// </summary>
		Department Department { get; set; }
		/// <summary>
		/// Связь с сущностью опыт работы
		/// </summary>
		WorkExperience WorkExperience { get; set; }
	}
}
