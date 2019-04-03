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
    /// <summary>
    /// Interaction logic for Klanteninvoer.xaml
    /// </summary>
    public partial class Klanteninvoer : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Klanteninvoer()
        {
            InitializeComponent();
            dgKlant.ItemsSource = db.customers.ToList();
        }

        private void btnKinvoer_Click(object sender, RoutedEventArgs e)
        {
            customer klant = new customer();
            klant.firstname = txtFirstname.Text;
            klant.lastname = txtLastname.Text;
            klant.city = txtCity.Text;
            klant.phonenumber = txtPhonenumber.Text;
            if (txtEmail.Text != null)
            {
                klant.email = txtEmail.Text;
            }
            else
            {
                klant.email = "";
            }

            db.customers.InsertOnSubmit(klant);
            db.SubmitChanges();

            dgKlant.ItemsSource = db.customers.ToList();

            MessageBox.Show("De nieuwe klant" + " " + txtFirstname.Text + " " + "is toegevoed aan de database", "Gelukt!");

            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtCity.Text = "";
            txtPhonenumber.Text = "";
            txtEmail.Text = "";
        }

        private void btnKmenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menu = new MainWindow();
            menu.Show();
            this.Close();
        }
    }
}
