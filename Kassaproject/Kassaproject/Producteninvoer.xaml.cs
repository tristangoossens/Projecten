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
    /// Interaction logic for Producteninvoer.xaml
    /// </summary>
    public partial class Producteninvoer : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Producteninvoer()
        {
            InitializeComponent();            
            cbType.ItemsSource = db.producttypes;
            dgProducten.ItemsSource = db.products;
            cbType.DisplayMemberPath = "type";
        }

        private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbType.SelectedItem != null)
            {
                producttype type = (producttype)cbType.SelectedItem;                
            }
        }

        private void btnPinvoer_Click(object sender, RoutedEventArgs e)
        {
            DateTime nu = new DateTime();
            product p = new product();
            p.name = txtProductnaam.Text;
            p.producttype = (producttype)cbType.SelectedItem;
            pricehistory ph = new pricehistory();

            int prijs;
            int.TryParse(txtPrijs.Text, out prijs);

            ph.price = prijs;
            ph.startdate = DateTime.Now.Date;

            ph.product = p;
            db.products.InsertOnSubmit(p);
            db.pricehistories.InsertOnSubmit(ph);
            db.SubmitChanges();

            dgProducten.ItemsSource = db.products;
            Producteninvoer pi = new Producteninvoer();
            pi.Show();
            this.Close();

            MessageBox.Show("Het product " + " " + txtProductnaam.Text + " " + "is toegevoegd aan de database", "Gelukt!");           
           
        }        


        private void btnPterug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
