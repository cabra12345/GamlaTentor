using Microsoft.VisualBasic;
using System.Net;
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

namespace HönanEllerÄgget
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

        private void btnBeräkna_Click(object sender, RoutedEventArgs e)         // fråga 1
        {
            int ägg = int.Parse(txtBoxSkriv.Text);

            int kartonger = ägg / 12;

            double pris = 42.72;

            double totalpris = pris * kartonger;
            
            txtBlockSvar.Text = $"Du ska leverera {kartonger} st kartonger till ett pris av {totalpris}";
        }

        private void btnTrasigaÄgg_Click(object sender, RoutedEventArgs e)
        {
            bool[] isBroken = new bool[]
            //Här skapar du en array av typen bool (boolska värden som kan vara true eller false).
            //true betyder att ägget är trasigt.
            //false betyder att ägget är helt.
            //Arrayen innehåller statusen för varje ägg som transporterades.
                {
        true, true, true, false, true, false, false, true, true, false, true, true,
        false, false, true, true, false, true, false, false, true, false, true, true,
        true, true, false, false, false, false, false, false, false, true, false, false,
        true, false, false, true, false, true, true, true, false, true, false, true,
        false, true, true, true, false, true, false, false, false, false, false, false,
        false, false, true, false, true, false, false, true, false, false, false, true,
        true, false, false, true, true, false, true, true, false, false, true, true,
        true, false, false, false, false, true
                };

            // Räknare för hela och trasiga ägg
            int helaÄgg = 0;
            int trasigaÄgg = 0;
            // Total antal ägg
            // helaÄgg: En räknare som börjar på 0 och ökar varje gång ett ägg är helt(false i arrayen).
            // trasigaÄgg: En räknare som börjar på 0 och ökar varje gång ett ägg är trasigt(true i arrayen).

            foreach (bool ägg in isBroken)
                //foreach: En loop som går igenom varje element(bool ägg) i isBroken-arrayen.
                //Varje element(status för ett ägg, true or false helt eller trasigt) kallas ägg under varje iteration.
            {
                if (ägg)
                {
                    trasigaÄgg++; // Om ägget är trasigt (true)
                }
                else
                {
                    helaÄgg++; // Om ägget är helt (false)
                }
                //if (ägg): Kontrollerar om värdet på ägg är true(trasigt).
                //Om ägg är true:
                //Räknaren för trasiga ägg(trasigaÄgg) ökas med 1.
                //Annars(else):
                //Räknaren för hela ägg(helaÄgg) ökas med 1.
            }

            // Total antal ägg
            int totalaÄgg = helaÄgg + trasigaÄgg;

            // Visa resultatet i en MessageBox
            MessageBox.Show($"Av {totalaÄgg} ägg så är det  {trasigaÄgg} som är trasiga och {helaÄgg} som är hela.");
        
        }

        private int Räkna123(List<string> pinkCodes)
        {
            int resultat = 0;

            // Iterera genom varje kod i listan
            foreach (string ettTvåTre in pinkCodes)
            {
                // Kontrollera om strängen innehåller "123" (på positions 4, 5 och 6)
                if (ettTvåTre.Length >= 6 && ettTvåTre.Substring(3, 3) == "123")
                {
                    resultat++;
                }
            }

            // Returnera resultatet
            return resultat;
        }

        private void btnÄggröra_Click(object sender, RoutedEventArgs e)
        {
            List<string> pinkCodes = new List<string>()
    {
        "1SE123-2", "0SE675-6", "2SE122-4", "0SE234-1", "0SE234-5",
        "2SE564-4", "0SE234-2", "1SE564-6", "2SE144-5", "0SE675-1",
        "1SE144-1", "2SE144-3", "1SE123-4", "2SE122-2", "1SE122-6",
        "0SE234-2", "2SE123-3", "1SE234-3", "1SE123-6", "1SE123-4",
        "0SE122-2", "1SE144-3", "0SE234-4", "0SE564-1", "0SE234-4",
        "2SE144-3", "2SE122-3", "1SE234-3", "1SE123-4", "1SE564-5",
        "1SE123-1", "2SE122-6", "0SE123-6", "1SE564-6", "1SE234-5",
        "1SE564-6", "2SE234-2", "1SE234-3", "0SE234-3", "2SE122-5",
        "2SE234-2", "2SE144-2", "2SE564-5", "1SE144-5", "1SE675-4",
        "1SE123-6", "2SE564-6", "1SE122-6", "1SE122-5", "2SE122-2",
        "1SE234-2", "0SE675-5", "2SE122-4", "1SE234-6", "0SE564-4",
        "1SE564-6", "2SE675-3", "1SE144-4", "2SE564-5", "0SE564-1",
        "1SE564-4", "1SE123-4", "1SE564-6", "2SE122-2", "1SE564-5",
        "2SE234-4", "1SE564-4", "2SE122-1", "2SE123-3", "2SE564-2",
        "2SE234-4", "1SE144-1", "1SE675-1", "0SE144-1", "2SE123-6",
        "0SE123-5", "2SE144-6", "0SE144-6", "1SE122-4", "1SE675-6",
        "0SE122-6", "2SE144-2", "2SE122-3", "1SE234-5", "1SE564-2",
        "1SE144-5", "0SE144-1", "1SE144-3", "1SE122-4", "1SE123-1"
    };

            // Anropa metoden och lagra resultatet i en variabel
            int resultat = Räkna123(pinkCodes);

            // Här kan du använda 'resultat' för andra syften, t.ex. lagra det i en annan variabel eller använda vidare i programmet
            // Resultatet presenteras inte i MessageBox längre, utan kan användas i andra delar av din kod
        }
    }

}
