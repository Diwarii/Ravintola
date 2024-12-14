using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ravintola.Models;

namespace Ravintola.ViewModels
{
    public class OrdersViewModel : BaseViewModel
    {
        public ObservableCollection<Order> Orders { get; set; }  = new ObservableCollection<Order>();
        public OrdersViewModel()
        {
            Global.db.Database.EnsureCreated();
            Global.db.Orders.Load();
            Orders = Global.db.Orders.Local.ToObservableCollection();
        }
    }
}
