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

namespace DeFouteSchoen
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

        private void btnBieren_Click(object sender, RoutedEventArgs e)
        {
            Biereninvoer bi = new Biereninvoer();
            bi.Show();
            this.Close();
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            Bierenwijzigen bw = new Bierenwijzigen();
            bw.Show();
            this.Close();
        }

        private void btnBestelling_Click(object sender, RoutedEventArgs e)
        {
            Bierenbestelling bb = new Bierenbestelling();
            bb.Show();
            this.Close();
        }

        private void btnTop_Click(object sender, RoutedEventArgs e)
        {
            Bierenbestverkocht bbv = new Bierenbestverkocht();
            bbv.Show();
            this.Close();
        }
    }
}
