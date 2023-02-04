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
            if(Login == "w" && Password == "w")
            {
                TheWindows.WndApp wndApp = new TheWindows.WndApp();
                wndApp.Show();
                return true;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return false;
            }
        }
    }
}
