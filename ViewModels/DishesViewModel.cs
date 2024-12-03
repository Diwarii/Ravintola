using Microsoft.EntityFrameworkCore;
using Ravintola.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ravintola.ViewModels
{
    class DishesViewModel : BaseViewModel
    {
        public ObservableCollection<Dish> Dishes { get; set; } = new ObservableCollection<Dish>();

        private Dish selectedDish;
        public Dish SelectedDish
        {
            get { return selectedDish; }
            set { selectedDish = value; OnPropertyChanged("SelectedDish"); }
        }
        public DishesViewModel()
        {
            Global.db.Database.EnsureCreated();
            Global.db.Dishes.Load();
            Dishes = Global.db.Dishes.Local.ToObservableCollection();
        }

    }
}
