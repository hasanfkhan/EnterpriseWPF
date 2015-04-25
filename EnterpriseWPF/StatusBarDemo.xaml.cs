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
    /// Interaction logic for StatusBarDemo.xaml
    /// </summary>
    public partial class StatusBarDemo : Window
    {
        public StatusBarDemo()
        {
            InitializeComponent();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a help dialog");
        }
    }
}
