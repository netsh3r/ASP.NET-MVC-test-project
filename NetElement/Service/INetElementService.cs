using NetElement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetElement.Service
{
	/// <summary>
	/// Сервис для взаимодействия с данными бд Net Element
	/// </summary>
	public interface INetElementService
	{
		WorkExperience GetWorkExperienceByNaturalId(int naturalId);
		/// <summary>
		/// Отредактировать сотрудника
		/// </summary>
		/// <param name="employee"></param>
		void EditEmployee(Employee employee);
		/// <summary>
		/// Добавить сотрудника
		/// </summary>
		/// <param name="employee"></param>
		void AddEmployee(Employee employee);
		/// <summary>
		/// Добавить сотрудника
		/// </summary>
		/// <param name="employee"></param>
		/// <param name="languageId"></param>
		void AddEmployee(Employee employee, string languageId);
		/// <summary>
		/// Удалить сотрудника
		/// </summary>
		/// <param name="id"></param>
		void DeleteEmployee(int id);
		/// <summary>
		/// Получить все сущности
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		List<T> GetAll<T,IdT>() where T : Entity;
		/// <summary>
		/// Получить сущность по идентификатору
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="IdT"></typeparam>
		/// <param name="id"></param>
		/// <returns></returns>
		T GetById<T, IdT>(IdT id) where T : Entity;
	}
}
