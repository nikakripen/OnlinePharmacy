using System;
using System.Collections.Generic;
using NUnit;
using Repository.Models;
using Repository.Repository;
using Repository.Filters;
using System.Linq;
using NUnit.Framework;
using Repository.Db;

namespace TestRepository
{
    class TestUpdateEntry:OrdersRepository
    {
        public void TestUpdateEntryWhithNullList(Orders dbord, Order ord)
        {
            UpdateEntry(dbord,ord);
            List<Medicines> list = dbord.Medicines.ToList();
            Assert.IsTrue(list.Count == 0);
        }

        public void TestUpdateEntryWhithList(Orders dbord, Order ord)
        {
            UpdateEntry(dbord, ord);
            List<Medicines> dbmed_list = dbord.Medicines.ToList();
            List<Medicine> med_list = ord.OrderedMedicines;
            foreach (var dbmed in dbmed_list)
            {
                Assert.IsTrue(med_list.Exists(m => m.Id == dbmed.Id));
            }
        }
    }
    [TestFixture]
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
        public Order NewTestOrder()
        {
            return new Order()
            {
                Surname = "test",
                Name = "test",
                Patronymic = "test",
                E_mail = "test@tast.test",
                PhoneNumber = "1111",
                State = "не обработан"
            };
        }


        [Test]
        public void TestSave()
        {
            // подготовка
            var order = NewTestOrder();
            
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
        public void TestSaveOrderWithMed()
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

            var order = NewTestOrder();

            try
            {
                MedRep.Save(med);
                order.OrderedMedicines = new List<Medicine>();
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
            var med = new Medicine()
            {
                Name = "11111",
                ProductForm = "123",
                Manufacturer = "Белфарма",
                Available = true,
                Price = 12000,
                Recipe = true
            };
            var order = NewTestOrder();
            MedRep.Save(med);
            repository.Save(order);

            try
            {
                var med1 = MedRep.GetAll().FirstOrDefault(m => m.Name == "11111");
                var order1 = repository.GetAll().FirstOrDefault(o => o.Name == "test");
                order1.OrderedMedicines.Add(med1);
                repository.Save(order1);

                var order2 = repository.GetAll().FirstOrDefault(o => o.Id == order.Id);
                Assert.True(order2.OrderedMedicines.Exists(m => m.Id == med.Id));
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
        public void TestDeleteForId()
        {
            // подготовка
            var order = NewTestOrder();
            repository.Save(order);

            // выполнение
            try
            {
                repository.Delete(order.Id);
                // проверка
                Assert.Throws(typeof(InvalidOperationException),
                    delegate { repository.GetAll().Single(o => o.Id == order.Id); });
            }
            finally
            {
                if (order.Id != 0)
                    repository.Delete(order);
            }
        }

        [Test]
        public void TestUpdateEntryWhithNullList()
        {
            Orders dbOrders = new Orders();
            Order order = NewTestOrder();

            var newRep = new TestUpdateEntry();
            newRep.TestUpdateEntryWhithNullList(dbOrders, order);
        }

        [Test]
        public void TestUpdateEntryWhithList()
        {
            Orders dbOrders = new Orders();
            dbOrders.Medicines.Add(new Medicines(){Id = 1, Name = "testmed"});
            Order order = NewTestOrder();
            order.OrderedMedicines = new List<Medicine>() { new Medicine() { Id = 1, Name = "testmed" }};

            var newRep = new TestUpdateEntry();
            newRep.TestUpdateEntryWhithList(dbOrders, order);
        }
    }
}
