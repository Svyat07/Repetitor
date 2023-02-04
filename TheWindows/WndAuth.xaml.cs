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
    /// Логика взаимодействия для WndAuth.xaml
    /// </summary>
    public partial class WndAuth : Window
    {
        public WndAuth()
        {
            InitializeComponent();
        }

        private void BtnSign_Click(object sender, RoutedEventArgs e)
        {
            if (TheClasses.ClassAuth.Auth(tbLogin.Text, pbPassword.Password))
            {
                Close();
            }
            else 
            {

            }
            
        }

        private void BtnEye_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbPassword.Text = pbPassword.Password;
            tbPassword.Visibility = Visibility.Visible;
        }

        private void BtnEye_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbPassword.Visibility = Visibility.Collapsed;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
