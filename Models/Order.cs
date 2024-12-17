using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ravintola.Models;
using Ravintola.ViewModels;

namespace Ravintola.Models
{
    public class Order : Property
    {
        // Значение ID для Блюд
        public uint Id { get; set; }

        private List<Dish> dishOrder;
        public List<Dish> DishOrder
        {
            get => dishOrder;
            set { dishOrder = value; OnPropertyChanged("DishOrder"); }
        }
    }
}
