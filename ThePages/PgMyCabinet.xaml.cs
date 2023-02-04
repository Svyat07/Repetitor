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
    /// Логика взаимодействия для PgMyCabinet.xaml
    /// </summary>
    public partial class PgMyCabinet : Page
    {
        public PgMyCabinet()
        {
            InitializeComponent();
            string name = "Иван Иванович Иванов";
            TbName.Text = name;
        }
        #region Кнопки
        private void BtnEditName_Click(object sender, RoutedEventArgs e)
        {
            TheClasses.Manager.MainFrame.Navigate(new ThePages.PgEditName(TbName.Text));
        }

        private void BtnEditPassword_Click(object sender, RoutedEventArgs e)
        {
            TheClasses.Manager.MainFrame.Navigate(new ThePages.PgEditPassword());
        }

        private void BtnEditPhoto_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
