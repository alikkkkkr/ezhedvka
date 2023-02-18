using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prac2sharp
{
    public partial class MainWindow : Window
    {
        //Myclass myclass = new Myclass(name_zametki_user.Text, opisanie_user.Text, date);    
        //ObservableCollection<string> items_zametki = new ObservableCollection<string>();

        List<Myclass> json_list = new List<Myclass>();

        public MainWindow()
        {
            InitializeComponent();

            date_user.Text = DateTime.Now.ToString();
            //json_list.Clear();
            List<Myclass> json_list1 = generic.deserializ<List<Myclass>>();
            
            foreach (Myclass i in json_list1) 
            { 
                json_list.Add(i); 
            }
            zametki.ItemsSource = json_list;
            //zametki.Items.Refresh();
        }

        private void cozdat_Click(object sender, RoutedEventArgs e)
        {
            if (name_zametki_user.Text != null)
            {
                Myclass sultan_suleman_han_hazret_leri = new Myclass(name_zametki_user.Text, opisanie_user.Text, date_user.Text);
                json_list.Add (sultan_suleman_han_hazret_leri);
                zametki.Items.Refresh();
                poseril();
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (name_zametki_user != null)
            {
                //Myclass xurem_sultan = new Myclass(name_zametki_user.Text, opisanie_user.Text, date_user.Text);
                (zametki.SelectedItem as Myclass).name = name_zametki_user.Text;
                (zametki.SelectedItem as Myclass).opisan = opisanie_user.Text;
                poseril();
            }
        }

        private void zametki_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((zametki.SelectedItem as Myclass) != null)
            {
                name_zametki_user.Text = (zametki.SelectedItem as Myclass).name;
                opisanie_user.Text = (zametki.SelectedItem as Myclass).opisan;
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            name_zametki_user.Text = "";
            opisanie_user.Text = "";
            json_list.Remove(zametki.SelectedItem as Myclass);
            zametki.Items.Refresh();
        }

        private void poseril()
        {
            name_zametki_user.Text = "";
            opisanie_user.Text = "";
            zametki.Items.Refresh();
            generic.serializ<List<Myclass>>(json_list);
        }
    }
}
