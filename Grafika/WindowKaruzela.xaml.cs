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

namespace Grafika
{
    /// <summary>
    /// Logika interakcji dla klasy WindowKaruzela.xaml
    /// </summary>
    public partial class WindowKaruzela : Window
    {
        public int Licznik { get; set; }
        public List<Obraz> obrazki = new List<Obraz>();
        public WindowKaruzela()
        {
            InitializeComponent();
            obrazki.Add(new Obraz("cat.jpg"));
            obrazki.Add(new Obraz("elephant.jpg"));
            obrazki.Add(new Obraz("greylag-goose.jpg"));
            obrazki.Add(new Obraz("mountains.jpg"));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Licznik--;
            if(Licznik < 0)
            {
                Licznik = obrazki.Count - 1;
            }
            wyswietlObraz(Licznik);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Licznik++;
            if(Licznik == obrazki.Count)
            {
                Licznik = 0;
            }
            wyswietlObraz(Licznik);
        }
        private void wyswietlObraz(int i)
        {
            image_modyfikowany.Source = new BitmapImage(new Uri(obrazki[i].UrlObrazka, UriKind.Relative));
            polubienia_textblock.Text = obrazki[i].LiczbaPolubien.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            obrazki[Licznik].LiczbaPolubien++;
            wyswietlObraz(Licznik);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (obrazki[Licznik].LiczbaPolubien > 0)
            {
                obrazki[Licznik].LiczbaPolubien--;
                wyswietlObraz(Licznik);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if(obraz1Radio.IsChecked == true)
            {
                image_modyfikowany.Source = new BitmapImage(new Uri("cat.jpg", UriKind.Relative));
            }
            else if(obraz2Radio.IsChecked == true)
            {
                image_modyfikowany.Source = new BitmapImage(new Uri("elephant.jpg", UriKind.Relative));
            }
            else if(obraz3Radio.IsChecked == true)
            {
                image_modyfikowany.Source = new BitmapImage(new Uri("mountains.jpg", UriKind.Relative));
            }
        }
    }
}
