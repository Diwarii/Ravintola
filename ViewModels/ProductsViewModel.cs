using System;
using Ravintola.Models;
using Ravintola.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;

namespace Ravintola.ViewModels
{
    class ProductsViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        public ProductsViewModel()
        {
            Global.db.Database.EnsureCreated();
            Global.db.Products.Load();
            Products = Global.db.Products.Local.ToObservableCollection();
        }
    }
}

