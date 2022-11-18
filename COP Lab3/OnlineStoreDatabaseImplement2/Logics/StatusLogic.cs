using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStoreDatabaseImplement.Models;
using OnlineStoreDatabaseImplement.Storages;

namespace OnlineStoreDatabaseImplement.Logics
{
    public class StatusLogic
    {
        private readonly StatusStorage statusStorage = new StatusStorage();
        public StatusLogic() { }

        public List<StatusViewModel> Read(StatusViewModel model)
        {
            if (model == null)
            {
                return statusStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<StatusViewModel> { statusStorage.GetElement(model) };
            }
            return null;
        }

        public void Create(StatusViewModel model)
        {
            statusStorage.Insert(model);
        }

        public void Update(StatusViewModel model)
        {
            var element = statusStorage.GetElement(model);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            statusStorage.Update(model);
        }

        public void Delete(StatusViewModel model)
        {
            var element = statusStorage.GetElement(model);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            statusStorage.Delete(model);
        }
    }
}
