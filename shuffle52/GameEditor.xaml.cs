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

        /* handles Okay buttons */
        void click_okay(object sender, RoutedEventArgs e)
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
            else if ((sender as Button).Name == "EditNameOkayButton")
            {
                CurrentItem.Content = EditNameTextBox.Text;

                EditNamePopup.IsOpen = false;
            }
        }

        /* handles Cancel buttons */
        void click_cancel(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == "AddPlayerCancelButton")
            {
                AddPlayerPopup.IsOpen = false;
            }
            else if ((sender as Button).Name == "AddDeckCancelButton")
            {
                AddDeckPopup.IsOpen = false;
            }
            else if ((sender as Button).Name == "EditNameCancelButton")
            {
                EditNamePopup.IsOpen = false;
            }
        }

        /* handles selecting a Player on the Player list */
        void select_player(object sender, RoutedEventArgs e)
        {
            DeleteButton.IsEnabled = true;
            EditNameButton.IsEnabled = true;

            CurrentItem.Content = (sender as ListBox).SelectedItem.ToString();
        }

        /* handles selecting a Deck on the Deck list */
        void select_deck(object sender, RoutedEventArgs e)
        {
            DeleteButton.IsEnabled = true;
            EditNameButton.IsEnabled = true;

            CurrentItem.Content = (sender as ListBox).SelectedItem.ToString();
        }

        /* handles the Edit Name button */
        void click_edit_name(object sender, RoutedEventArgs e)
        {
            EditNamePopup.IsOpen = true;
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
