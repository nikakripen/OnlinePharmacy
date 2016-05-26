using NUnit;
using Repository.Models;
using Repository.Repository;
using Repository.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestRepository
{
    
    public class TestRepository
    {

        [Test]
        public void TestAdd()
        {
            
            // подготовка
            var repository = new MedicinesRepository();
            // выполнение
            var med = new Medicine()
            {
                Name = "11111",
                ProductForm = "123",
                Manufacturer = "Белфарма",
                Available = true,
                Price = 12000,
                Recipe = true
            };
            try
            {
                repository.Save(med);
                // проверка
                var m_db = repository.GetAll().FirstOrDefault(m => m.Id == med.Id);
                Assert.IsTrue(m_db != null);
                Assert.AreEqual(med.Name, m_db.Name);
            }
            finally
            {
                if (med.Id != 0)
                    repository.Delete(med);
            }
        }

        [Test]
        public void TestDeleteForId()
        {
            // подготовка
            var repository = new MedicinesRepository();
            var med = new Medicine()
            {
                Name = "дюфастон",
                ProductForm = "123",
                Manufacturer = "Белфарма",
                Available = true,
                Price = 12000,
                Recipe = true
            };
            repository.Save(med);
                
            // выполнение
            try
            {
                repository.Delete(med.Id);
                // проверка
                var m_db = repository.GetAll().FirstOrDefault(m => m.Id == med.Id);
                Assert.IsTrue(m_db == null);
            }
            finally
            {
                if (med.Id != 0)
                    repository.Delete(med);
            }
        }

        [Test]
        public void TestSelectWithId()
        {
            // подготовка
            var repository = new MedicinesRepository();
            // выполнение
            var med = new Medicine()
            {
                Name = "дюфастон",
                ProductForm = "123",
                Manufacturer = "Белфарма",
                Available = true,
                Price = 12000,
                Recipe = true
            };
            repository.Save(med);
                
            try
            {
                // проверка
                var m_db = repository.GetAll().WithId(med.Id).SingleOrDefault();
                Assert.AreEqual(m_db.Id, med.Id);
            }
            finally
            {
                if (med.Id != 0)
                    repository.Delete(med);
            }
        }

        [Test]
        public void TestSelectWithNameLike()
        {
            // подготовка
            var repository = new MedicinesRepository();
            // выполнение
            var med = new Medicine()
            {
                Name = "дюфастон",
                ProductForm = "123",
                Manufacturer = "Белфарма",
                Available = true,
                Price = 12000,
                Recipe = true
            };
            repository.Save(med);

            try
            {
                // проверка
                var m_db = repository.GetAll().WithNameLike("дюфастон").FirstOrDefault();
                Assert.AreEqual(m_db.Name, med.Name);
            }
            finally
            {
                if (med.Id != 0)
                    repository.Delete(med);
            }
        }
        [Test]
        public void TestSelectWithProductFormLike()
        {
            // подготовка
            var repository = new MedicinesRepository();
            // выполнение
            var med = new Medicine()
            {
                Name = "дюфастон",
                ProductForm = "123",
                Manufacturer = "Белфарма",
                Available = true,
                Price = 12000,
                Recipe = true
            };
            repository.Save(med);

            try
            {
                // проверка
                var m_db = repository.GetAll().WithProductFormLike("123").FirstOrDefault();
                Assert.AreEqual(m_db.ProductForm, med.ProductForm);
            }
            finally
            {
                if (med.Id != 0)
                    repository.Delete(med);
            }
        }
    }
}
