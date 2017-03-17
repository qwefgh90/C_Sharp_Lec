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

namespace Mod10Task
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public String GetCurrentTime()
        {
            System.Threading.Thread.Sleep(5000);
            label1.Dispatcher.BeginInvoke(new Action(() => UIUpdate(DateTime.Now.ToString())));
            return DateTime.Now.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Task t = new Task(new Action(GetCurrentTime));
            Task<String> t = new Task<String>(GetCurrentTime);
            t.Start();
            //MessageBox.Show("Hello");
        }

        public void UIUpdate(String time)
        {
            label1.Content = time;
        }

        private async void btn2_Click(object sender, RoutedEventArgs e)
        {
            Task<String> t1 = new Task<String>(GetCurrentTime);
            t1.Start();
            label2.Content = await t1;  
        }
    }
}
