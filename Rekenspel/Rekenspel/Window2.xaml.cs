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
    
    public partial class Window2 : Window
    {
        int goed = 0;
        int fout = 0;
        public Window2()
        {
            InitializeComponent();
            Random myRandom = new Random();
            int iGetal1 = myRandom.Next(1, 100);
            int iGetal2 = myRandom.Next(1, 100);
            int iUitkomst = iGetal1 + iGetal1;
            lbGetal1.Content = iGetal1.ToString();
            lbGetal2.Content = iGetal2.ToString();
        }

        private void btnPlusTerug_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("Wil je terug naar het hoofdmenu?", "Terug naar menu", MessageBoxButton.YesNo);
            if (m == MessageBoxResult.Yes)
            {
                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }
        }
        private void txtGetal1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnVersturen_Click(object sender, RoutedEventArgs e)
        {
            string sGetal1 = lbGetal1.Content.ToString();
            string sGetal2 = lbGetal2.Content.ToString();

            int iGetal1 = Convert.ToInt32(sGetal1);
            int iGetal2 = Convert.ToInt32(sGetal2);
            


            int iUitkomst = iGetal1 + iGetal2;
            int iAntwoord = Convert.ToInt32(txtAntwoord.Text);
            if (iUitkomst == iAntwoord)
            {
                MessageBox.Show("Je antwoord is goed!!", "Super");
                goed++;
            }
            else
            {
                MessageBox.Show("Je antwoord is fout!!", "Helaas");
                fout++;
            }
            txtAntwoord.Text = "";
            Random myRandom = new Random();
            int iNewGetal1 = myRandom.Next(1, 100);
            int iNewGetal2 = myRandom.Next(1, 100);
            lbGetal1.Content = iNewGetal1.ToString();
            lbGetal2.Content = iNewGetal2.ToString();

            if (goed == 5 )
            {
                MessageBox.Show("Je bent klaar!\nGoede antwoorden: " + goed + "\nFoute antwoorden: " + fout);
                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }
            
        }
    }
}
