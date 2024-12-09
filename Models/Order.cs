using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravintola.Models
{
    public class Order : Property
    {
        private uint _id;
        public uint Id { get { return _id; } set { _id = value; OnPropertyChanged("Id"); }}
    }
}
