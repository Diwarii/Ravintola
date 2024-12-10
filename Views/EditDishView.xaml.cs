using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Ravintola.ViewModels;
using Ravintola.Models;

namespace Ravintola.Views
{
    /// <summary>
    /// Логика взаимодействия для EditDishView.xaml
    /// </summary>
    public partial class EditDishView : Window
    {
        public EditDishView()
        {
            InitializeComponent();
            DataContext = new DishesViewModel();
        }
        public Dish Dish { get; private set; }
        public EditDishView(Dish dish)
        {
            InitializeComponent();
            Dish = dish;
            DataContext = Dish;
        }
    }
}
