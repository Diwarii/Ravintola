using Ravintola.ViewModels;
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

namespace Ravintola.Views
{
    /// <summary>
    /// Логика взаимодействия для RemoveProductView.xaml
    /// </summary>
    public partial class RemoveProductView : Window
    {
        public RemoveProductView()
        {
            InitializeComponent();
            DataContext = new ProductsViewModel();
        }
    }
}
