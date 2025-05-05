using AlgorithmLib;
using System.Diagnostics;


namespace GMI24H_VT25_SortSearch_Labb_
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Här är kod som kan användas om man vill jobba med dataströmmar (som ligger i Generator-katalogen och skapas som ström utifrån en given seed). 
            const int numberOfPosts = 10000000;
            const int seed = 123;

            var generator = new RandomLogGenerator();
            var logs = generator.GenerateLogs(numberOfPosts, seed).ToList();


            //Skriver ut de fem första posterna i listan med LogEntry-typer. 
            Console.WriteLine("förhandsvisning av loggdata:");
            foreach (var entry in logs.Take(5))
            {
                Console.WriteLine(entry);
            }

            //Eftersom metoderna i SortingManager och SearchingManager-klasserna inte är statiska så behöver vi instansiera objekt av dessa klasser.
            //Eftersom vi gjort våra Sorting- och SearchingManager-klasserna generiska (<T>) behöver vi även ange vilken typ av data det
            //är som vi vill sortera eller söka efter. Vi anger datatyp i "diamanten" <>.
            var sorter = new SortingManager<string>();
            var searcher = new SearchingManager<string>();

            //Välj vilka data som ska plockas ut ur loggarna och jämföras. T.ex. Int eller strängar. Här behöver
            //vi tänka på att välja samma datatyp som vi vill köra våra algoritmer på, dvs. de vi bestämde oss för
            //när vi instansierade SortingManager och SearchingManager. I det här exemplet är det strängar.
            //Därför skapar vi en lista av strängar dit vi kan spara våra ip-adresser.
            //Vi använder LINQ för att selektera ut ip-adress-propertyn från varje enskilt logentry-post i logs-listan. 
            List<string> ipAddresses = logs.Select(entry => entry.IpAddress).ToList();

            //Från våra objekt, sorter och searcher, kan vi sedan anropa olika metoder där vi skickar in vår data som parametrar.
            //Det finns ingen implementation av bubblesort i SortingManager just nu. Det här metodanropet är
            //enbart en referens för att visa hur ni kan anropa en metod och skicka er sampledata som ni hämtar 
            //med LogParsern från textfilen. 
            //sorter.BubbleSort(ipAddresses); // <-- implement the methods from ISorter in the Sorter class in order to use them...

            //För att
            //vi ska kunna mäta hur lång tid det tar att köra algoritmen kan vi använda
            //stopwatch och timespan 
            Stopwatch sw = Stopwatch.StartNew();
            //TIPS1: det här är ett lämpligt ställe att placera körningen/anropet av din algoritm.
            sw.Stop();
            TimeSpan elapsedTime = sw.Elapsed; //TIPS2: här är det kanske en bra idé att göra någonting med data som sparats i elapsedTime... 
                                               //Man kan ju till exempel tänka sig att det kan vara lämpligt att gå tillbaka till deluppgift 1 i labb 1
                                               //och kolla hur ni gjorde med er data där...

            Console.WriteLine($"Totalt antal rader inlästa: {logs.Count}");
        }
    }
}
