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

namespace shuffle52
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /* navigates to GamePlayer when Play button is clicked */
        private void click_play(object sender, RoutedEventArgs e)
        {
            GamePlayer gamePlayer = new GamePlayer();
            this.NavigationService.Navigate(gamePlayer);

        }

        /* navigates to GameEditor when Make button is clicked */
        private void click_make(object sender, RoutedEventArgs e)
        {
            GameEditor gameEditor = new GameEditor();
            this.NavigationService.Navigate(gameEditor);

        }
    }
}
