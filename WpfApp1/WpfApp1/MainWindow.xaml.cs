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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        public MainWindow()
        {
            InitializeComponent();
            label1.Content = 0;

            Grid grid = new Grid();
            Button button = new Button();
            button.Content = "Button 2";

            grid.Children.Add(button);
        }

 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //licznik
            int licznik = Convert.ToInt32(label1.Content);
            licznik++;
            label1.Content = licznik;   
       

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PrzyciskNaObrazek.Content = "dowolny tekst";
            MessageBox.Show("Nowy dowolny tekst");
        }

 
    }
}
