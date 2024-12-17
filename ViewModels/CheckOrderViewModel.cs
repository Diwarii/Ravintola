using Microsoft.EntityFrameworkCore;
using Ravintola.Models;
using Ravintola.ViewModels;
using Ravintola.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Permissions;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ravintola.ViewModels
{
    public class CheckOrderViewModel : BaseViewModel
    {
        public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
        public CheckOrderViewModel()
        {
            Global.db.Database.EnsureCreated();
            Global.db.Orders.Load();
            Orders = Global.db.Orders.Local.ToObservableCollection();
        }

        public ObservableCollection<Dish> Dishes
        {
            get => Global.Dishes;
            set { Global.Dishes = value; OnPropertyChanged(nameof(Dishes)); }
        }



        private RelayCommand saveOrder;
        public RelayCommand SaveOrder
        {
            get
            {
                return saveOrder ??
                (saveOrder = new RelayCommand(obj =>
                {
                    SaveOrderToDataBase();
                    MessageBox.Show("Сохранено в заказы");
                }));
            }
        }
        private void SaveOrderToDataBase()
        {
            using (var context = new ApplicationContext())
            {
                var order = new Order
                {
                    DishOrder = new List<Dish>()
                };
                if(order.DishOrder != null && order.DishOrder.Count > 0)
                {
                    order.DishOrder.AddRange(order.DishOrder);
                }

                context.Orders.Add(order);
                context.SaveChanges();

            }
        }

    }
}
