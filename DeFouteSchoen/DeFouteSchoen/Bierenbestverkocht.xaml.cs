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

namespace DeFouteSchoen
{
    /// <summary>
    /// Interaction logic for Bierenbestverkocht.xaml
    /// </summary>
    public partial class Bierenbestverkocht : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Bierenbestverkocht()
        {
            InitializeComponent();
            dgBieren.ItemsSource = db.beers;           
        }                
    }
}
