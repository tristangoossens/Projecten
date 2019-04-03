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
    /// Interaction logic for Bestellingsinvoer.xaml
    /// </summary>
    public partial class Bestellingsinvoer : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Bestellingsinvoer()
        {
            InitializeComponent();

            dgItemsinorder.ItemsSource = db.itemsinorders;

            cbKlant.ItemsSource = db.customers;
            cbKlant.DisplayMemberPath = "lastname";

            cbProduct.ItemsSource = db.products;
            cbProduct.DisplayMemberPath = "name";
           
            dgOrder.ItemsSource = db.orders;

            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
        }

        private void btnBterug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }

        private void btnBinvoer_Click(object sender, RoutedEventArgs e)
        {
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;

            order o = new order();
            itemsinorder iio = new itemsinorder();

            iio.product = (product)cbProduct.SelectedItem;
            iio.amount = txtHoeveelheid.Text;
            iio.order = o;

            
            o.customer = (customer)cbKlant.SelectedItem;
            o.date = DateTime.Now.Date;
            
            db.itemsinorders.InsertOnSubmit(iio);
            db.orders.InsertOnSubmit(o);
            db.SubmitChanges();

            dgItemsinorder.ItemsSource = db.itemsinorders;
            dgOrder.ItemsSource = db.orders;

            MessageBox.Show("De bestelling van" + " " + cbKlant.Text + " " + "is toegevoegd aan de database", "Gelukt!");

            Bestellingsinvoer bi = new Bestellingsinvoer();
            bi.Show();
            this.Close();

            MessageBoxResult m = MessageBox.Show("Wil je een factuur maken", "Factuur", MessageBoxButton.YesNo);
            if (m == MessageBoxResult.Yes)
            {
                Factuur f = new Factuur();
                f.Show();
                this.Close();
            }
        }
    }
}
