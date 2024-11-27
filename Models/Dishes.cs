using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravintola.Models
{
    public class Dishes : Property
    {
        private uint _id;
        public uint Id { get { return _id; } set { _id = value; OnPropertyChanged("Id"); } }

        private string _foodName;
        public string FoodName { get { return _foodName; } set { _foodName = value; OnPropertyChanged("FoodName"); } }

        private double _foodCost;
        public double FoodCost { get { return _foodCost; } set { _foodCost = value; OnPropertyChanged("FoodCost"); } }
    }
}
