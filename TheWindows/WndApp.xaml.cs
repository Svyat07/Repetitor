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

namespace _004_15Repetitor_26_01_23.TheWindows
{
    /// <summary>
    /// Логика взаимодействия для WndApp.xaml
    /// </summary>
    public partial class WndApp : Window
    {
        public WndApp()
        {
            InitializeComponent();
            TheClasses.Manager.MainFrame = MainFrame;
            MainFrame.Navigate(new ThePages.PgStudents());
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            ThePages.PgStudents pgStudents = new ThePages.PgStudents();
            pgStudents.Visibility = Visibility.Visible;
        }

        private void ImgLogo_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
        #region Кнопки
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            TheWindows.WndAuth wndAuth = new WndAuth();
            wndAuth.Show();
            Close();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnTabStudents_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ThePages.PgStudents());
        }

        private void BtnTabSchedule_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ThePages.PgSchedule());
        }

        private void BtnMyCabinet_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ThePages.PgMyCabinet());
        }
        #endregion

        #region Методы




        #endregion
    }
}
