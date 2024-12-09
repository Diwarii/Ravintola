using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Ravintola.Models;
using Ravintola.ViewModels;
using Ravintola.Views;

namespace Ravintola.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private Dish selectedDish;
        public Dish SelectedDish
        {
            get => selectedDish;
            set { selectedDish = value; OnPropertyChanged("SelectedDish"); }
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

        private RelayCommand openDeleteDish;
        public RelayCommand OpenDeleteDish
        {
            get
            {
                return openDeleteDish ??
                (openDeleteDish = new RelayCommand(obj =>
                {
                    RemoveEditDishView removeEditDishView = new RemoveEditDishView();
                    removeEditDishView.ShowDialog();
                }));
            }
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
    }
}
