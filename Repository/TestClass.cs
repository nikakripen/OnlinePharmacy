using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using Repository.Db;
using Repository.Models;
using Repository.Repository;

namespace Repository
{
    class TestClass
    {
        [Test]
        public void Test()
        {
            DbContext context = new DbContext();
            var order = new Orders()
            {
                Name = "Ника",
                Surname = "111",
                Patronymic = "222",
                PhoneNumber = "12345",
                E_mail = "@",
                State = "Не обработан"
            };
            var med = context.Medicines.FirstOrDefault(m => m.Name == "Гроприносин");
            order.Medicines.Add(med);
            context.Orders.InsertOnSubmit(order);

            context.SubmitChanges();
            
        }

        [Test]
        public void TestRep()
        {
            var rep = new OrdersRepository();
            var order = new Order()
            {
                Name = "Ника11112",
                Surname = "111",
                Patronymic = "222",
                PhoneNumber = "12345",
                E_mail = "@",
                State = "Не обработан"
            };
            var medrep = new MedicinesRepository();
            var med = medrep.GetAll().FirstOrDefault(m => m.Name == "Гроприносин");
            order.OrderedMedicines = new List<Medicine>();
                order.OrderedMedicines.Add(med);
            rep.Save(order);
        }

    }
}
