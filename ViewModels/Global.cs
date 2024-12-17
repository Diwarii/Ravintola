using Ravintola.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravintola.ViewModels
{
    public static class Global
    {
        public static ApplicationContext db { get; set; }
        public static ObservableCollection<Dish> Dishes { get; set; } = new ObservableCollection<Dish>();
    }
}
