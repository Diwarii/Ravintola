using Ravintola.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ravintola.Models
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }

    public class UpdateViewCommand : ICommand
    {

        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if(parameter.ToString() == "Dishes")
            {
                viewModel.SelectedViewModel = new DishesViewModel();
            }
            else if(parameter.ToString() == "Products")
            {
                viewModel.SelectedViewModel = new ProductsViewModel();
            }
            else if(parameter.ToString() == "Orders")
            {
                viewModel.SelectedViewModel = new OrdersViewModel();
            }
            else if(parameter.ToString() == "Reports")
            {
                viewModel.SelectedViewModel = new ReportsViewModel();
            }
            else if(parameter.ToString() == "Profile")
            {
                viewModel.SelectedViewModel = new ProfileViewModel();
            }
        }
    }
}
