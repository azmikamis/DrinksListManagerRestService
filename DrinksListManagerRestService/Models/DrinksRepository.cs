using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksListManagerRestService.Models
{
    public class DrinksRepository : IDrinksRepository
    {
        public DrinksRepository()
        {
        }

        public IEnumerable<DrinkRecord> GetAll()
        {
            return DrinksData.Instance.DrinkList;
        }

        public void Add(string drinkName)
        {
            var record = DrinksData.Instance.DrinkList.Where(d => d.Name == drinkName).FirstOrDefault();
            if (record == null)
            {
                DrinksData.Instance.DrinkList.Add(new DrinkRecord { Name = drinkName, Quantity = 1 });
            }
        }

        public DrinkRecord Find(string drinkName)
        {
            var record = DrinksData.Instance.DrinkList.Where(d => d.Name == drinkName).FirstOrDefault();
            return record;
        }

        public DrinkRecord Remove(string drinkName)
        {
            var record = DrinksData.Instance.DrinkList.Where(d => d.Name == drinkName).FirstOrDefault();
            if (record != null)
                DrinksData.Instance.DrinkList.Remove(record);
            return record;
        }

        public void Update(string drinkName, int drinkQuantity)
        {
            var record = DrinksData.Instance.DrinkList.Where(d => d.Name == drinkName).FirstOrDefault();
            if (record != null)
                record.Quantity = drinkQuantity;
        }
    }
}
