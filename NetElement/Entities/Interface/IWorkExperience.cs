using NetElement.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities.Interface
{
	/// <summary>
	/// Сущность опыт работы
	/// </summary>
	interface IWorkExperience : IBaseEntity
	{
		/// <summary>
		/// Сотрудник
		/// </summary>
		Employee Employee { get; set; }
		/// <summary>
		/// Язык программирования
		/// </summary>
		int? ProgrammingLanguageId { get; set; }
	}
}
