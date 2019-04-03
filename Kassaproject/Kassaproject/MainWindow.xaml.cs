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

namespace Kassaproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnKlanten_Click(object sender, RoutedEventArgs e)
        {
            Window klant = new Klanteninvoer();
            klant.Show();
            this.Close();
        }

        private void btnProducten_Click(object sender, RoutedEventArgs e)
        {
            Producteninvoer producten = new Producteninvoer();
            producten.Show();
            this.Close();
        }

        private void btnBestel_Click(object sender, RoutedEventArgs e)
        {
            Bestellingsinvoer bestelling = new Bestellingsinvoer();
            bestelling.Show();
            this.Close();
        }

        private void btnFactuur_Click(object sender, RoutedEventArgs e)
        {
            Factuur f = new Factuur();
            f.Show();
            this.Close();           
        }
    }
}
