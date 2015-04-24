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

namespace EnterpriseWPF
{
    /// <summary>
    /// Interaction logic for OneWayBinding.xaml
    /// </summary>
    public partial class OneWayBinding : Window
    {
        private Employee _emp;

        public OneWayBinding()
        {
            InitializeComponent();
            _emp = new Employee
            {
                Name = "Roger",
                Title = "Senior Software Engineer"
            };
            DataContext = _emp;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _emp.Name = "James";
            _emp.Title = "Software Engineer";
        }
    }
}
