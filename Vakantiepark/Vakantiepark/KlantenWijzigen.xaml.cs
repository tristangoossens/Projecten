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
    /// Interaction logic for KlantenWijzigen.xaml
    /// </summary>
    public partial class KlantenWijzigen : Window
    {
        databaseDataContext db = new databaseDataContext();

        public KlantenWijzigen()
        {
            InitializeComponent();

        }

        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {

            int ID = Convert.ToInt32(lbID.Content);

            MessageBoxResult m = MessageBox.Show("Weet je zeker dat je de klant met id " + ID + " wilt wijzigen?", "Klant wijzigen", MessageBoxButton.YesNo);
            if (m == MessageBoxResult.Yes)
            {              

                customer klant = (from customer in db.customers
                                  where customer.id == ID
                                  select customer).Single();
                       
                klant.firstname = txtVoornaam.Text;
                klant.lastname = txtAchternaam.Text;
                klant.phonenumber = txtTelefoon.Text;
                klant.email = txtEmail.Text;
                klant.city = txtWoonplaats.Text;

                string dateString = this.dpGeboortedatum.Text;
                DateTime Date = Convert.ToDateTime(dateString.ToString());
                klant.birthdate = Date;


                db.SubmitChanges();
            }
            Klanteninvoer kli = new Klanteninvoer();
            kli.Show();
            kli.dgKlant.ItemsSource = db.customers.ToList();
            this.Close();

        }
        private void btnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            Klanteninvoer kli = new Klanteninvoer();
            var deKlant = (customer)kli.dgKlant.SelectedItem;
            int ID = deKlant.id;

            MessageBoxResult m = MessageBox.Show("Weet je zeker dat je de klant met id " + ID + " wilt verwijderen?", "Klant verwijderen", MessageBoxButton.YesNo);
            if (m == MessageBoxResult.Yes)
            {

                customer klant = (from customer in db.customers
                                  where customer.id == ID
                                  select customer).Single();
                
                db.customers.DeleteOnSubmit(deKlant);
                db.SubmitChanges();
            }
            kli.Show();
            kli.dgKlant.ItemsSource = db.customers.ToList();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Klanteninvoer kl = new Klanteninvoer();
            kl.Show();
            this.Close();
        }
    }
}
