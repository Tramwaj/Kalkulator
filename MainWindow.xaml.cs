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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TwoComponentOperation twoComponentOperation;
        bool comma = false; // shows if the curent number already has a comma or not 
        public MainWindow()
        {

            InitializeComponent();
        }


        private void Fill(string symbol)
        {
            if (Wynik.Text == "0") Wynik.Text = symbol;
            else Wynik.Text += symbol;

        }
        private void Flush()
        {
            First.Text = Wynik.Text;
            Wynik.Text = "0";
            Operation.Text = twoComponentOperation.DisplayOperation();
            Second.Text = "0";
            comma = false;
        }
        static private void PutComma()
        {

        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {

            Fill("7");
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Fill("8");
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Fill("9");
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Fill("4");
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Fill("5");
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Fill("6");
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Fill("1");
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Fill("2");
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Fill("3");
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Fill("0");
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            twoComponentOperation = new Division(Double.Parse(Wynik.Text));
            Flush();
        }

        private void Multiplicate_Click(object sender, RoutedEventArgs e)
        {
            twoComponentOperation = new Multiplication(Double.Parse(Wynik.Text));
            Flush();
        }

        private void Substract_Click(object sender, RoutedEventArgs e)
        {
            twoComponentOperation = new Substraction(Double.Parse(Wynik.Text));
            Flush();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            twoComponentOperation = new Addition(Double.Parse(Wynik.Text));
            Flush();
        }

        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            if (!comma)
            {
                Wynik.Text += ",";
                comma = true;
            }

        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            if (twoComponentOperation != null)
            {
                Second.Text = Wynik.Text;
                Wynik.Text = twoComponentOperation.Wynik(Double.Parse(Second.Text)).ToString();
                History.Text += "\n" + twoComponentOperation.TextForHistory() + " = " + Wynik.Text;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            First.Text = "0";
            Second.Text = "0";
            Wynik.Text = "0";
            twoComponentOperation = null;
        }
    }
}
