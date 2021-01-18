using NetElement.Context;
using NetElement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Manager
{
	/// <summary>
	/// Менеджер сущности язык программирования
	/// </summary>
	internal sealed class ProgrammingLanguageManager : EntityManager<ProgrammingLanguage,int>
	{
		private static ProgrammingLanguageManager _instance;
		public static ProgrammingLanguageManager Instance
		{
			get
			{
				return _instance ?? (_instance = new ProgrammingLanguageManager());
			}
		}
	}
}
