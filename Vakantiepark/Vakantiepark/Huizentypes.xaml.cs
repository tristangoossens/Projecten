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

namespace Vakantiepark
{
    /// <summary>
    /// Interaction logic for Huizentypes.xaml
    /// </summary>
    public partial class Huizentypes : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Huizentypes()
        {
            InitializeComponent();
            lbTypes.ItemsSource = db.housetypes.ToList();
            lbGrootte.ItemsSource = db.housesizes.ToList();
        }

        private void btnType_Click(object sender, RoutedEventArgs e)
        {
            Huizentypeswijzigen htw = new Huizentypeswijzigen();
            htw.Show();
            htw.lbID.Visibility = Visibility.Hidden;
            htw.btnVerwijder.Visibility = Visibility.Hidden;
            htw.btnWijzig.Visibility = Visibility.Hidden;
            htw.lbIDt.Visibility = Visibility.Hidden;
            this.Close();
        }

        private void lbTypes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Huizentypeswijzigen htw = new Huizentypeswijzigen();
            htw.Show();
            htw.btnToevoegen.Visibility = Visibility.Hidden;
            var hetHuis = (housetype)lbTypes.SelectedItem;
            htw.txtType.Text = hetHuis.type;
            htw.lbID.Content = hetHuis.id;
            this.Close();
        }

        private void btnGrootte_Click(object sender, RoutedEventArgs e)
        {
            Huisgroottewijzigen hgw = new Huisgroottewijzigen();
            hgw.Show();
            hgw.lbID.Visibility = Visibility.Hidden;
            hgw.btnVerwijderen.Visibility = Visibility.Hidden;
            hgw.btnWijzigen.Visibility = Visibility.Hidden;
            hgw.lbIDt.Visibility = Visibility.Hidden;
            this.Close();
        }

        private void lbGrootte_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Huisgroottewijzigen hgw = new Huisgroottewijzigen();
            var hetHuis = (housesize)lbGrootte.SelectedItem;
            hgw.Show();
            hgw.btnToevoegen.Visibility = Visibility.Hidden;
            hgw.lbID.Content = hetHuis.id;
            hgw.txtGrootte.Text = hetHuis.size;
            this.Close();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
