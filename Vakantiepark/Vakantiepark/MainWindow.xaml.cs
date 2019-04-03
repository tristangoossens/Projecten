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

namespace Vakantiepark
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

        private void btnKlant_Click(object sender, RoutedEventArgs e)
        {
            Klanteninvoer kl = new Klanteninvoer();
            kl.Show();
            this.Close();
        }

        private void btnHuis_Click(object sender, RoutedEventArgs e)
        {
            Huizeninvoer hi = new Huizeninvoer();
            hi.Show();
            this.Close();
        }

        private void btnType_Click(object sender, RoutedEventArgs e)
        {
            Huizentypes ht = new Huizentypes();
            ht.Show();
            this.Close();
        }
    }
}
