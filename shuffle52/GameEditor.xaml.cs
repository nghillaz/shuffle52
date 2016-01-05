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
    /// Interaction logic for GameEditor.xaml
    /// </summary>
    public partial class GameEditor : Page
    {
        public GameEditor()
        {
            InitializeComponent();
        }

        #region Designer

        /* handles Add buttons */
        void click_add(object sender, RoutedEventArgs e)
        {
            DeleteButton.IsEnabled = false;

            if ((sender as Button).Name == "AddPlayerButton")
            {
                AddPlayerPopup.IsOpen = true;
            } else if ((sender as Button).Name == "AddDeckButton")
            {
                AddDeckPopup.IsOpen = true;
            }
        }

        /* handles Add -- Okay buttons */
        void click_add_okay(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == "AddPlayerOkayButton")
            {
                PlayerListBox.Items.Add(PlayerNameTextBox.Text);
                AddPlayerPopup.IsOpen = false;
            }
            else if ((sender as Button).Name == "AddDeckOkayButton")
            {
                DeckListBox.Items.Add(DeckNameTextBox.Text);
                AddDeckPopup.IsOpen = false;
            }  
        }

        /* handles Add Player -- Cancel button */
        void click_add_cancel(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == "AddPlayerCancelButton")
            {
                AddPlayerPopup.IsOpen = false;
            }
            else if ((sender as Button).Name == "AddDeckCancelButton")
            {
                AddDeckPopup.IsOpen = false;
            }  
        }

        /* handles selecting a Player on the Player list */
        void select_player(object sender, RoutedEventArgs e)
        {
            DeleteButton.IsEnabled = true;
        }

        /* handles selecting a Deck on the Deck list */
        void select_deck(object sender, RoutedEventArgs e)
        {
            DeleteButton.IsEnabled = true;
        }

        /* handles the Delete button */
        void click_delete(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Rulebook

        #endregion
    }
}
