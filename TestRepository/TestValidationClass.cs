using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AdminPart;
using Moq;
using Repository.Filters;
using Repository.Models;
using Repository.Repository;

namespace TestRepository
{

    [TestFixture]
    class TestValidationClass
    {
        [Test]
        public void TestValidationNullBoxTrue()
        {
            var name = "Наименование";
            Exception ex = Assert.Throws<Exception>(
                delegate { ValidationClass.ValidateNullBox(string.Empty, name); });
            Assert.That(ex.Message, Is.EqualTo("Поле " + name + " должно быть заполнено!"));
                  
        }
        [Test]
        public void TestValidationNullBoxFalse()
        {
            var name = "Наименование";
            Assert.IsTrue(ValidationClass.ValidateNullBox("111", name));
        }

        [Test]
        public void TestValidationLengthBoxTrue()
        {
            var name = "Наименование";
            int min = 2, max = 255;
            Exception ex = Assert.Throws<Exception>(
                delegate { ValidationClass.ValidateLengthBox(string.Empty, name, min, max); });
            Assert.That(ex.Message, Is.EqualTo("Поле " + name + " должно содержать от " + min + " до " + max + " символов!"));
            
        }
        [Test]
        public void TestValidationLengthBoxFalse()
        {
            var name = "Наименование";
            Assert.IsTrue(ValidationClass.ValidateLengthBox("111", name, 2, 255));
        }

        [Test]
        public void TestValidationRangeBoxFormatEx()
        {
            var name = "Цена";
            double min = 100, max = 1000;
            Exception ex = Assert.Throws<Exception>(
                delegate { ValidationClass.ValidateRangeBox(string.Empty, name, min, max); });
            Assert.That(ex.Message, Is.EqualTo("Поле " + name + " должно содержать цифровые значения!"));
            
        }
        [Test]
        public void TestValidationRangeBoxFalse()
        {
            var name = "Цена";
            double min = 100, max = 1000;
            Exception ex = Assert.Throws<Exception>(
                delegate { ValidationClass.ValidateRangeBox("1001", name, min, max); });
            Assert.That(ex.Message, Is.EqualTo("Поле " + name + " должно содержать значения от " + min + " до " + max + "!"));
            
            
        }
        [Test]
        public void TestValidationRangeBoxTrue()
        {
            var name = "Цена";
            Assert.IsTrue(ValidationClass.ValidateRangeBox("155", name, 2, 255));
        }

        [Test]
        public void TestIsMedicineAlreadyExistTrue()
        {
            var med = new Medicine()
            {
                Manufacturer = "test",
                Name = "test",
                ProductForm = "test"
            };

            IRepository<Medicine> medRep =
                Mock.Of<IRepository<Medicine>>(d => d.GetAll() == new List<Medicine>()
                {
                    new Medicine() {Name = "test", Manufacturer = "test", ProductForm = "test"}
                }.AsQueryable()
                    );
            
            Exception ex = Assert.Throws<Exception>(
                delegate { ValidationClass.IsMedicineAlreadyExist(med, medRep); });
            Assert.That(ex.Message, Is.EqualTo("Такое лек.средство уже существует в системе!"));

        }
        [Test]
        public void TestIsMedicineAlreadyExistFalse()
        {
            var med = new Medicine()
            {
                Manufacturer = "test",
                Name = "test",
                ProductForm = "test"
            };

            IRepository<Medicine> medRep =
                Mock.Of<IRepository<Medicine>>(d => d.GetAll() == new List<Medicine>()
                {
                    new Medicine() {Name = "test1", Manufacturer = "test1", ProductForm = "test"}
                }.AsQueryable()
                    );

            Assert.IsFalse(ValidationClass.IsMedicineAlreadyExist(med, medRep));
        }


        
    }
}
