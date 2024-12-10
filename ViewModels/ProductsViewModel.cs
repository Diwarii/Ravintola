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

        private Product selectedProduct;
        public Product SelectedProduct
        {
            get => selectedProduct;
            set { selectedProduct = value; OnPropertyChanged("SelectedProduct"); }
        }

        private RelayCommand _deleteProduct;
        public RelayCommand DeleteProduct
        {
            get
            {
                return _deleteProduct ??
                (_deleteProduct = new RelayCommand(obj =>
                {
                    if (SelectedProduct != null)
                    {
                        Global.db.Products.Remove(SelectedProduct);
                        Global.db.SaveChanges();
                    }
                }));
            }
        }

        public ProductsViewModel()
        {
            Global.db.Database.EnsureCreated();
            Global.db.Products.Load();
            Products = Global.db.Products.Local.ToObservableCollection();
        }
    }
}

