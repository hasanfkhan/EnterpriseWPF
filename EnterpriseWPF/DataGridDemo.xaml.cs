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
    /// Interaction logic for DataGridDemo.xaml
    /// </summary>
    public partial class DataGridDemo : Window
    {
        public DataGridDemo()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Employee.GetEmployees();
        }
    }
}
