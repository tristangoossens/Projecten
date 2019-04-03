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

namespace Rekenspel
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

        private void btnMenuAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("Weet je zeker dat je wil afsluiten?", "Afsluiten", MessageBoxButton.YesNo);
            if (m == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }


        private void btnMenuStart_Click(object sender, RoutedEventArgs e)
        {
            Window1 Mainwindow = new Window1();
            Mainwindow.Show();
            this.Close();
        }

        private void btnSecret_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer Mcd = new System.Media.SoundPlayer(@"C:\Users\trist\Desktop\ppanther.wav");
            Mcd.Play();
           

        }
    }
}
