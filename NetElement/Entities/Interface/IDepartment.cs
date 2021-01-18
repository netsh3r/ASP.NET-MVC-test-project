using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities.Interface
{
	/// <summary>
	/// Сущность отдел
	/// </summary>
	interface IDepartment : IBaseEntity
	{
		/// <summary>
		/// Название отдела
		/// </summary>
		string Name { get; set; }
		/// <summary>
		/// Этаж
		/// </summary>
		int Level { get; set; }
		/// <summary>
		/// Связь с сущностями сотрудники
		/// </summary>
		ICollection<Employee> Employes { get; set; }
	}
}
