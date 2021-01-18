using NetElement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetElement.Web.Models
{
	/// <summary>
	/// Модель для создания\редактирования сотрудника
	/// </summary>
	interface IEmployeeModel
	{
		/// <summary>
		/// Сотрудник
		/// </summary>
		Employee Employee { get; set; }

	}
}