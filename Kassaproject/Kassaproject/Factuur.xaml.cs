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

namespace Kassaproject
{
    
    public partial class Factuur : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Factuur()
        {
            InitializeComponent();            
            cbKlant.ItemsSource = db.customers;
            cbKlant.DisplayMemberPath = "lastname";      
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtGegevens.Text != "")
            {
                MessageBox.Show("Je kunt de gegevens maar een keer ophalen!!", "Fout!");
            }
            else
            {


                if (cbKlant.SelectedItem != null)
                {
                    customer myCustomer = (customer)cbKlant.SelectedItem;
                    txtGegevens.Text += "Voornaam: " + myCustomer.firstname + Environment.NewLine;
                    txtGegevens.Text += "Achternaam: " + myCustomer.lastname + Environment.NewLine;
                    txtGegevens.Text += "Woonplaats: " + myCustomer.city + Environment.NewLine;
                    txtGegevens.Text += "Telefoonnummer " + myCustomer.phonenumber + Environment.NewLine;
                    txtGegevens.Text += "E-mail adres: " + myCustomer.email + Environment.NewLine;

                }
                else
                {
                    MessageBox.Show("Kies eerst een klant", "Fout!");
                }
            }
        }   

        public decimal getPrice(itemsinorder item, DateTime date)
        {
            foreach (pricehistory price in item.product.pricehistories){
                if (date >= price.startdate && (date <= price.enddate || price.enddate == null))
                {
                    return price.price;
                }
            }
            return 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtBestelling.Text = "";
            decimal ttlPrijs = 0;

            if (cbKlant.SelectedItem != null)
            {
                foreach (order ord in ((customer)cbKlant.SelectedItem).orders)
                {
                    foreach (itemsinorder item in ord.itemsinorders)
                    {
                        decimal prijs = getPrice(item, ord.date);
                        ttlPrijs += (prijs * Convert.ToInt32(item.amount));

                        if (ord.date == dpDatum.SelectedDate)
                        {
                            txtBestelling.Text += "x" + item.amount + " " + item.product.name + " €" + (prijs * Convert.ToInt32(item.amount)) + " " + ord.date.ToShortDateString() + Environment.NewLine;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Kies eerst een klant!", "Fout!");
            }
        }

        private void btnFactuur_Click(object sender, RoutedEventArgs e)
        {
            lbKosten.Content = "";
            lbGegevens.Content = "";
            lbKosten.Content = "";
            if (dpDatum.SelectedDate != null)
            {

                if (cbKlant.SelectedItem != null)
                {
                    customer myCustomer = (customer)cbKlant.SelectedItem;
                    lbGegevens.Content += "";
                    lbGegevens.Content += "Voornaam: " + myCustomer.firstname + Environment.NewLine;
                    lbGegevens.Content += "Achternaam: " + myCustomer.lastname + Environment.NewLine;
                    lbGegevens.Content += "Woonplaats: " + myCustomer.city + Environment.NewLine;
                    lbGegevens.Content += "Telefoonnummer " + myCustomer.phonenumber + Environment.NewLine;
                    lbGegevens.Content += "E-mail adres: " + myCustomer.email + Environment.NewLine;

                    decimal ttlPrijs = 0;
                    foreach (order ord in ((customer)cbKlant.SelectedItem).orders)
                    {
                        foreach (itemsinorder item in ord.itemsinorders)
                        {
                            decimal prijs = getPrice(item, ord.date);
                            decimal productPrijs = prijs * Convert.ToInt32(item.amount);
                            ttlPrijs += (prijs * Convert.ToInt32(item.amount));

                            if (ord.date == dpDatum.SelectedDate)
                            {
                                lbKosten.Content += "x " + item.amount + " " + item.product.name + " €" + productPrijs.ToString("0.00") + " " + ord.date.ToShortDateString() + Environment.NewLine;


                            }
                        }
                    }

                    imgLogo.Visibility = Visibility.Visible;
                    lbBedrijf.Visibility = Visibility.Visible;
                    lbGegevenslb.Visibility = Visibility.Visible;
                    lbKostenlb.Visibility = Visibility.Visible;
                    lbIBAN.Visibility = Visibility.Visible;

                    lbKosten.Content += Environment.NewLine;
                    lbKosten.Content += "================================\n";
                    lbKosten.Content += "Totaal: € " + ttlPrijs.ToString("0.00") + "\n";
                    lbKosten.Content += "================================";
                }
                else
                {
                    MessageBox.Show("Kies eerst een klant", "Fout!");
                }
            }
            else
            {               
                    MessageBox.Show("Vul eerst een datum in", "Fout!");                
            }          
        }

        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
