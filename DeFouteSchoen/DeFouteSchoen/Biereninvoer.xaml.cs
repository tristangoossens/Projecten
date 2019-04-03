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
    /// Interaction logic for Biereninvoer.xaml
    /// </summary>
    public partial class Biereninvoer : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Biereninvoer()
        {
            InitializeComponent();
            dgBieren.ItemsSource = db.beers;
            cbType.ItemsSource = db.beertypes;
            cbType.DisplayMemberPath = "type";
        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            if (cbType.SelectedItem != null &&
               txtNaam.Text != ""
               && txtPrijs.Text != "")
            {
                beer b = new beer();
                b.beertype = (beertype)cbType.SelectedItem;
                b.name = txtNaam.Text;

                decimal prijs = 0;
                if (decimal.TryParse(txtPrijs.Text, out prijs))
                {
                    b.price = prijs;
                }

                db.beers.InsertOnSubmit(b);
                db.SubmitChanges();

                MessageBox.Show($"Het bier {b.name} met type {b.beertype.type} is succesvol toegevoegd");

                dgBieren.ItemsSource = db.beers.ToList();
            }else
            {
                MessageBox.Show("Vul eerst alle velden in!", "Fout!");
            }
            txtNaam.Text = "";
            txtPrijs.Text = "";
            cbType.Text = "";
           
        }

        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {
            Bierenwijzigen bw = new Bierenwijzigen();
            bw.Show();
            this.Close();
        }
    }
}
