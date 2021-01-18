using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NetElement.Web.Controllers;
using System.Web.Mvc;
using NetElement.Service;
using NetElement.Test.Mocks;

namespace NetElement.Test
{
	/// <summary>
	/// Тестирование методов контроллера
	/// </summary>
	[TestFixture]
	public class EmployeeControllerTest
	{
		Mock<EmployeeControllerMoq> employeeController;
		[SetUp]
		public void Init()
		{
			employeeController = new Mock<EmployeeControllerMoq>();
			employeeController.Setup(t => t.NetElementService).Returns<INetElementService>(null);
		}
		public EmployeeControllerMoq GetController()
		{
			var employeeControllers = new Mock<EmployeeControllerMoq>();
			employeeControllers.SetupProperty(t => t.NetElementService, new NetElementServiceMoq());
			return employeeControllers.Object;
		}
		/// <summary>
		/// Проверка на существование представление Index
		/// </summary>
		[Test]
		public void IndexViewNoNull()
		{
			ViewResult result = GetController().Index() as ViewResult;
			Assert.IsNotNull(result);
		}
		/// <summary>
		/// Проверка названия вызванного представления Index
		/// </summary>
		[Test]
		public void IndexViewEqualIndexCshtml()
		{
			ViewResult result = employeeController.Object.Index() as ViewResult;
			Assert.AreEqual("Index",result.ViewName);
		}
		/// <summary>
		/// Проверка на существование представление Add
		/// </summary>
		[Test]
		public void AddViewNoNull()
		{
			ViewResult result = employeeController.Object.Add() as ViewResult;
			Assert.IsNotNull(result);
		}
		/// <summary>
		/// Проверка названия вызванного представления Add
		/// </summary>
		[Test]
		public void AddViewEqualIndexCshtml()
		{
			ViewResult result = employeeController.Object.Add() as ViewResult;
			Assert.AreEqual("Add", result.ViewName);
		}
	}
}
