using System;
using System.Data.Linq;
using System.Linq.Expressions;
using Repository.Models;

namespace Repository.Repository
{
    public class MedicinesRepository : RepositoryBase<Medicine, Db.Medicines>
    {
        protected override Table<Db.Medicines> GetTable()
        {
            return context.Medicines;
        }

        protected override Expression<Func<Db.Medicines, Medicine>> GetConverter()
        {
            return c => new Medicine()
                            {
                                Id = c.Id,
                                Name = c.Name,
                                ProductForm = c.ProductForm,
                                Manufacturer = c.Manufacturer,
                                Recipe = Convert.ToBoolean(c.Recipe),
                                Price = c.Price,
                                Available = Convert.ToBoolean(c.Available)
                            };
        }

        protected override void UpdateEntry(Db.Medicines dbMedicines, Medicine medicine)
        {
            dbMedicines.Name = medicine.Name;
            dbMedicines.ProductForm = medicine.ProductForm;
            dbMedicines.Manufacturer = medicine.Manufacturer;
            dbMedicines.Recipe = Convert.ToByte(medicine.Recipe);
            dbMedicines.Price = medicine.Price;
            dbMedicines.Available = Convert.ToByte(medicine.Available);
        }
    }
}
