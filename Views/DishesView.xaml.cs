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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using Ravintola.ViewModels;

namespace Ravintola.Views
{
    /// <summary>
    /// Логика взаимодействия для DishesView.xaml
    /// </summary>
    public partial class DishesView : UserControl
    {
        public DishesView()
        {
            InitializeComponent();
            DataContext = new DishesViewModel();
        }
    }
}
