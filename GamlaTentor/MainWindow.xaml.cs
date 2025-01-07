using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GamlaTentor //Nöjesfältet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnBalans_Click(object sender, RoutedEventArgs e) //knapp och metod för balanstest uppgift 1
        {
            int personer = int.Parse(txtBox1.Text);

            if (personer % 2 == 0)
            {
                MessageBox.Show("Karusellen är balanserad");
            }
            else
            {
                MessageBox.Show("Karusellen är obalanserad");
            }
        }




        private void btnKö_Click(object sender, RoutedEventArgs e)
        {
            int passengers = int.Parse(txtBox1.Text);

            // jag gör ett villkor där jag skickar in int passanger, alltså det som skrevs in i textboxen (CanRideOnNextRound(passengers))
            // om metodenen CanRideOnNextRound är FALSE, (!CanRideOnNextRound) 
            // alltså om (passengers) jag skickar in är större än totalSeats i metoden CanRideOnNextRound
            // så kommer MessaBoxen Du kom inte med upp.

            if (!CanRideOnNextRound(passengers))
            {
                MessageBox.Show("Du kom inte med utan får vänta en runda till");
            }

            else
            {
                MessageBox.Show("Yes. Äntligen min tur.");
            }
        }
        // private bool är datatypen
        // CanRideOnNextRound är namnet på metoden jag skapat
        // int passangersInQueue är variablen för int värdet jag mottar TILL metoden. Behöver inte vara samma namn.
        // return passangersInQueue + 1 <= totalSeats är de värdet jag returnerar

        // jag returnerar alltså variabeln passangersInQueue vilket är ett heltal jag fått TILL metoden.
        // när jag returnerar värdet så gör jag det med + 1 i värde.
        // denna metod returnerar TRUE or FALSE
        // om passangersInQueue + 1 <= totalSeats stämmer, returnerar den TRUE, annars returnerar metoden FALSE
        // alltså: beräkningen gör på passangersInQueue som skickas in från txtBox. 
        // Om passangersInQueue + 1 är mindre eller lika med totalSeats(24*2) så returnerar metoden TRUE. Annars returnerar den FALSE.

        private bool CanRideOnNextRound(int passangersInQueue) // metod för beräkning av kö, btnKö_Click uppgift 2
        {
            int numberOfWagons = 24;
            int seatsPerWagon = 2;

            int totalSeats = numberOfWagons * seatsPerWagon;

            return passangersInQueue + 1 <= totalSeats;
        }


        private void btnVänta_Click(object sender, RoutedEventArgs e)   // knapp för uppgift 3
        {
            int time = CalculateWaitingTime(int.Parse(txtBox1.Text));

            int time2 = CalculateWaitingTime(1);    //variablar jag lade in själv, kör programmet med en breakpoint och time2,3 osv visar rätt
            int time3 = CalculateWaitingTime(47);   
            int time4 = CalculateWaitingTime(48);
            int time5 = CalculateWaitingTime(500);

            MessageBox.Show($"Du får vänta i {time} minuter, eller {time2} minuter."); //jag la breakpointen här denna gång och körde med F10
        }

        //börjar med att göra en privat int som metod med namnet CalculateWaitingTime
        //den tar emot heltal int från knapptrycket btnVänta som jag lagrar i den metodspecifika variabeln passengersBeforeMe
        private int CalculateWaitingTime(int passengersBeforeMe) //metod för beräkning av kötid uppgift 3
        {
            int numberOfWagons = 24;
            int seatsPerWagon = 2;
            int cycleTime = 5; //tid per runda
            int totalSeats = numberOfWagons * seatsPerWagon;

            //räkna ut fulla rundor
            //för att räkna ut tiden det tar så tar jag antalet passagerare jag mottog från knappen btnVänta i txtBoxen
            //sen delar jag det med antalet säten och lagrar resultatet i en int fullWaggons
            // det jag returnerar är alltså heltalet med uträkningen

            int fullWaggons = (passengersBeforeMe) / totalSeats;

            return fullWaggons * cycleTime;
        }





        List<double> _ratings = new List<double>
            {
            4.23, 3.56, 1.98, 6.34, -1.45, 2.11, 4.78, 5.65, 3.33, 2.87,
            1.54, 4.99, 0.12, 3.77, 4.85, -0.45, 5.12, 2.34, 1.23, 4.67,
            3.88, 2.76, 5.02, 6.45, -1.22, 3.11, 4.55, 2.01, 1.89, 4.44,
            3.65, 0.34, 4.76, 5.33, 1.12, 4.21, -2.00, 3.99, 2.44, 5.22,
            6.75, 4.98, 3.43, 1.89, -0.67, 2.65, 3.78, 4.56, 5.12, 2.33,
            1.45, 4.89, 3.66, 6.89, 0.76, -1.90, 4.32, 5.45, 3.12, 2.67,
            4.88, 3.45, 1.78, 4.99, 6.11, 0.92, -0.23, 3.78, 4.67, 5.99,
            3.11, 2.99, 1.45, 4.56, 3.76, 2.43, 5.22, 4.12, 1.67, -0.98,
            3.88, 4.99, 6.34, 2.21, 3.54, 4.87, -2.15, 1.23, 5.11, 2.45,
            4.55, 3.99, 2.12, 4.78, 3.23, 5.32, 0.87, 4.01, 3.45, -1.89
            };

        private void btnRatings_Click(object sender, RoutedEventArgs e)
        {
           // List<double> firstRating = GetValidRatings([1.00, 0.92, -1.42]);
           // List<double> secondRating = GetValidRatings([2.66, 6.78, 1.4]);
            List<double> allRatings = GetValidRatings(_ratings);
        }


        private List<double> GetValidRatings(List<double> allRatings)
        {
            List<double> goodRating = new List<double>();

            foreach (double rating in allRatings)
            {
                if(rating >= 1 && rating <= 5)
                {
                    goodRating.Add(rating);
                }
            }
            return goodRating;
        } // här satte jag en breakpoint och sen F10, därefter såg jag på goodrating att det fanns ett korrekt värde

        private void btnTrender_Click(object sender, RoutedEventArgs e)
        {
            List<double> goodRating = GetValidRatings(_ratings);

            AnalyzeTrends(goodRating);
        }

        private void AnalyzeTrends(List<double> ratings)
        {
            int ups = 0;
            int downs = 0;
            //4, 6, 2, 1, 5
            for(int i = 1; i < ratings.Count; i++) // här satte jag breakpointen för att kolla igenom foreloopen och ups/down plussades på
            {
                if (ratings[i] > ratings[i-1])
                {
                    ups++;
                }
                else if (ratings[i] < ratings[i -1])
                {
                    downs++;
                }
            }
            MessageBox.Show($"Det finns {ups} ökningar och {downs} minskningar.");
        }
    }
}