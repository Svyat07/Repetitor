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
    /// Логика взаимодействия для PgAddEdit.xaml
    /// </summary>
    public partial class PgAddEdit : Page
    {
        private Entities.Student _currentStudent = new Entities.Student();
        public PgAddEdit(Entities.Student selectedStudent)
        {
            InitializeComponent();
            if (_currentStudent != null)
                _currentStudent = selectedStudent;

            DataContext = _currentStudent;
        }
    }
}
