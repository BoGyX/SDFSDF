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
using ABBA.WILDBERDataSetTableAdapters;
namespace ABBA
{
 
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void first(object sender, RoutedEventArgs e)
        {
            Pokupki pok = new Pokupki();
            this.Content = pok;
        }

        private void second(object sender, RoutedEventArgs e)
        {
            Pokupateli buy = new Pokupateli();
            this.Content = buy;
        }
    }
}
