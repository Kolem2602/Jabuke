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

namespace Jabuke
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

        List<Jabuka> Jabuke = new List<Jabuka>();
        int sum = 0;

        private void Zapamti(object sender, RoutedEventArgs e)
        {
            string kol = textBoxKolicina.Text;
            Jabuka j1 = new Jabuka();
            j1.boja = textBoxBoja.Text;
            j1.kolicina = Convert.ToInt16(kol);
            sum += j1.kolicina;
            for (int x = 0; x < Jabuke.Count(); x++)
            {
                Jabuka j2 = Jabuke.ElementAt(x);
                if (j2.boja == j1.boja)
                {
                    j2.kolicina += j1.kolicina;
                }
                else
                {
                    Jabuke.Add(j1);

                }

            }
            textBoxBoja.Clear();
            textBoxKolicina.Clear();

        }

        private void Izracunaj(object sender, RoutedEventArgs e)
        {
            textBoxZbrojKolicinaSvih.Text =sum.ToString() ;
        }
        

        private void Pretrazi(object sender, RoutedEventArgs e)
        {
            int i=100000;
            string min="";


            foreach(Jabuka j1 in Jabuke)
            {
                if (j1.kolicina <i)
                {
                    min += j1.boja;
                }
            }

               textBoxIspisNajmanjeJabukaBoje.Text= min;
            
        }
    }
}
