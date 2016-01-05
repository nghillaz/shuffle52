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

        //void add_player(object sender, RoutedEventArgs e)
        //{
        //    PlayerListBox.Items.Add();
        //}

        #endregion

        #region Rulebook

        #region checkmark-control-functions
        void club_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                OneClubCheck.IsChecked = box.IsChecked;
                TwoClubCheck.IsChecked = box.IsChecked;
                ThreeClubCheck.IsChecked = box.IsChecked;
                FourClubCheck.IsChecked = box.IsChecked;
                FiveClubCheck.IsChecked = box.IsChecked;
                SixClubCheck.IsChecked = box.IsChecked;
                SevenClubCheck.IsChecked = box.IsChecked;
                EightClubCheck.IsChecked = box.IsChecked;
                NineClubCheck.IsChecked = box.IsChecked;
                TenClubCheck.IsChecked = box.IsChecked;
                JackClubCheck.IsChecked = box.IsChecked;
                QueenClubCheck.IsChecked = box.IsChecked;
                KingClubCheck.IsChecked = box.IsChecked;
            }
        }

        void diamond_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                OneDiamondCheck.IsChecked = box.IsChecked;
                TwoDiamondCheck.IsChecked = box.IsChecked;
                ThreeDiamondCheck.IsChecked = box.IsChecked;
                FourDiamondCheck.IsChecked = box.IsChecked;
                FiveDiamondCheck.IsChecked = box.IsChecked;
                SixDiamondCheck.IsChecked = box.IsChecked;
                SevenDiamondCheck.IsChecked = box.IsChecked;
                EightDiamondCheck.IsChecked = box.IsChecked;
                NineDiamondCheck.IsChecked = box.IsChecked;
                TenDiamondCheck.IsChecked = box.IsChecked;
                JackDiamondCheck.IsChecked = box.IsChecked;
                QueenDiamondCheck.IsChecked = box.IsChecked;
                KingDiamondCheck.IsChecked = box.IsChecked;
            }
        }

        void heart_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                OneHeartCheck.IsChecked = box.IsChecked;
                TwoHeartCheck.IsChecked = box.IsChecked;
                ThreeHeartCheck.IsChecked = box.IsChecked;
                FourHeartCheck.IsChecked = box.IsChecked;
                FiveHeartCheck.IsChecked = box.IsChecked;
                SixHeartCheck.IsChecked = box.IsChecked;
                SevenHeartCheck.IsChecked = box.IsChecked;
                EightHeartCheck.IsChecked = box.IsChecked;
                NineHeartCheck.IsChecked = box.IsChecked;
                TenHeartCheck.IsChecked = box.IsChecked;
                JackHeartCheck.IsChecked = box.IsChecked;
                QueenHeartCheck.IsChecked = box.IsChecked;
                KingHeartCheck.IsChecked = box.IsChecked;
            }
        }

        void spade_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                OneSpadeCheck.IsChecked = box.IsChecked;
                TwoSpadeCheck.IsChecked = box.IsChecked;
                ThreeSpadeCheck.IsChecked = box.IsChecked;
                FourSpadeCheck.IsChecked = box.IsChecked;
                FiveSpadeCheck.IsChecked = box.IsChecked;
                SixSpadeCheck.IsChecked = box.IsChecked;
                SevenSpadeCheck.IsChecked = box.IsChecked;
                EightSpadeCheck.IsChecked = box.IsChecked;
                NineSpadeCheck.IsChecked = box.IsChecked;
                TenSpadeCheck.IsChecked = box.IsChecked;
                JackSpadeCheck.IsChecked = box.IsChecked;
                QueenSpadeCheck.IsChecked = box.IsChecked;
                KingSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void spade_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null && box.IsChecked == false)
            {
                //box was unchecked
                SpadeAllCheck.IsChecked = false;
            }
        }

        void one_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                OneClubCheck.IsChecked = box.IsChecked;
                OneDiamondCheck.IsChecked = box.IsChecked;
                OneHeartCheck.IsChecked = box.IsChecked;
                OneSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void two_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                TwoClubCheck.IsChecked = box.IsChecked;
                TwoDiamondCheck.IsChecked = box.IsChecked;
                TwoHeartCheck.IsChecked = box.IsChecked;
                TwoSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void three_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                ThreeClubCheck.IsChecked = box.IsChecked;
                ThreeDiamondCheck.IsChecked = box.IsChecked;
                ThreeHeartCheck.IsChecked = box.IsChecked;
                ThreeSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void four_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                FourClubCheck.IsChecked = box.IsChecked;
                FourDiamondCheck.IsChecked = box.IsChecked;
                FourHeartCheck.IsChecked = box.IsChecked;
                FourSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void five_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                FiveClubCheck.IsChecked = box.IsChecked;
                FiveDiamondCheck.IsChecked = box.IsChecked;
                FiveHeartCheck.IsChecked = box.IsChecked;
                FiveSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void six_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                SixClubCheck.IsChecked = box.IsChecked;
                SixDiamondCheck.IsChecked = box.IsChecked;
                SixHeartCheck.IsChecked = box.IsChecked;
                SixSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void seven_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                SevenClubCheck.IsChecked = box.IsChecked;
                SevenDiamondCheck.IsChecked = box.IsChecked;
                SevenHeartCheck.IsChecked = box.IsChecked;
                SevenSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void eight_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                EightClubCheck.IsChecked = box.IsChecked;
                EightDiamondCheck.IsChecked = box.IsChecked;
                EightHeartCheck.IsChecked = box.IsChecked;
                EightSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void nine_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                NineClubCheck.IsChecked = box.IsChecked;
                NineDiamondCheck.IsChecked = box.IsChecked;
                NineHeartCheck.IsChecked = box.IsChecked;
                NineSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void ten_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                TenClubCheck.IsChecked = box.IsChecked;
                TenDiamondCheck.IsChecked = box.IsChecked;
                TenHeartCheck.IsChecked = box.IsChecked;
                TenSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void jack_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                JackClubCheck.IsChecked = box.IsChecked;
                JackDiamondCheck.IsChecked = box.IsChecked;
                JackHeartCheck.IsChecked = box.IsChecked;
                JackSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void queen_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                QueenClubCheck.IsChecked = box.IsChecked;
                QueenDiamondCheck.IsChecked = box.IsChecked;
                QueenHeartCheck.IsChecked = box.IsChecked;
                QueenSpadeCheck.IsChecked = box.IsChecked;
            }
        }

        void king_all_check(object sender, RoutedEventArgs e)
        {
            CheckBox box = (sender as CheckBox);
            if (box.IsChecked != null)
            {
                //box was checked
                KingClubCheck.IsChecked = box.IsChecked;
                KingDiamondCheck.IsChecked = box.IsChecked;
                KingHeartCheck.IsChecked = box.IsChecked;
                KingSpadeCheck.IsChecked = box.IsChecked;
            }
        }
        #endregion

        #endregion
    }
}
