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
    /// Interaction logic for DataConversion.xaml
    /// </summary>
    public partial class DataConversion : Window
    {
        public DataConversion()
        {
            InitializeComponent();
            DataContext = new Employee("Hasan Fahim", "Software Developer", new DateTime(2009, 6, 1));
        }
    }
}
