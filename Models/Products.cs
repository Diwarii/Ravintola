using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Ravintola.Models
{
    public class Products : Property
    {
        private uint _id;
        public uint Id { get { return _id; } set { _id = value; OnPropertyChanged("Id"); } }

        private string _name;
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged("Name"); } }

        private double _count;
        public double Count { get { return _count; } set { _count = value; OnPropertyChanged("Count"); } }
    }
}
