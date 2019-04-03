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

namespace Rekenspel
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("Weet je zeker dat je wil afsluiten?", "Afsluiten", MessageBoxButton.YesNo);
            if (m == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTerugMenu_Click(object sender, RoutedEventArgs e)
        {

          MessageBoxResult m = MessageBox.Show("Wil je terug naar het hoofdmenu?", "Terug naar menu", MessageBoxButton.YesNo);
          if (m == MessageBoxResult.Yes)
          {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
          }
            
        }

        private void btnPlussommen_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }

        private void btnKeersommen_Click(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
            this.Close();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Close();
        }
    }
}
