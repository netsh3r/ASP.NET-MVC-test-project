using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities.Interface
{
	/// <summary>
	/// Основное интерфейс всех сущностей
	/// </summary>
	interface IBaseEntity
	{
		/// <summary>
		/// Идентификатор сущности
		/// </summary>
		int Id { get; set; }
	}
}
