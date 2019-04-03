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
    /// Interaction logic for Huisgroottewijzigen.xaml
    /// </summary>
    public partial class Huisgroottewijzigen : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Huisgroottewijzigen()
        {
            InitializeComponent();
            
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            if (txtGrootte.Text != "")
            {
                housesize hs = new housesize();

                hs.size = txtGrootte.Text;

                db.housesizes.InsertOnSubmit(hs);
                db.SubmitChanges();

                MessageBox.Show("Het huis met de grootte: " + hs.size + " is toegevoegd aan de database", "Gelukt!");

                txtGrootte.Text = "";
            }
            else
            {
                MessageBox.Show("Vul eers iets in!", "Fout!");
            }
            Huizentypes ht = new Huizentypes();
            ht.Show();
            ht.lbGrootte.SelectedItem = db.housesizes.ToList();
            this.Close();
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            if (txtGrootte.Text != "")
            {
                int ID = Convert.ToInt32(lbID.Content);

                MessageBoxResult r = MessageBox.Show("Weet je zeker dat je het huisgrootte met het id " + lbID.Content + " wilt wijzigen?", "Wijzigen huisgrootte", MessageBoxButton.YesNo);
                if (r == MessageBoxResult.Yes)
                {
                    housesize hs = (from housesize in db.housesizes
                                     where housesize.id == ID
                                     select housesize).Single();

                    hs.size = txtGrootte.Text;

                    db.SubmitChanges();

                }

                Huizentypes ht = new Huizentypes();
                ht.Show();
                ht.lbGrootte.ItemsSource = db.housesizes.ToList();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vul eers een geldige grootte in!", "Fout!");
            }
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            if (txtGrootte.Text != "")
            {
                int ID = Convert.ToInt32(lbID.Content);

                MessageBoxResult r = MessageBox.Show("Weet je zeker dat je de huisgrootte met het id " + lbID.Content + " wilt verwijderen?", "Verwijderen huisgrootte", MessageBoxButton.YesNo);
                if (r == MessageBoxResult.Yes)
                {
                    housesize hs = (from housesize in db.housesizes
                                     where housesize.id == ID
                                     select housesize).Single();

                    hs.size = txtGrootte.Text;

                    db.housesizes.DeleteOnSubmit(hs);
                    db.SubmitChanges();
                }

                Huizentypes ht = new Huizentypes();
                ht.Show();
                ht.lbTypes.ItemsSource = db.housetypes.ToList();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vul eers een geldige grootte in!", "Fout!");
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Huizentypes ht = new Huizentypes();
            ht.Show();
            this.Close();
        }
    }
}
