using NUnit;
using Repository.Models;
using Repository.Repository;
using Repository.Filters;
using System.Linq;
using NUnit.Framework;

namespace TestRepository
{
    class TestOrdersRepository
    {
        OrdersRepository repository = new OrdersRepository();

        public void EqualOrder(Order order, Order o_db)
        {
            Assert.AreEqual(order.Name, o_db.Name);
            Assert.AreEqual(order.Surname, o_db.Surname);
            Assert.AreEqual(order.Patronymic, o_db.Patronymic);
            Assert.AreEqual(order.E_mail, o_db.E_mail);
            Assert.AreEqual(order.PhoneNumber, o_db.PhoneNumber);
            Assert.AreEqual(order.State, o_db.State);
        }


        [Test]
        public void TestAddOrderWithoutMed()
        {
            // подготовка
            var order = new Order()
            {
                Surname = "Крипень",
                Name = "Вероника",
                Patronymic = "Сергеевна",
                E_mail = "nika.kripen@gmail.com",
                PhoneNumber = "+375293326196",
                State = "Не обработан"
            };
            
            try
            {
                // выполнение
                repository.Save(order);
                // проверка
                Order o_db = repository.GetAll().FirstOrDefault(o => o.Id == order.Id);
                Assert.IsTrue(o_db != null);
                EqualOrder(order,o_db);
            }
            finally
            {
                if (order.Id != 0)
                    repository.Delete(order);
            }
        }

        [Test]
        public void TestAddOrderWithMed()
        {
            // подготовка
            var MedRep = new MedicinesRepository();
            var med = new Medicine()
            {
                Name = "11111",
                ProductForm = "123",
                Manufacturer = "Белфарма",
                Available = true,
                Price = 12000,
                Recipe = true
            };

            var order = new Order()
            {
                Surname = "Крипень",
                Name = "Вероника",
                Patronymic = "Сергеевна",
                E_mail = "nika.kripen@gmail.com",
                PhoneNumber = "+375293326196",
                State = "Не обработан"
            };
            

            try
            {
                MedRep.Save(med);
                order.OrderedMedicines.Add(med);
                // выполнение
                repository.Save(order);
                // проверка
                Order o_db = repository.GetAll().FirstOrDefault(o => o.Id == order.Id);

                Assert.IsTrue(o_db != null);

                var med_db = o_db.OrderedMedicines.Find(m => m.Id == med.Id);
                Assert.AreEqual(med.Name, med_db.Name);
            }
            finally
            {
                if (order.Id != 0)
                    repository.Delete(order);
                if (med.Id != 0)
                    MedRep.Delete(med);
            }
        }

        [Test]
        public void TestAddMedToOrder()
        {
            var MedRep = new MedicinesRepository();
            var med = MedRep.GetAll().FirstOrDefault(m => m.Name == "гроприносин");
            var order = repository.GetAll().FirstOrDefault(o => o.Name == "Вероника");
            order.OrderedMedicines.Add(med);
            repository.Save(order);

            var order1 = repository.GetAll().FirstOrDefault(o => o.Id == order.Id);
            Assert.True(order1.OrderedMedicines.Contains(med));


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
