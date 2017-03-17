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

namespace Mod9Binding
{
    class Coffee
    {
        public string Name { get; set; }
        public string Bean { get; set; }
        public Coffee()
        {

        }
        public Coffee(string n, string b)
        {
            Name = n;
            Bean = b;
        }
    }
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Coffee c1 = new Coffee("StartBucks", "Arbica");
            Binding b = new Binding();
            b.Source = c1;
            b.Path = new PropertyPath("Name");
            textBlock1.SetBinding(TextBlock.TextProperty, b);
        }
    }
}
