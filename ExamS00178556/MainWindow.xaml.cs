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

namespace ExamS00178556
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //create a lists that will hold all the objects

        List<Player> allPlayers = new List<Player>();
        List<Player> selectedPlayers = new List<Player>();

        private static Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Player p1 = new Player()
            {
                FName = "John",
                Surname = "Cena",
                DateOfBirth = new DateTime(1997, 07, 04),
                TypeOfPosition = Position.Goalkeeper,
            };

            Player p18 = new Player()
            {
                FName = "John",
                Surname = "Cena",
                DateOfBirth = new DateTime(1997, 06, 06),
                TypeOfPosition = Position.Goalkeeper,
            };

            Player p2 = new Player()
            {
                FName = "Mary",
                Surname = "Ruane",
                DateOfBirth = new DateTime(1997, 07, 07),
                TypeOfPosition = Position.Defender,
            };

            Player p3 = new Player()
            {
                FName = "Eddie",
                Surname = "Jo",
                DateOfBirth = new DateTime(1997, 08, 08),
                TypeOfPosition = Position.Defender,
            };

            Player p4 = new Player()
            {
                FName = "Lamar",
                Surname = "Odom",
                DateOfBirth = new DateTime(1999, 12, 04),
                TypeOfPosition = Position.Defender,
            };

            Player p5 = new Player()
            {
                FName = "Ronnie",
                Surname = "Small",
                DateOfBirth = new DateTime(1995, 07, 12),
                TypeOfPosition = Position.Defender,
            };

            Player p6 = new Player()
            {
                FName = "Jeremy",
                Surname = "Big",
                DateOfBirth = new DateTime(1997, 12, 12),
                TypeOfPosition = Position.Defender,
            };

            Player p7 = new Player()
            {
                FName = "Jop",
                Surname = "Hand",
                DateOfBirth = new DateTime(1997, 1, 01),
                TypeOfPosition = Position.Defender,
            };

            Player p8 = new Player()
            {
                FName = "Arnold",
                Surname = "Schwarz",
                DateOfBirth = new DateTime(1997, 07, 04),
                TypeOfPosition = Position.Midfielder,
            };

            Player p9 = new Player()
            {
                FName = "Kym",
                Surname = "Rod",
                DateOfBirth = new DateTime(1997, 07, 04),
                TypeOfPosition = Position.Midfielder,
            };

            Player p10 = new Player()
            {
                FName = "Jim",
                Surname = "Beam",
                DateOfBirth = new DateTime(1997, 07, 04),
                TypeOfPosition = Position.Midfielder,
            };

            Player p11 = new Player()
            {
                FName = "John",
                Surname = "Cena",
                DateOfBirth = new DateTime(1997, 07, 04),
                TypeOfPosition = Position.Midfielder,
            };

            Player p12 = new Player()
            {
                FName = "Will",
                Surname = "Smith",
                DateOfBirth = new DateTime(1997, 07, 04),
                TypeOfPosition = Position.Midfielder,
            };

            Player p13 = new Player()
            {
                FName = "John",
                Surname = "Travolta",
                DateOfBirth = new DateTime(1997, 07, 04),
                TypeOfPosition = Position.Midfielder,
            };

            Player p14 = new Player()
            {
                FName = "Ron",
                Surname = "Black",
                DateOfBirth = new DateTime(1993, 07, 04),
                TypeOfPosition = Position.Forward,
            };

            Player p15 = new Player()
            {
                FName = "Chris",
                Surname = "Webber",
                DateOfBirth = new DateTime(1992, 07, 04),
                TypeOfPosition = Position.Forward,
            };

            Player p16 = new Player()
            {
                FName = "Walter",
                Surname = "White",
                DateOfBirth = new DateTime(1991, 11, 11),
                TypeOfPosition = Position.Forward,
            };

            Player p17 = new Player()
            {
                FName = "Hank",
                Surname = "Jeff",
                DateOfBirth = new DateTime(1998, 10, 10),
                TypeOfPosition = Position.Forward,
            };

            //add to list
            allPlayers.Add(p1);
            allPlayers.Add(p2);
            allPlayers.Add(p3);
            allPlayers.Add(p4);
            allPlayers.Add(p5);
            allPlayers.Add(p6);
            allPlayers.Add(p7);
            allPlayers.Add(p8);
            allPlayers.Add(p9);
            allPlayers.Add(p10);
            allPlayers.Add(p11);
            allPlayers.Add(p12);
            allPlayers.Add(p13);
            allPlayers.Add(p14);
            allPlayers.Add(p15);
            allPlayers.Add(p16);
            allPlayers.Add(p17);
            allPlayers.Add(p18);


            //sort and display
            allPlayers.Sort();

            lbxAllPlayers.ItemsSource = allPlayers;
            lbxSelectedPlayers.ItemsSource = selectedPlayers;


        }

        //btn add click to move items
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            Player selected = lbxAllPlayers.SelectedItem as Player;

            if (selected != null)

            {
                //moves activities to other list
                allPlayers.Remove(selected);
                selectedPlayers.Add(selected);

                //refreshes screen
                RefreshScreen();
            }

        }

        private void RefreshScreen()
        {
            lbxAllPlayers.ItemsSource = null;
            lbxSelectedPlayers.ItemsSource = null;

            lbxAllPlayers.ItemsSource = allPlayers;
            lbxSelectedPlayers.ItemsSource = selectedPlayers;
        }


        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {

            Player selected = lbxSelectedPlayers.SelectedItem as Player;

            if (selected != null)
                
            {
                //moves activities to other list
                allPlayers.Add(selected);
                selectedPlayers.Remove(selected);

                //refreshes screen
                RefreshScreen();
            }

        }
    }
}
