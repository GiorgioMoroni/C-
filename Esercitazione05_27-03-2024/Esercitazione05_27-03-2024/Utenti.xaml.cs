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

namespace Esercitazione05_27_03_2024
{
    /// <summary>
    /// Logica di interazione per Utenti.xaml
    /// </summary>
    public partial class Utenti : Window
    {
        public Utenti()
        {
            InitializeComponent();
        }

        

        private void Categorie_Click(object sender, RoutedEventArgs e)
        {
            Categorie paginaCategorie = new Categorie();
            paginaCategorie.Show();
            this.Close();
        }

        private void Prodotti_Click(object sender, RoutedEventArgs e)
        {
            Prodotti paginaProd = new Prodotti();
            paginaProd.Show();
            this.Close();
        }

        private void Variazioni_Click(object sender, RoutedEventArgs e)
        {
            Variazioni paginaVar = new Variazioni();
            paginaVar.Show();
            this.Close();
        }

        private void Prezzi_Click(object sender, RoutedEventArgs e)
        {
            Prezzi paginaPrezzi = new Prezzi();
            paginaPrezzi.Show();
            this.Close();
        }

        private void Ordini_Click(object sender, RoutedEventArgs e)
        {
            Ordini paginaOrdini = new Ordini();
            paginaOrdini.Show();
            this.Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow paginaHome = new MainWindow();
            paginaHome.Show();
            this.Close();
        }
    }
}
