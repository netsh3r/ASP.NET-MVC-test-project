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
	/// Менеджер отдел
	/// </summary>
	internal sealed class DepartmentManager : EntityManager<Department,int>
	{
		private static DepartmentManager _instance;
		public static DepartmentManager Instance
		{
			get
			{
				return _instance ?? (_instance = new DepartmentManager());
			}
		}
	}
}
