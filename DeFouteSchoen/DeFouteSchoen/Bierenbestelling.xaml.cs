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
    /// Interaction logic for Bierenbestelling.xaml
    /// </summary>
    public partial class Bierenbestelling : Window
    {
        databaseDataContext db = new databaseDataContext();

        public Bierenbestelling()
        {
            InitializeComponent();
            dgBestelling.ItemsSource = db.purchases.ToList();
            cbBier.ItemsSource = db.beers.ToList();
            cbBier.DisplayMemberPath = "name";
        }

        private void btnBestelling_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtHoeveelheid.Text, out int amount))
            {

                var DatumEnTijd = DateTime.Now;
                var Datum = DatumEnTijd.Date;

                purchase p = new purchase();               

                p.beer = (beer)cbBier.SelectedItem;
                p.date = Datum;
                p.amount = amount;


                string s = cbBier.Text;
                beer b = (from beer in db.beers
                          where beer.name == s
                          select beer).Single();

                b.purchasecount = 1 * amount + b.purchasecount;

                
                db.purchases.InsertOnSubmit(p);
                db.SubmitChanges();

                dgBestelling.ItemsSource = db.purchases.ToList();
                                

                cbBier.Text = "";
                txtHoeveelheid.Text = "";

            }
            else
            {
                MessageBox.Show("Vul een geldig getal in", "Fout!");
            }

        }

    }
}
