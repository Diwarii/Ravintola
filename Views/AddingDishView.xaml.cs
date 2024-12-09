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
    public partial class AddingDishView : Window
    {
        public Dish Dish { get; private set; }

        public AddingDishView(Dish dish)
        {
            InitializeComponent();
            Dish = dish;
            DataContext = Dish;
        }
        public AddingDishView()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
