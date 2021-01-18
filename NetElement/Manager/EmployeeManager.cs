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
	/// Менеджер сущности сотрудник
	/// </summary>
	internal sealed class EmployeeManager : EntityManager<Employee,int>
	{
		private static EmployeeManager _instance;
		public static EmployeeManager Instance
		{
			get
			{
				return _instance ?? (_instance = new EmployeeManager());
			}
		}
		//</inheritdoc>
		public override void Edit(Employee entityModel)
		{
			try
			{
				using (var context = new NetElementContext())
				{
					context.Entry(entityModel).State = EntityState.Modified;
					context.SaveChanges();
					context.Entry(entityModel.WorkExperience).State = EntityState.Modified;
					context.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
		public override Employee FindById(int id)
		{
			try
			{
				Employee entityModel = null;
				var context = new NetElementContext();
				
				var _dbset = context.Set<Employee>();
				entityModel = _dbset.Find(id);
				
				return entityModel;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return null;
			}
		}
	}
}
