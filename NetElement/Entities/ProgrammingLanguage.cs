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
	[Table("ProgrammingLanguage")]
	public class ProgrammingLanguage : Entity, IProgrammingLanguage
	{
		//</inheritdoc>
		public string Name { get; set; }
		//</inheritdoc>
		public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
	}
}
