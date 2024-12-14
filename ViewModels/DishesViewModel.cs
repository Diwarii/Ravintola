using Microsoft.EntityFrameworkCore;
using Ravintola.Models;
using Ravintola.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
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
        public ObservableCollection<DishesInOrder> dishesInOrder { get; set; } = new ObservableCollection<DishesInOrder>();
        public DishesViewModel()
        {
            Global.db.Database.EnsureCreated();
            Global.db.Dishes.Load();
            Global.db.DishesInOrder.Load();
            Global.db.Orders.Load();
            Dishes = Global.db.Dishes.Local.ToObservableCollection();
            dishesInOrder = Global.db.DishesInOrder.Local.ToObservableCollection();
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

                    //EditDishView editDishView = new EditDishView(vm);
                    try
                    {
                        Global.db.Entry(dish).State = EntityState.Modified;
                        Global.db.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }));
            }
        }

        private int _dishesInOrderCount;
        public int DishesInOrderCount
        {
            get => _dishesInOrderCount;
            set { _dishesInOrderCount = value; OnPropertyChanged(); }
        }

        public CheckOrderViewModel CheckOrderViewModel = new CheckOrderViewModel();

        private RelayCommand _addToOrder;
        public RelayCommand AddToOrder
        {
            get
            {
                return _addToOrder ??
                (_addToOrder = new RelayCommand(obj =>
                {
                    Dish dish = obj as Dish;
                    if (dish == null) return;

                    DishesInOrder dio = new DishesInOrder()
                    {
                        Id = 0,
                        FoodName = dish.FoodName,
                        FoodCost = dish.FoodCost
                    };


                    DishesInOrderCount++;
                    Global.db.DishesInOrder.Add(dio);
                    Global.db.SaveChanges();
                }));
            }
        }

        private RelayCommand _showOrderWindow;
        public RelayCommand ShowOrderWindow
        {
            get
            {
                return _showOrderWindow ??
                (_showOrderWindow = new RelayCommand(obj =>
                {
                    CheckOrderView vm = new CheckOrderView();
                    vm.Show();
                }));
            }
        }
    }
}
