using NetElement.Context;
using NetElement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Manager
{
	/// <summary>
	/// Менеджер сущности опыт работы
	/// </summary>
	internal sealed class WorkExperienceManager : EntityManager<WorkExperience, int>
	{
		private static WorkExperienceManager _instance;
		public static WorkExperienceManager Instance
		{
			get
			{
				return _instance ?? (_instance = new WorkExperienceManager());
			}
		}
		/// <summary>
		/// Найти опыт работы по физ. лицу
		/// </summary>
		/// <param name="naturalId"></param>
		/// <returns></returns>
		public WorkExperience FindByNaturalId(int naturalId)
		{
			try
			{
				using (var context = new NetElementContext())
				{
					return context.WorkExperiences.FirstOrDefault(t => t.Employee.Id == naturalId);
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return null;
			}
		}
	}
}
