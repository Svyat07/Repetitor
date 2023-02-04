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

namespace _004_15Repetitor_26_01_23.ThePages
{
    /// <summary>
    /// Логика взаимодействия для PgEditPassword.xaml
    /// </summary>
    public partial class PgEditPassword : Page
    {          
        string CurrentPassword = "w";

        public PgEditPassword()
        {
            InitializeComponent();
        }
        #region Кнопки
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            TheClasses.Manager.MainFrame.GoBack();
        }

        private void BtnEye_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbCurrentPassword.Text = pbCurrentPassword.Password;
            tbCurrentPassword.Visibility = Visibility.Visible;
        }

        private void BtnEye_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbCurrentPassword.Visibility = Visibility.Collapsed;
        }
        private void BtnEyeNew_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbNewPassword.Text = pbNewPassword.Password;
            tbNewPassword.Visibility = Visibility.Visible;
        }

        private void BtnEyeNew_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbNewPassword.Visibility = Visibility.Collapsed;
        }

        private void BtnEyeAgain_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbAgainPassword.Text = pbAgainPassword.Password;
            tbAgainPassword.Visibility = Visibility.Visible;
        }

        private void BtnEyeAgain_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbAgainPassword.Visibility = Visibility.Hidden;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if(pbCurrentPassword.Password != CurrentPassword)
            {
                pbCurrentPassword.BorderThickness = new Thickness(5);
                pbCurrentPassword.BorderBrush = Brushes.Red;
                MessageBox.Show("неверный пароль");
            }
            else if(pbNewPassword.Password != pbAgainPassword.Password)
            {
                pbNewPassword.BorderThickness = new Thickness(5);
                pbAgainPassword.BorderThickness = new Thickness(5);
                pbNewPassword.BorderBrush = Brushes.Red;
                pbAgainPassword.BorderBrush = Brushes.Red;
                MessageBox.Show("Пароли не совпадают");
            }
            else
            {
                if(pbAgainPassword.Password == pbCurrentPassword.Password && pbNewPassword.Password == pbCurrentPassword.Password)
                {
                    MessageBox.Show("Это ваш текщий пароль");
                }
            }
        }
        #endregion

        
    }
}
