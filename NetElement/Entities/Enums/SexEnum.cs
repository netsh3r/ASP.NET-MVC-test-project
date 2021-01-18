using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities.Enums
{
	public enum Sex
	{
		[Display(Name = "Женщина")]
		Woman = 0,
		[Display(Name = "Мужчина")]
		Man = 1
	}
}
