//-----------------------------------------------------------------------
// <copyright file="Winner.xaml.cs" company="Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze">
//     Copyright (c) Ian Burroughs, Mike Boudreau, Brandon Biles & James A. Schulze. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace farkle
{
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

    /// <summary>
    /// Interaction logic for Winner.xaml
    /// </summary>
    public partial class Winner : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Winner" /> class.
        /// </summary>
        public Winner()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Exit button click event.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">RoutedEventArgs e.</param>
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            // Close application.
            this.Close();
        }

        /// <summary>
        /// New Game button click event.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="e">RoutedEventArgs e.</param>
        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {

            int d = 0;

            if (rdoEasy.IsChecked == true)
            {
                d = 1;
            }
            else if (rdoHard.IsChecked == true)
            {
                d = 2;
            }

            if ((bool)rdoOnePlayer.IsChecked == true)
            {
                if (rdoOneAI.IsChecked == true)
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.OnePlayer = true;
                    farkleGame.AICount = 1;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
                else
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.OnePlayer = true;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
            }
            else if ((bool)rdoTwoPlayer.IsChecked == true)
            {
                if (rdoOneAI.IsChecked == true)
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.TwoPlayer = true;
                    farkleGame.AICount = 1;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
                else if (rdoTwoAI.IsChecked == true)
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.TwoPlayer = true;
                    farkleGame.AICount = 2;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
                else
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.TwoPlayer = true;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
            }
            else if ((bool)rdoThreePlayers.IsChecked == true)
            {
                if (rdoOneAI.IsChecked == true)
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.ThreePlayer = true;
                    farkleGame.AICount = 1;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
                else if (rdoTwoAI.IsChecked == true)
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.ThreePlayer = true;
                    farkleGame.AICount = 2;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
                else if (rdoThreeAI.IsChecked == true)
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.ThreePlayer = true;
                    farkleGame.AICount = 3;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
                else
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.ThreePlayer = true;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
            }
            else
            {
                if (rdoOneAI.IsChecked == true)
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.FourPlayer = true;
                    farkleGame.AICount = 1;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
                else if (rdoTwoAI.IsChecked == true)
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.FourPlayer = true;
                    farkleGame.AICount = 2;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
                else if (rdoThreeAI.IsChecked == true)
                {
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.FourPlayer = true;
                    farkleGame.AICount = 3;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
                else if (rdoFourAI.IsChecked == true)
                {
                    // Four players was selected.
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.FourPlayer = true;
                    farkleGame.AICount = 4;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
                else
                {
                    // Four players was selected.
                    MainWindow farkleGame = new MainWindow();
                    farkleGame.FourPlayer = true;
                    farkleGame.Difficulty = d;
                    farkleGame.Show();
                }
            }

            // Close current form.
            this.Close();
        }
    }
}
