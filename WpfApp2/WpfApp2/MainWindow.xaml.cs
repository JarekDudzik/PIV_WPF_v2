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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public bool IsPlayerTurn { get; set; }

        public int Counter { get; set; }    

        public MainWindow()
        {
            InitializeComponent();
            NewGame(); 
        }

        public void NewGame()
        {
            IsPlayerTurn = false;
            Button_0_0.Content = string.Empty;  
            Button_1_0.Content = string.Empty;  
            Button_2_0.Content = string.Empty;  
            Button_0_1.Content = string.Empty;  
            Button_1_1.Content = string.Empty;  
            Button_2_1.Content = string.Empty;  
            Button_0_2.Content = string.Empty;  
            Button_1_2.Content = string.Empty;  
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            IsPlayerTurn ^= true;
            Counter++;

            if (Counter > 9)
            {
                NewGame();
                return;
            } 
            var button = sender as Button;

            button.Content = IsPlayerTurn ? "O" : "X";

            if (CheckIfPlayerWon())
            {
                Counter = 9;
            }

        }

        private bool CheckIfPlayerWon()
        {
            //Rzędy
            if (Button_0_0.Content.ToString() != string.Empty && 
                Button_0_0.Content == Button_0_1 && Button_0_1 == Button_0_2) 
            {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                return true;
            }
            
            if (Button_1_0.Content.ToString() != string.Empty &&
               Button_1_0.Content == Button_1_1 && Button_1_1 == Button_1_2)
            {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                return true;
            }
            if (Button_2_0.Content.ToString() != string.Empty &&
             Button_2_0.Content == Button_2_1 && Button_2_1 == Button_2_2)
            {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }
            //Kolumny
            if (Button_0_0.Content.ToString() != string.Empty &&
             Button_0_0.Content == Button_1_0 && Button_1_0 == Button_2_0)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }

            if (Button_0_1.Content.ToString() != string.Empty &&
               Button_0_1.Content == Button_1_1 && Button_1_1 == Button_2_1)
            {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                return true;
            }
            if (Button_0_2.Content.ToString() != string.Empty &&
             Button_0_2.Content == Button_1_2 && Button_1_2 == Button_2_2)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }
            //Skosy
            if (Button_0_0.Content.ToString() != string.Empty &&
              Button_0_0.Content == Button_1_1 && Button_2_2 == Button_2_0)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }

            if (Button_0_1.Content.ToString() != string.Empty &&
               Button_2_0.Content == Button_1_1 && Button_1_2 == Button_2_1)
            {
                Button_2_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                return true;
            }
       

            return false;
        }
    }
}
