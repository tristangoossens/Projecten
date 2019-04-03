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
    /// Interaction logic for Klanteninvoer.xaml
    /// </summary>
    public partial class Klanteninvoer : Window
    {
        databaseDataContext db = new databaseDataContext();

        public Klanteninvoer()
        {
            InitializeComponent();

            dgKlant.ItemsSource = db.customers;
        }

        private void btnInvoer_Click(object sender, RoutedEventArgs e)
        {
            customer c = new customer();
            c.firstname = txtVoornaam.Text;
            c.lastname = txtAchternaam.Text;

            string dateString = this.dpGeboortedatum.Text;
            DateTime Date = Convert.ToDateTime(dateString.ToString());

            c.birthdate = Date;
            c.city = txtWoonplaats.Text;
            c.phonenumber = txtTelefoonnummer.Text;
            c.email = txtEmail.Text;

            db.customers.InsertOnSubmit(c);
            db.SubmitChanges();

            MessageBox.Show("De klant " + c.firstname + " " + c.lastname + " is toegevoegd", "Gelukt");

            dgKlant.ItemsSource = db.customers.ToList();

            txtVoornaam.Text = "";
            txtAchternaam.Text = "";
            txtWoonplaats.Text = "";
            txtTelefoonnummer.Text = "";
            txtEmail.Text = "";
            dpGeboortedatum.Text = "";


        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("Weet je zeker dat je terug wil gaan naar heb menu?" + "\n" + "De gevevens zullen verloren gaan!", "Terug naar menu", MessageBoxButton.YesNo);
            if (m == MessageBoxResult.Yes)
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
        }

        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {
            KlantenWijzigen kl = new KlantenWijzigen();
            kl.Show();
            this.Close();
        }
        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            KlantenWijzigen kw = new KlantenWijzigen();
            kw.Show();
            this.Close();

            var deKlant = (customer)dgKlant.SelectedItem;
            kw.lbID.Content = deKlant.id.ToString();
            kw.txtVoornaam.Text = deKlant.firstname;
            kw.dpGeboortedatum.SelectedDate = deKlant.birthdate;
            kw.txtAchternaam.Text = deKlant.lastname;
            kw.txtTelefoon.Text = deKlant.phonenumber;
            kw.txtWoonplaats.Text = deKlant.city;
            kw.txtEmail.Text = deKlant.email;
        }

        private void btnZoek_Click(object sender, RoutedEventArgs e)
        {
            if (txtZoek.Text == "")
            {
                dgKlant.ItemsSource = db.customers.ToList();
            }

            int id = 0;
            if (Int32.TryParse(txtZoek.Text.ToString(), out id))
            {
                var deKlant = (from customer in db.customers
                               where customer.id == id
                               select customer).ToList();
                if (deKlant.Count > 0)
                {
                    dgKlant.ItemsSource = deKlant;
                }
                else
                {
                    MessageBox.Show("Er is geen gebruiker met id " + id + " gevonden!", "Fout!");
                    dgKlant.ItemsSource = db.customers.ToList();
                }
            }
        }
    }
}

