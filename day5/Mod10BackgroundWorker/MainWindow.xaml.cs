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
using System.ComponentModel;

namespace Mod10BackgroundWorker
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            worker.DoWork += bw_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Content = e.Result.ToString() ;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = GetCurrentTime();
        }

        private BackgroundWorker worker = new BackgroundWorker();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            worker.RunWorkerAsync();
            MessageBox.Show("Done");
        }

        public string GetCurrentTime()
        {
            System.Threading.Thread.Sleep(5000);
            string s = DateTime.Now.ToString();
            return s;
    //        label1.Content = s;
        }
    }
}
