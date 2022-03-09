using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _14_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();          
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Шоколад",
                ProductPrice = 200,
                Priority = 2,
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Чайник",
                ProductPrice = 3500,
                Priority = 1,
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Тостер",
                ProductPrice = 4200,
                Priority = 1,
                ProductType = ProductTypes.Appliances
            });
            lstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                ProductPrice = 45,
                Priority = 2,
                ProductType = ProductTypes.Food
            });
        }
    }
}