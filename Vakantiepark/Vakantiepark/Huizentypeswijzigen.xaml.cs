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

    public partial class Huizentypeswijzigen : Window
    {
        databaseDataContext db = new databaseDataContext();

        public Huizentypeswijzigen()
        {
            InitializeComponent();
            
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            if (txtType.Text != "")
            {
                housetype htt = new housetype();
                htt.type = txtType.Text;

                db.housetypes.InsertOnSubmit(htt);
                db.SubmitChanges();

                MessageBox.Show("Het type huis " + htt.type + " is toegevoegd aan de database", "Gelukt!");

                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Vul eers iets in!", "Fout!");
            }
            Huizentypes ht = new Huizentypes();
            ht.Show();
            ht.lbTypes.SelectedItem = db.housetypes.ToList();
            this.Close();
        }

        private void btnWijzig_Click(object sender, RoutedEventArgs e)
        {
            if(txtType.Text != "")
            {
                int ID = Convert.ToInt32(lbID.Content);

                MessageBoxResult r = MessageBox.Show("Weet je zeker dat je het huistype met het id " + lbID.Content + " wilt wijzigen?", "Wijzigen huistype", MessageBoxButton.YesNo);
                if(r == MessageBoxResult.Yes)
                {
                    housetype htt = (from housetype in db.housetypes
                                    where housetype.id == ID
                                    select housetype).Single();

                    htt.type = txtType.Text;

                    db.SubmitChanges();
                   
                }

                Huizentypes ht = new Huizentypes();
                ht.Show();
                ht.lbTypes.ItemsSource = db.housetypes.ToList();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vul eers een geldig type in!", "Fout!");
            }
        }

        private void btnVerwijder_Click(object sender, RoutedEventArgs e)
        {
            if (txtType.Text != "")
            {
                int ID = Convert.ToInt32(lbID.Content);

                MessageBoxResult r = MessageBox.Show("Weet je zeker dat je het huistype met het id " + lbID.Content + " wilt verwijderen?", "Verwijderen huistype", MessageBoxButton.YesNo);
                if (r == MessageBoxResult.Yes)
                {
                    housetype htt = (from housetype in db.housetypes
                                     where housetype.id == ID
                                     select housetype).Single();

                    htt.type = txtType.Text;

                    db.housetypes.DeleteOnSubmit(htt);
                    db.SubmitChanges();
                }

                Huizentypes ht = new Huizentypes();
                ht.Show();
                ht.lbTypes.ItemsSource = db.housetypes.ToList();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vul eers een geldig type in!", "Fout!");
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
