using System;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using Repository.Db;
using Repository.Models;

namespace Repository.Repository
{
    public class OrdersRepository : RepositoryBase<Order, Db.Orders>
    {
        protected override Table<Db.Orders> GetTable()
        {
            return context.Orders;
        }

        protected override Expression<Func<Db.Orders, Order>> GetConverter()
        {
            return c => new Order()
                            {
                                Id = c.Id,
                                Surname = c.Surname,
                                Name = c.Name,
                                Patronymic = c.Patronymic,
                                E_mail = c.E_mail,
                                PhoneNumber = c.PhoneNumber,
                                State = c.State,
                                OrderedMedicines = c.OrderedMedicines.Select(om => new Medicine()
                                {
                                    Id = om.Medicines.Id,
                                    Name = om.Medicines.Name,
                                    ProductForm = om.Medicines.ProductForm,
                                    Manufacturer = om.Medicines.Manufacturer,
                                    Recipe = Convert.ToBoolean(om.Medicines.Recipe),
                                    Price = om.Medicines.Price,
                                    Available = Convert.ToBoolean(om.Medicines.Available)
                                }).ToList() 
                            };
        }

        protected override void UpdateEntry(Db.Orders dbOrders, Order order)
        {
            dbOrders.Surname = order.Surname;
            dbOrders.Name = order.Name;
            dbOrders.Patronymic = order.Patronymic;
            dbOrders.E_mail = order.E_mail;
            dbOrders.PhoneNumber = order.PhoneNumber;
            dbOrders.State = order.State;
            if (order.OrderedMedicines != null)
            {
                foreach (Medicine med in order.OrderedMedicines)
                {
                    if (dbOrders.Medicines.FirstOrDefault(m => m.Id == med.Id) == null)
                        dbOrders.Medicines.Add(
                            (Medicines) ((IQueryable<IDbEntity>) context.Medicines).FirstOrDefault(m => m.Id == med.Id));
                }
            }   
            //dbOrders.Medicines.Clear();
            //if (order.OrderedMedicines != null)
            //{
            //    dbOrders.Medicines.AddRange(order.OrderedMedicines.Select(m => new Db.Medicines()
            //    {
            //        Id = m.Id,
            //        Name = m.Name,
            //        ProductForm = m.ProductForm,
            //        Manufacturer = m.Manufacturer,
            //        Recipe = Convert.ToByte(m.Recipe),
            //        Price = m.Price,
            //        Available = Convert.ToByte(m.Available)
            //    }));
            //}
        }
    }
}
