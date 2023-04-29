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

namespace TicTacToe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow  
    {
        public bool Player1Turn { get; set; }
        public int TourCounter { get; set; }

        public MainWindow() 
        {
            InitializeComponent();

            NewGame();
        }

        public void NewGame()
        {
            Player1Turn = true;
            TourCounter = 0;
            Button_0_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            TourCounter++;
            if (TourCounter > 9)
            {
                NewGame();
                return;
            }
            if (button.Content.ToString() != String.Empty)
            { 
                return;
            }

            button.Content = Player1Turn ? "X" : "0";
            CheckWin();
            Player1Turn = !Player1Turn;

        }

        public void CheckWin()
        {
            if (Button_0_0.Content.ToString() != String.Empty &&
                Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                TourCounter = 9;
            }
            if (Button_1_0.Content.ToString() != String.Empty &&
                Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                TourCounter = 9;
            }
            if (Button_2_0.Content.ToString() != String.Empty &&
                Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                TourCounter = 9;
            }
            if (Button_0_0.Content.ToString() != String.Empty &&
            Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                TourCounter = 9;
            }
            if (Button_0_1.Content.ToString() != String.Empty &&
                Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                TourCounter = 9;
            }
            if (Button_0_2.Content.ToString() != String.Empty &&
                Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                TourCounter = 9;
            }
            if (Button_0_0.Content.ToString() != String.Empty &&
                Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                TourCounter = 9;
            }
            if (Button_2_0.Content.ToString() != String.Empty &&
                Button_2_0.Content == Button_1_1.Content && Button_1_1.Content == Button_0_2.Content)
            {
                Button_2_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                TourCounter = 9;
            }


        }



    }
}
