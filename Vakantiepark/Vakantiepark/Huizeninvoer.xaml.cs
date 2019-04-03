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
    /// Interaction logic for Huizeninvoer.xaml
    /// </summary>
    public partial class Huizeninvoer : Window
    {
        databaseDataContext db = new databaseDataContext();
        public Huizeninvoer()
        {
            InitializeComponent();

            dgHuizen.ItemsSource = db.houses.ToList();

            cbSize.ItemsSource = db.housesizes;
            cbSize.DisplayMemberPath = "size";

            cbType.ItemsSource = db.housetypes;
            cbType.DisplayMemberPath = "type";

        }

        private void btnTypes_Click(object sender, RoutedEventArgs e)
        {
            Huizentypes ht = new Huizentypes();
            ht.Show();
            this.Close();
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            if (txtNummer.Text != "")
            {
                if (txtPrijs.Text != "")
                {
                    if (cbType.SelectedItem != null)
                    {
                        if (cbSize.SelectedItem != null)
                        {                          
                            house h = new house();
                            h.name = txtNummer.Text;
                            h.housetype = (housetype)cbType.SelectedItem;
                            h.housesize = (housesize)cbSize.SelectedItem;

                            decimal prijs = Convert.ToDecimal(txtPrijs.Text);

                            h.price = prijs;

                            db.houses.InsertOnSubmit(h);
                            db.SubmitChanges();

                            MessageBox.Show("Huis met het nummer " + h.name + " is toegevoegd aan de database", "Gelukt!");

                            dgHuizen.ItemsSource = db.houses.ToList();
                        }
                        else
                        {
                            MessageBox.Show("Selecteer eerst een grootte!", "Fout!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecteer eerst een type!", "Fout!");
                    }
                }
                else
                {
                    MessageBox.Show("Vul eerst een prijs in!", "Fout!");
                }                
            }
            else
            {
                MessageBox.Show("Vul eerst een nummer in!", "Fout!");
            }              
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            var hetHuis = (house)dgHuizen.SelectedItem;
            Huizenwijzigen hw = new Huizenwijzigen();
            hw.Show();
            hw.cbType.SelectedValuePath = "type";
            hw.cbType.SelectedValue = hetHuis.housetype.type;
            hw.cbGrootte.SelectedValuePath = "size";
            hw.cbGrootte.SelectedValue = hetHuis.housesize.size;
            hw.lbID.Content = hetHuis.id;
            hw.txtNummer.Text = hetHuis.name;
            hw.txtPrijs.Text = hetHuis.price.ToString();
            this.Close();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
