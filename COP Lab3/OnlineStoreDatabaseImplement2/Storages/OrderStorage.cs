using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStoreDatabaseImplement.Models;
using OnlineStoreDatabaseImplement;

namespace OnlineStoreDatabaseImplement.Storages
{
    public class OrderStorage
    {
        public List<OrderViewModel> GetFullList()
        {
            using (var context = new OnlineStoreDatabase())
            {
                return context.Orders.Select(CreateModel).ToList();
            }
        }

        public OrderViewModel GetElement(OrderViewModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new OnlineStoreDatabase())
            {
                var order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                return order != null ? CreateModel(order) : null;
            }
        }

        public void Insert(OrderViewModel model)
        {
            using (var context = new OnlineStoreDatabase())
            {
                context.Orders.Add(CreateModel(model, new Order()));
                context.SaveChanges();
            }
        }

        public void Update(OrderViewModel model)
        {
            using (var context = new OnlineStoreDatabase())
            {
                Order order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (order == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, order);
                context.SaveChanges();
            }
        }

        public void Delete(OrderViewModel model)
        {
            using (var context = new OnlineStoreDatabase())
            {
                Order order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        private OrderViewModel CreateModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                FIO = order.FIO,
                Description = order.Description,
                Status = order.Status,
                Summary = order.Summary,
            };
        }

        private Order CreateModel(OrderViewModel model, Order order)
        {
            order.FIO = model.FIO;
            order.Description = model.Description;
            order.Status = model.Status;
            order.Summary = model.Summary;
            return order;
        }
    }
}
