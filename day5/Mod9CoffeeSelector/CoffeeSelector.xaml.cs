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

namespace Mod9CoffeeSelector
{
    /// <summary>
    /// CoffeeSelector.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CoffeeSelector : UserControl
    {
        private string beverage;
        private string milk;
        public string Order
        {
            get
            {
                return string.Format("{0} with {1}", beverage, milk);
            }
        }
        
        public event EventHandler OrderPlaced;

        public CoffeeSelector()
        {
            InitializeComponent();
        }

        private void radCoffee_Checked(object sender, RoutedEventArgs e)
        {
            beverage = "Coffee";
        }

        private void radTea_Checked(object sender, RoutedEventArgs e)
        {
            beverage = "Tea";
        }

        private void radMilk_Checked(object sender, RoutedEventArgs e)
        {
            milk = "Milk";
        }

        private void radNoMilk_Checked(object sender, RoutedEventArgs e)
        {
            milk = "No Milk";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (OrderPlaced != null)
                OrderPlaced(this, null);
        }
    }
}
