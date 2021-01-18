using NetElement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Manager
{
	/// <summary>
	/// Базовый класс мэнеджеров сущностей
	/// </summary>
	/// <typeparam name="T"></typeparam>
	interface IBaseEntityManager<T,IdT> where T:Entity
	{
		/// <summary>
		/// Удалить сотрудника по идентификатору
		/// </summary>
		/// <param name="id"></param>
		void Delete(IdT id);
		/// <summary>
		/// Найти по идентификатору 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		T FindById(IdT id);
		/// <summary>
		/// Отредактировать имеющуюся запись
		/// </summary>
		/// <param name="entityModel"></param>
		void Edit(T entityModel);
		/// <summary>
		/// Найти все записи в бд
		/// </summary>
		/// <returns></returns>
		List<T> FindAll();
		/// <summary>
		/// Добавить запись в бд
		/// </summary>
		/// <param name="model"></param>
		T Add(T model);
		/// <summary>
		/// Удалить запись из бд
		/// </summary>
		/// <param name="id"></param>
		void Delete(T model);
	}
}
