using NetElement.Entities;
using NetElement.Service;
using NetElement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetElement.Web.Controllers
{
    /// <summary>
    /// Контроллер для работы с данными по сотруднику
    /// </summary>
    public class EmployeeController : Controller
    {
        #region Services
        public virtual INetElementService NetElementService { get; set; }
		#endregion

		private List<string> names;

		public EmployeeController()
		{
            if(NetElementService == null)
			{
                NetElementService = Service.NetElementService.Instance;
            }
		}
		/// <summary>
		/// Стартовая страница со всеми сотрудниками
		/// </summary>
		/// <returns></returns>
		public ActionResult Index()
        {
			var employee= NetElementService.GetAll<Employee,int>();
			var model = new EmployeesModel()
			{
				Employees = employee,
				Departments = NetElementService.GetAll<Department,int>()
			};
			return View("Index",model);
        }
        /// <summary>
        /// Информация о сотруднике
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Info(int id)
		{
            var workExp = NetElementService.GetById<Employee,int>(id);
            return View("Info",workExp);
		}
        /// <summary>
        /// Добавить сотрудника
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Add()
		{
            var model = new AddEmployeeModel();
            model.Departments = NetElementService.GetAll<Department, int>();
            model.Languages = NetElementService.GetAll<ProgrammingLanguage, int>();
            model.Employee = new Employee();
			names = NetElementService.GetAll<Employee, int>().Select(t => t.Name).ToList();
			return View("Add",model);
		}
        /// <summary>
        /// Сохранить сотрудника
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Add(AddEmployeeModel model)
		{
            var employee = model.Employee;
            employee.DepartmentId = Int32.Parse(model.DepratmentId);
			NetElementService.AddEmployee(employee, model.LanguageId);
            return RedirectToAction("Index");
		}
        /// <summary>
        /// Отредактировать сотрудника
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            var model = new AddEmployeeModel();
            model.Departments = NetElementService.GetAll<Department, int>();
            model.Languages = NetElementService.GetAll<ProgrammingLanguage, int>();
            model.Employee = NetElementService.GetById<Employee,int>(id);
            names = NetElementService.GetAll<Employee,int>().Select(t => t.Name).ToList();
            return View("Edit",model);
        }
        /// <summary>
        /// Сохранить данные о сотруднике
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(Employee employee)
		{
            NetElementService.EditEmployee(employee);   
            return RedirectToAction("Index");
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AutocompleteSearch(string term)
		{
            if(names == null)
			{
                names = NetElementService.GetAll<Employee, int>().Select(t => t.Name).ToList();
            }            
            var models = names.Where(a => a.Contains(term)).Select(a => new { value = a }).Distinct();
			return Json(models,JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// Удалить сотрудника
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            NetElementService.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}
