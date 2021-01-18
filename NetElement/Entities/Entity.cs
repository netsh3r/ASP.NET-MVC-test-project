using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities
{
	/// <summary>
	/// Основная сущность
	/// </summary>
	public class Entity : BaseEntity
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		[Key]
		public override int Id { get; set; }
	}
}
