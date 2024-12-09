using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Ravintola.Models
{
    public class Dish : Property
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

        //private List<Product> _dishProducts;
        //public List<Product> DishProducts 
        //{ 
        //    get 
        //    { 
        //        return _dishProducts; 
        //    } 
        //    set 
        //    { 
        //        _dishProducts = value; 
        //        OnPropertyChanged("Dishes"); 
        //    }
        //}

        public Dish(uint id, string foodName, double foodCost)
        {
            Id = id;
            FoodName = foodName;
            FoodCost = foodCost;
        }
        public Dish() { }
    }
}
