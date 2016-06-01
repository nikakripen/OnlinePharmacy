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
    [TestFixture]
    public class TestMedicinesRepository
    {
        public void EqualMedicine(Medicine medicine, Medicine m_db)
        {
            Assert.AreEqual(medicine.Name, m_db.Name);
            Assert.AreEqual(medicine.Available, m_db.Available);
            Assert.AreEqual(medicine.Manufacturer, m_db.Manufacturer);
            Assert.AreEqual(medicine.Price, m_db.Price);
            Assert.AreEqual(medicine.ProductForm, m_db.ProductForm);
            Assert.AreEqual(medicine.Recipe, m_db.Recipe);
        }

        public Medicine NewTestMedicine()
        {
            return new Medicine()
            {
                Name = "test",
                ProductForm = "test",
                Manufacturer = "test",
                Available = true,
                Price = 1000,
                Recipe = true
            };
        }

        [Test]
        public void TestSaveNew()
        {
            // подготовка
            var repository = new MedicinesRepository();
            // выполнение
            var med = NewTestMedicine();
            try
            {
                repository.Save(med);
                // проверка
                var m_db = repository.GetAll().SingleOrDefault(m => m.Id == med.Id);
                Assert.IsTrue(m_db != null);
                EqualMedicine(med,m_db);
            }
            finally
            {
                if (med.Id != 0)
                    repository.Delete(med);
            }
        }

        [Test]
        public void TestSaveNotNew()
        {
            // подготовка
            var repository = new MedicinesRepository();
            var med = NewTestMedicine();
            repository.Save(med);
            
            try
            {
                // выполнение
            
                var med1 = repository.GetAll().SingleOrDefault(m => m.Id == med.Id);
                med1.Name = "лекарство";
                repository.Save(med1);
                // проверка
                var m_db = repository.GetAll().SingleOrDefault(m => m.Id == med.Id);
                Assert.IsTrue(m_db != null);
                EqualMedicine(med1, m_db);
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
            var med = NewTestMedicine();
            repository.Save(med);
                
            // выполнение
            try
            {
                repository.Delete(med.Id);
                // проверка
                Assert.Throws(typeof(InvalidOperationException),
                    delegate { repository.GetAll().Single(m => m.Id == med.Id); });
                
            }
            finally
            {
                if (med.Id != 0)
                    repository.Delete(med);
            }
        }

        [Test]
        public void TestDelete()
        {
            // подготовка
            var repository = new MedicinesRepository();
            var med = NewTestMedicine();
            repository.Save(med);
                
            // выполнение
            try
            {
                repository.Delete(med);
                // проверка
                Assert.Throws(typeof(InvalidOperationException),
                    delegate { repository.GetAll().Single(m => m.Id == med.Id); });
                
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
            var med = NewTestMedicine();
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
            var med = NewTestMedicine();
            repository.Save(med);

            try
            {
                // проверка
                var m_db = repository.GetAll().WithNameLike("test").FirstOrDefault();
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
            var med = NewTestMedicine();
            repository.Save(med);

            try
            {
                // проверка
                var m_db = repository.GetAll().WithProductFormLike("test").FirstOrDefault();
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
