using NetElement.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Entities
{
	//</inheritdoc>
	[Table("WorkExperience")]
	public class WorkExperience : Entity, IWorkExperience
	{
		//</inheritdoc>
		[Key]
		[ForeignKey("Employee")]
		public override int Id { get; set; }
		//</inheritdoc>
		public virtual Employee Employee { get; set; }
		//</inheritdoc>
		public int? ProgrammingLanguageId { get; set; }
		public virtual ProgrammingLanguage ProgrammingLanguage { get; set; }
	}
}
