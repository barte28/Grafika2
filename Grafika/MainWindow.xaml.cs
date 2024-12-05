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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Grafika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            image_cat.Source = new BitmapImage(new Uri("elephant.jpg",UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<string> listaObrazkow = new List<string>();
            listaObrazkow.Add("cat.jpg");
            listaObrazkow.Add("elephant.jpg");
            listaObrazkow.Add("greylag-goose.jpg");
            listaObrazkow.Add("mountains.jpg");
            Random random = new Random();
            int indeks = random.Next(listaObrazkow.Count);
            image_cat.Source = new BitmapImage(new Uri(listaObrazkow[indeks], UriKind.Relative));

        }
    }
}
