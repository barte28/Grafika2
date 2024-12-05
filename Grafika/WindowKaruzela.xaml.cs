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
        public List<string> obrazki = new List<string>();
        public WindowKaruzela()
        {
            InitializeComponent();
            obrazki.Add("cat.jpg");
            obrazki.Add("elephant.jpg");
            obrazki.Add("greylag-goose.jpg");
            obrazki.Add("mountains.jpg");

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
            image_modyfikowany.Source = new BitmapImage(new Uri(obrazki[i], UriKind.Relative));
        }
    }
}
