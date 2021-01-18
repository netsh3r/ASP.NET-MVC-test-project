using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities.Interface
{
	/// <summary>
	/// Сущность язык программирования
	/// </summary>
	interface IProgrammingLanguage :IBaseEntity
	{
		/// <summary>
		/// Название
		/// </summary>
		string Name { get; set; }
		/// <summary>
		/// Связь с сущностью опыт программирования
		/// </summary>
		ICollection<WorkExperience> WorkExperiences  { get; set; }
	}
}
