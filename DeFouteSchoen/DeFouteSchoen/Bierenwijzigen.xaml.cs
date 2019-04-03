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
    /// Interaction logic for Bierenwijzigen.xaml
    /// </summary>
    public partial class Bierenwijzigen : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Bierenwijzigen()
        {

            InitializeComponent();
            cbType.ItemsSource = db.beertypes;
            cbType.DisplayMemberPath = "type";
            dgWijzigen.ItemsSource = db.beers.ToList();
        }

        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {
            if (dgWijzigen.SelectedItem != null)
            {
                var bier = (beer)dgWijzigen.SelectedItem;
                int ID = bier.id;

                MessageBoxResult m = MessageBox.Show("Weet je zeker dat je de bier met id " + ID + " wilt wijzigen?", "Bier wijzigen", MessageBoxButton.YesNo);
                if (m == MessageBoxResult.Yes)
                {

                    beer b = (from beer in db.beers
                              where beer.id == ID
                              select beer).Single();

                    b.name = txtNaam.Text;
                    b.beertype = (beertype)cbType.SelectedItem;
                    b.price = Convert.ToDecimal(txtPrijs.Text);

                    db.SubmitChanges();
                }

                dgWijzigen.ItemsSource = db.beers.ToList();
                txtNaam.Text = "";
                txtPrijs.Text = "";
                cbType.Text = "";

            }
            else
            {
                MessageBox.Show("Selecteer eerst een klant", "Fout!");
            }
        }


        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            var lijst = (beer)dgWijzigen.SelectedItem;
            txtNaam.Text = lijst.name;
            cbType.SelectedValuePath = "type";
            cbType.SelectedValue = lijst.beertype.type;
            lbId.Content = lijst.id;

            decimal prijs = lijst.price;
            txtPrijs.Text = Convert.ToString(prijs);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var lijst = (beer)dgWijzigen.SelectedItem;
            txtNaam.Text = lijst.name;
            cbType.SelectedValuePath = "type";
            cbType.SelectedValue = lijst.beertype.type;
            lbId.Content = lijst.id;
            decimal prijs = lijst.price;
            txtPrijs.Text = Convert.ToString(prijs);
        }

        private void btnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            if (dgWijzigen.SelectedItem != null)
            {


                var bier = (beer)dgWijzigen.SelectedItem;
                int ID = bier.id;
                MessageBoxResult r = MessageBox.Show("Weet je zeker dat je bier met id " + ID + " wilt verwijderen", "Bier verwijderen", MessageBoxButton.YesNo);
                if (r == MessageBoxResult.Yes)
                {

                    beer b = (from beer in db.beers
                              where beer.id == ID
                              select beer).Single();

                    db.beers.DeleteOnSubmit(b);
                    db.SubmitChanges();
                }

                dgWijzigen.ItemsSource = db.beers.ToList();
                txtNaam.Text = "";
                txtPrijs.Text = "";
                cbType.Text = "";
            }
            else
            {
                MessageBox.Show("Selecteer eerst een klant", "Fout!");
            }
        }
    }
}
