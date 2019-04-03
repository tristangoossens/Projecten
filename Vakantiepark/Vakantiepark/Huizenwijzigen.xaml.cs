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
    /// Interaction logic for Huizenwijzigen.xaml
    /// </summary>
    public partial class Huizenwijzigen : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Huizenwijzigen()
        {
            databaseDataContext db = new databaseDataContext();
            InitializeComponent();

            cbType.ItemsSource = db.housetypes;
            cbType.DisplayMemberPath = "type";

            cbGrootte.ItemsSource = db.housesizes;
            cbGrootte.DisplayMemberPath = "size";
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            int ID = Convert.ToInt32(lbID.Content);

            MessageBoxResult m = MessageBox.Show("Weet je zeker dat je het huis met id " + ID + " wilt wijzigen?", "Huis wijzigen", MessageBoxButton.YesNo);
            if (m == MessageBoxResult.Yes)
            {

                house huis = (from house in db.houses
                              where house.id == ID
                              select house).Single();

                huis.housetype = (housetype)cbType.SelectedItem;
                huis.housesize = (housesize)cbGrootte.SelectedItem;
                huis.name = txtNummer.Text;
                huis.price = Convert.ToDecimal(txtPrijs.Text);
            
                db.SubmitChanges();
            }
            Huizeninvoer hi = new Huizeninvoer();
            hi.Show();
            hi.dgHuizen.ItemsSource = db.houses.ToList();
            this.Close();
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            int ID = Convert.ToInt32(lbID.Content);

            MessageBoxResult m = MessageBox.Show("Weet je zeker dat je de klant met id " + ID + " wilt verwijderen?", "Klant verwijderen", MessageBoxButton.YesNo);
            if (m == MessageBoxResult.Yes)
            {

                house huis = (from house in db.houses
                              where house.id == ID
                              select house).Single();

                db.houses.DeleteOnSubmit(huis);
                db.SubmitChanges();
            }
            Huizeninvoer hi = new Huizeninvoer();
            hi.Show();
            hi.dgHuizen.ItemsSource = db.houses.ToList();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Huizeninvoer hi = new Huizeninvoer();
            hi.Show();
            this.Close();
        }
    }
}
