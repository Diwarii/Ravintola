using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravintola.Models
{
    public class DishesInOrder : Property
    {
        // Значение ID для Блюд
        public uint Id { get; set; }

        // Значение названия для Блюд
        private string _foodName;
        public string FoodName
        {
            get => _foodName;
            set
            {
                _foodName = value;
                OnPropertyChanged("FoodName");
            }
        }

        // Значение стоимости для Блюд
        private double _foodCost;
        public double FoodCost
        {
            get => _foodCost;
            set
            {
                _foodCost = value;
                OnPropertyChanged("FoodCost");
            }
        }

        public DishesInOrder(uint id, string foodName, double foodCost)
        {
            Id = id;
            FoodName = foodName;
            FoodCost = foodCost;
        }
        public DishesInOrder()
        {

        }
    }
}
