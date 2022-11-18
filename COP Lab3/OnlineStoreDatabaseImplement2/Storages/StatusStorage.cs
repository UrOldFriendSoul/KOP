using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStoreDatabaseImplement.Models;
using OnlineStoreDatabaseImplement;

namespace OnlineStoreDatabaseImplement.Storages
{
    public class StatusStorage
    {
        public List<StatusViewModel> GetFullList()
        {
            using (var context = new OnlineStoreDatabase())
            {
                return context.Statuses.Select(CreateModel).ToList();
            }
        }
        public StatusViewModel GetElement(StatusViewModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new OnlineStoreDatabase())
            {
                var status = context.Statuses.FirstOrDefault(rec => rec.Id == model.Id);
                return status != null ? CreateModel(status) : null;
            }
        }

        public void Insert(StatusViewModel model)
        {
            using (var context = new OnlineStoreDatabase())
            {
                context.Statuses.Add(CreateModel(model, new Status()));
                context.SaveChanges();
            }
        }

        public void Update(StatusViewModel model)
        {
            using (var context = new OnlineStoreDatabase())
            {
                Status status = context.Statuses.FirstOrDefault(rec => rec.Id == model.Id);
                if (status == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, status);
                context.SaveChanges();
            }
        }

        public void Delete(StatusViewModel model)
        {
            using (var context = new OnlineStoreDatabase())
            {
                Status status = context.Statuses.FirstOrDefault(rec => rec.Id == model.Id);
                if (status != null)
                {
                    context.Statuses.Remove(status);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        private StatusViewModel CreateModel(Status status)
        {
            return new StatusViewModel
            {
                Id = status.Id,
                StatusName = status.StatusName
            };
        }
        private Status CreateModel(StatusViewModel model, Status status)
        {
            status.StatusName = model.StatusName;
            return status;
        }
    }
}
