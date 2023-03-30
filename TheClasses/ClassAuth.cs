using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _004_15Repetitor_26_01_23.TheClasses
{
    class ClassAuth
    {
        public static bool Auth(string Login, string Password)
        {
            var db = Entities.RepDBEntities.GetContext();
            var sign = from user in db.Repetitors
                       where user.Login == Login
                       where user.Password == Password
                       select user;
            try
            {
                if (sign == null || !sign.Any())
                {
                    Password = "";
                    MessageBox.Show("Неверны логин или пароль!",
                    "Сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                    return false;
                }
                else
                {
                    Password = "";
                    Login = "";
                    TheWindows.WndApp windowStart = new TheWindows.WndApp();
                    windowStart.Show();
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Нет соединения с сервером", "Внимание! Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
           
        }
    }
}
