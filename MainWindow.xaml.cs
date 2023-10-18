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

namespace AMIAR_TP1_EX5
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        // Fonction pour inverser une chaîne de caractères
        private string ReverseString(string input)
        {
            char[] Tableau = input.ToCharArray();
            Array.Reverse(Tableau);
            return new string(Tableau);
        }


        private void BT_CALCUL_Click(object sender, RoutedEventArgs e)
        {
            string entree = TB_ENTREE.Text;
            string reversed = ReverseString(entree);
            TB_DISPLAY.Text = reversed;
        }
    }
}
