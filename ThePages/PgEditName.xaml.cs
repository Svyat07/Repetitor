﻿using System;
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
    /// Логика взаимодействия для PgEditName.xaml
    /// </summary>
    public partial class PgEditName : Page
    {
        public PgEditName(string Name)
        {
            InitializeComponent();
            tbName.Text = Name;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            TheClasses.Manager.MainFrame.GoBack();
        }
    }
}
