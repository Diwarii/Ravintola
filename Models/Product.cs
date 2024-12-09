using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Ravintola.Models
{
    public class Product : Property
    {
        // Значение ID для Продуктов
        public uint Id { get; set; }

        // Значение названия для Продуктов
        private string _name;
        public string Name 
        { 
            get 
            { 
                return _name;
            } 
            set 
            { 
                _name = value; 
                OnPropertyChanged("Name"); 
            } 
        }

        // Значение количества для Продуктов
        private double _count;
        public double Count 
        { 
            get 
            {
                return _count; 
            } 
            set 
            { 
                _count = value; 
                OnPropertyChanged("Count"); 
            } 
        }
        public Product(uint id,string name, double count)
        {
            Id = id;
            Name = name;
            Count = count;
        }
        public Product() { }
    }
}
