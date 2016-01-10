using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksListManagerRestService.Models
{
    public interface IDrinksRepository
    {
        void Add(string drinkName);
        IEnumerable<DrinkRecord> GetAll();
        DrinkRecord Find(string drinkName);
        DrinkRecord Remove(string drinkName);
        void Update(string drinkName, int drinkQuantity);
    }
}
