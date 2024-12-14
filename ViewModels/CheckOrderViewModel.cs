using Microsoft.EntityFrameworkCore;
using Ravintola.Models;
using Ravintola.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Ravintola.ViewModels
{
    public class CheckOrderViewModel : BaseViewModel
    {
        public ObservableCollection<Dish> Dishes { get; set; }

        public CheckOrderViewModel()
        {
            Dishes = new ObservableCollection<Dish>();
        }
    }
}
