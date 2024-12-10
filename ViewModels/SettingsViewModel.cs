using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Ravintola.Models;
using Ravintola.ViewModels;
using Ravintola.Views;

namespace Ravintola.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {

        private RelayCommand openDeleteDish;
        public RelayCommand OpenDeleteDish
        {
            get
            {
                return openDeleteDish ??
                (openDeleteDish = new RelayCommand(obj =>
                {
                    RemoveDishView removeEditDishView = new RemoveDishView();
                    removeEditDishView.ShowDialog();
                }));
            }
        }
        private RelayCommand _addDish;
        public RelayCommand AddDish // добавление обьекта в список
        {
            get
            {
                return _addDish ??
                  (_addDish = new RelayCommand(obj =>
                  {
                      AddingDishView addingDishView = new AddingDishView(new Dish());
                      if (addingDishView.ShowDialog() == true) // дописать обработку Exceptions
                      {
                          try
                          {
                              Dish dish = addingDishView.Dish;
                              Global.db.Dishes.Add(dish);
                              Global.db.SaveChanges();
                          }
                          catch
                          {
                              MessageBox.Show("Test");
                          }
                      }
                  }));
            }
        }

        private RelayCommand _openEditDish;
        public RelayCommand OpenEditDish
        {
            get
            {
                return _openEditDish ??
                (_openEditDish = new RelayCommand(obj =>
                {
                    EditDishView edit = new EditDishView();
                    edit.ShowDialog();
                }));
            }
        }

        private RelayCommand _addProduct;
        public RelayCommand AddProduct // добавление обьекта в список
        {
            get
            {
                return _addProduct ??
                  (_addProduct = new RelayCommand(obj =>
                  {
                      AddingProductView addingProductView = new AddingProductView(new Product());
                      if (addingProductView.ShowDialog() == true) // дописать обработку Exceptions
                      {
                          try
                          {
                              Product product = addingProductView.Product;
                              Global.db.Products.Add(product);
                              Global.db.SaveChanges();
                          }
                          catch
                          {
                              MessageBox.Show("Test");
                          }
                      }
                  }));
            }
        }

        private RelayCommand openDeleteProduct;
        public RelayCommand OpenDeleteProduct
        {
            get
            {
                return openDeleteProduct ??
                (openDeleteProduct = new RelayCommand(obj =>
                {
                    RemoveProductView removeProductView = new RemoveProductView();
                    removeProductView.ShowDialog();
                }));
            }
        }

        private RelayCommand _openEditProduct;
        public RelayCommand OpenEditProduct
        {
            get
            {
                return _openEditProduct ??
                (_openEditProduct = new RelayCommand(obj =>
                {
                    EditProductView edit = new EditProductView();
                    edit.ShowDialog();
                }));
            }
        }
    }
}
