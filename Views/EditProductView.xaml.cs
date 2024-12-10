using Ravintola.ViewModels;
using Ravintola.Models;
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
    /// Логика взаимодействия для EditProductView.xaml
    /// </summary>
    public partial class EditProductView : Window
    {
        public EditProductView()
        {
            InitializeComponent();
            DataContext = new ProductsViewModel();
        }

        public Product Product { get; private set; }
        public EditProductView(Product product)
        {
            InitializeComponent();
            Product = product;
            DataContext = Product;
        }

    }
}
