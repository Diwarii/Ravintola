using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravintola.Models
{
    public class Dish : Property
    {
        // Значение ID для Блюд
        private uint _id;
        public uint Id { get { return _id; } set { _id = value; OnPropertyChanged("Id"); } }

        // Значение названия для Блюд
        private string _foodName;
        public string FoodName { get { return _foodName; } set { _foodName = value; OnPropertyChanged("FoodName"); } }

        // Значение стоимости для Блюд
        private double _foodCost;
        public double FoodCost { get { return _foodCost; } set { _foodCost = value; OnPropertyChanged("FoodCost"); } }
    }
}
