using DrinksListManagerRestService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksListManagerRestService
{
    public class DrinksData
    {
        private static readonly DrinksData _instance = new DrinksData();

        private DrinksData() { }

        public static DrinksData Instance
        {
            get
            {
                return _instance;
            }
        }

        private List<DrinkRecord> drinkList = new List<DrinkRecord>();

        public List<DrinkRecord> DrinkList
        {
            get
            {
                return drinkList;
            }
        }
    }
}
