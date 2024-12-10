using Microsoft.EntityFrameworkCore;
using Ravintola.Models;
using Ravintola.Views;
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
        private Dish selectedDish;
        public Dish SelectedDish
        {
            get { return selectedDish; }
            set { selectedDish = value; OnPropertyChanged("SelectedDish"); }
        }
        public ObservableCollection<Dish> Dishes { get; set; } = new ObservableCollection<Dish>();
        public ProductsViewModel Products = new ProductsViewModel();
        public DishesViewModel()
        {
            Global.db.Database.EnsureCreated();
            Global.db.Dishes.Load();
            Dishes = Global.db.Dishes.Local.ToObservableCollection();
        }

        private RelayCommand _deleteDish;
        public RelayCommand DeleteDish
        {
            get
            {
                return _deleteDish ??
                (_deleteDish = new RelayCommand(obj =>
                {
                    if (SelectedDish != null)
                    {
                        Global.db.Dishes.Remove(SelectedDish);
                        Global.db.SaveChanges();
                    }
                }));
            }
        }

        private RelayCommand _editDish;
        public RelayCommand EditDish
        {
            get
            {
                return _editDish ??
                (_editDish = new RelayCommand(obj =>
                {
                    Dish dish = obj as Dish;
                    if (dish == null) return;

                    Dish vm = new Dish()
                    {
                        FoodName = dish.FoodName,
                        FoodCost = dish.FoodCost
                    };
                    EditDishView editDishView = new EditDishView(vm);

                    if (editDishView.ShowDialog() == true)
                    {
                        try
                        {
                            dish.FoodName = editDishView.Dish.FoodName;
                            dish.FoodCost = editDishView.Dish.FoodCost;

                            Global.db.Entry(dish).State = EntityState.Modified;
                            Global.db.SaveChanges();
                        }
                        catch
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }));
            }
        }

    }
}
