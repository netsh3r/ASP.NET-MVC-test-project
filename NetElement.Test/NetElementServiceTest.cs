using NetElement.Entities;
using NetElement.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NetElement.Test
{
    /// <summary>
    /// Тест основного сервиса взаимодействия с данными из бд
    /// </summary>
    [TestFixture]
    public class NetElementServiceTest
    {
        private NetElementService netElementService;
        
        [SetUp]
        public void Init()
        {
            netElementService = NetElementService.Instance;
        }
        private ICollection<T> GetAllByGeneric<T,IdT>() where T:Entity
		{
            return netElementService.GetAll<T, IdT>();
        }

        private T GetByIdAndGeneric<T,IdT>(IdT id) where T:Entity
		{
            return netElementService.GetById<T, IdT>(id);
		}
        /// <summary>
        /// Получить все отделы при помощи Generic
        /// </summary>
        [Test]
        public void GetAllDepartmentByGeneric()
        {
            try
            {
                var model = GetAllByGeneric<Department, int>();
                Assert.IsNotNull(model);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Произошла ошибка при получении сущность 'язык программирования' {ex.ToString()}");
            }
        }
        /// <summary>
        /// Получить отдел по id
        /// </summary>
        [Test]
        public void GetDepartmentById()
        {
            try
            {
                var id = 1;
                var model = GetByIdAndGeneric<Department, int>(id);
                Assert.IsNotNull(model);
                Assert.IsNotNull(model as Department);
                Assert.AreEqual(model.Id, id);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Произошла ошибка при получении сущность 'язык программирования' {ex.ToString()}");
            }
        }
        /// <summary>
        /// Получить все языки программирования при помощи Generic
        /// </summary>
        [Test]
        public void GetAllProgrammingLanguageByGeneric()
        {
	        try
	        {
                var model = GetAllByGeneric<ProgrammingLanguage, int>();
                Assert.IsNotNull(model);
	        }
            catch(Exception ex)
	        {
                Assert.Fail($"Произошла ошибка при получении сущность 'язык программирования' {ex.ToString()}");
	        }
        }
        /// <summary>
        /// Получить язык программирования по Id
        /// </summary>
        [Test]
        public void GetProgrammingLanguageById()
		{
			try
			{
                var id = 1;
                var model = GetByIdAndGeneric<ProgrammingLanguage, int>(id);
                Assert.IsNotNull(model);
                Assert.IsNotNull(model as ProgrammingLanguage);
                Assert.AreEqual(model.Id, id);
			}
            catch(Exception ex)
			{
                Assert.Fail($"Произошла ошибка при получении сущность 'язык программирования' {ex.ToString()}");
			}
		}
    }
}