using System;
using System.Collections.Generic;
using System.Threading;

namespace Metoder_Benny_och_Nicklas
{
    class Program
    {
        // ----------------------------------------------------------------------------------------------------------------
        // ******************************************* BENNYS LEKTION. ****************************************************
        // ----------------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{
        //    //Programmet körs igång och kallar på koden som ligger i metoden KörProgram().
        //    KörProgram();
        //}

        //static void KörProgram()
        //{
        //    //Initierar en Lista av typen int som vi döper till "totalaSumman"
        //    List<int> totalaSumman = new List<int>();

        //    //Forloopens syfte är att köra det som finns i scopet 5 gånger
        //    for (int i = 0; i < 5; i++)
        //    {
        //        //Slumpar fram två tal (en ingrediens per variabel)
        //        Random rand = new Random();
        //        double slump1 = rand.Next(0, 11);
        //        double slump2 = rand.Next(0, 11);

        //        //Skriver ut vad vi har att arbeta med (ingredienserna)
        //        Console.WriteLine("-------- Beräkning {0} --------", i + 1);
        //        Console.WriteLine("Tal 1: {0}", slump1);
        //        Console.WriteLine("Tal 2: {0}", slump2);

        //        //Nu ska vi lägga ihop allt och då måste vi kalla på metoden Addera (se det som bunken som du rör ihop allt i)
        //        double totalSumma = Addera(slump1, slump2);

        //        Console.WriteLine("Uträkningen leder till resultatet: {0}", totalSumma);
        //        Console.WriteLine("-----------------------------");
        //        Console.WriteLine(Environment.NewLine);

        //    }
        //}

        //static double Addera(double tal1, double tal2)
        //{

        //    //Rör ihop alla ingredienser och skickar in dom i nästa metod (ugnen)
        //    return Dividera(tal1 + tal2);
        //}

        //static double Dividera(double summa)
        //{
        //    //Returnerar resultatet (en färdig kaka)
        //    return summa / 2;
        //}
        //------------------------------------------------------------------------------------------------------------------
        // ********************************************** NICKLAS LEKTION **************************************************
        //------------------------------------------------------------------------------------------------------------------
        // Console.WriteLine($"Hej {myArray.Lenght} Så här kan jag skriva för att göra allt kortare och snyggare myArray kan även skrivas {myArray[2]}");
        //static void Main(string[] args)
        //{
        //    //Deklarerade variabler
        //    int nummer1 = 5;
        //    int nummer2 = 12;

        //    //Kallar på en metod som enbart skriver ut text i console
        //    PrintMethod();

        //    //2 siffror in, ut kommer en WriteLine
        //    //Siffrorna kan vara vad som helst
        //    Input2NumbersAdded(4, 10);
        //    Input2NumbersAdded(nummer1, nummer2); //Här skickas nummer1 och nummer2 in, deklarerades ovan

        //    //Om vi vill spara summan in i en variabel
        //    int summa = NewInput2NumbersAdded(4, 10);
        //    Console.WriteLine(summa); //Testar skriva ut summan vi fick tillbaka från metoden.

        //    int myInt = Metodraketen(5, 95);
        //    Console.WriteLine(myInt);

        //    int minSumma = DividedMethod(10, 33);


        //}

        //// static         void       /    int/string/bool osv.        Metodnamn      (int x) / (string namn, int age)  
        ////   ^              ^                      ^                      ^            ^                ^
        //// Alltid     Ger inget tbx       En variabel ges tbx         Metodnamn      Parameter som skickas in till metoden när den kallas



        //static void PrintMethod() //Returnerar inget till användaren därav "void", den utför bara sin kod. 
        //{
        //    Console.WriteLine("Hello! This method only contains a \"WriteLine();\"");
        //}

        ////Denna metod tar in 2 variabler > kör sin kod > skriver ut till console
        //static void Input2NumbersAdded(int x, int y)
        //{
        //    //x och y är nummer 1 och nummer 2 som vi skickar in när vi anropar vår metod
        //    //variablerna får såklart döpas till vad man vill

        //    int sum = x + y;
        //    Console.WriteLine($"The sum of your addition is: {sum}");
        //}

        ////Samma metod som ovan.Men denna returnerar en int tillbaka till main
        //static int NewInput2NumbersAdded(int x, int y)
        //{
        //    int sum = x + y;
        //    return (sum); //Vi sparar värdet/variablen tillbaka till main, där vi sparar den som int summa;
        //}

        //static int Metodraketen(int myNumber1, int myNumber2)
        //{
        //    int myNewNumber = myNumber1 + myNumber2;
        //    return Metodraketen2(myNewNumber);
        //}

        //static int Metodraketen2(int myNewNumber)
        //{
        //    int sum = myNewNumber * 2;

        //    return sum;
        //}
        //static int DividedMethod(int x, int y)
        //{
        //    int sum = x / y;
        //    return sum;
        //}
        //---------------------------------------------------------------------------------------------------------------------
        // MINA ÖVNINGAR: EGEN
        //---------------------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            StartProgram();
            Console.ReadLine();
        }

        static void StartProgram()
        {
            bool keepGoing = false;

            do
            {
                Console.WriteLine("Hej och välkommen till lek med metoder! ");
                Console.WriteLine("1. Gör en enkel beräkning ");
                Console.WriteLine("2. Slumpa ett nytt efternamn ");
                Console.WriteLine("3. Gissa talet ");
                Console.WriteLine("4. Loopa igenom en lista ");
                Console.WriteLine("5. Bada en arg katt ");
                Console.WriteLine("6. Gör allting ");
                Console.WriteLine("7. Mixa ditt telefonnummer ");
                Console.WriteLine("8. EXIT");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    // Låter användaren skriva in två int tal som sedan skickar de två värdena till metoden SimpleCalculator,
                    // i metoden SimpleCalculator adderas talen ihop och svaret returneras till metoden StartProgram och skriver ut det i konsolen.
                    Console.WriteLine("Skriv ditt första tal: ");
                    int numb1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv ditt andra tal: ");
                    int numb2 = Convert.ToInt32(Console.ReadLine());
                    int answer = SimpleCalculator(numb1, numb2);
                    Console.WriteLine("Talet är: " + answer);
                }
                else if (choice == 2)
                {
                    RandomLastname();
                }
                else if (choice == 3)
                {
                    int[] answer = GuessNumber();
                    if (answer[0] == answer[1])
                    {
                        Console.WriteLine($"Grattis du valde {answer[0]} and the winning number was {answer[1]}");
                    }
                    else if (answer[0] != answer[1])
                    {
                        Console.WriteLine($"Otur, du valde {answer[0]} och det vinnande numret var {answer[1]} bättre lycka nästa gång!");
                    }
                }
                else if (choice == 4)
                {

                }
                else if (choice == 5)
                {

                }
                else if (choice == 6)
                {

                }
                else if (choice == 7)
                {

                }
                else
                {
                    Console.WriteLine("Fel val pappskalle, skärp dig!");

                }
                Console.WriteLine("Do you want to try again? ");
                Console.WriteLine("1. Yes ");
                Console.WriteLine("2. No ");
                int yesNo = Convert.ToInt32(Console.ReadLine());
                if (yesNo == 1)
                    keepGoing = true;
                else if (yesNo == 2)
                {
                    Console.WriteLine("Tack för ditt deltagande, välkommen åter!");
                    keepGoing = false;

                }
                else
                {
                    Console.WriteLine("Felaktig inmatning.");
                    keepGoing = true;
                }

            } while (keepGoing == true);



        }
        static int SimpleCalculator(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static void RandomLastname()
        {
            Console.WriteLine("Vad heter du?: ");
            string name = Console.ReadLine();
            Random rand = new Random();
            string[] lastNames = new string[4] {"Saxbacke", "Laengstjaert", "Pjuttgren", "Stolpskott"};
            lastNames[0] = "Saxbacke";
            lastNames[1] = "Laengstjaert";
            lastNames[2] = "Pjuttgren";
            lastNames[3] = "Stolpskott";
            int mixed = rand.Next(lastNames.Length);
            Console.WriteLine("Hej " + name + " " + lastNames[mixed]);

        }
        static int[] GuessNumber()
        {
            int[] lucky7 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            Random rand = new Random();
            int win = (rand.Next(lucky7.Length));
            Console.WriteLine("Skriv ett tal mellan 1 och 7");
            int numb = Convert.ToInt32(Console.ReadLine());
            int[] returnNumb = new int[2];
            returnNumb[0] = win;
            returnNumb[1] = numb;

            return returnNumb;
        }       
        // --------------------------------------------------------------------------------------------------------------------
        // ***************************************** ÖVNINGAR 5 V 3 ***********************************************************
        // --------------------------------------------------------------------------------------------------------------------


        //1.Skapa ett program som har en en array eller lista för strängar som du du kalla kompisLista.
        //2.Fyll den med minst tre namn.T.ex.Robin, Björn B, Björn S.
        //3.Skriv en foreach-loop för varje sträng kompis i kompisLista.
        //4.I din loop skriv ut "Hej " + namnet på en kompis så att alla kompisar har blivit hälsade på när loopen körts klart.

        //5.Skriv en metod static void HälsaPå(string kompis)
        //6.Flytta innehållet i forloop från uppgift 3.till din metod. 
        //7.I ditt huvudprogram(Main) gör så att loopen kallar på HälsaPå(kompis) istället för att skriva ut själv. 
        //    Bonusuppgift: För att göra hälsningen lite mindre stel testa att använda Random rnd = new Random(); och en
        //    string array med olika hälsningsfraser för att blanda vilka fraser du använder för att hälsa på dina kompisar

        //8.Skriv en metod sorteraTreTal som tar tre tal som paramterar och returnerar en array.
        //9.Skapa en array och placera dina tre tal i storleksordning i arrayen.
        //    Du kan återanvända kod från tidigare uppgifter för att ta reda på vilket tal som är stört, mellan och minst.
        //10.Returnera arrayen.
        //11.Testa så att metoden fungerar genom att skriva ut arrayen med hjälp av en foreach-loop i huvudprogrammet.

        //12.Skriv en metod static int Hexagontal som tar en int n som parameter. 
        //13.I metoden skapa en variabel för summan och sätt det till 0.
        //14.Skriv en for-loop som går från k = 0 till k < n.
        //15.I loopen öka summan med 4 * k + 1.
        //16.Returnera summan
        //17.I huvudprogrammet anropa på metoden och skriv ut returvärdet till konsolen.

        //   För att kolla om du gjort rätt så ger n = 1-> 1, n = 2-> 6, n = 3-> 15, n = 4-> 28

        //   https://sv.wikipedia.org/wiki/Hexagontal 


        //Avancerad uppgift till er som vill ha lite utmaning: 


        //Triangeltal är som kan modelleras som trianglar eller trappor.T.ex. 3 = 1 + 2 eller 10 = 1 + 2 + 3 + 4.
        //19.Skapa en metod som givit ett tal testar med hjälp utav en loop ifall det talet är ett triangel tal.

        //   Så i det här fallet ska du bruteforca talet på något sätt eftersom det är programmering vi ska öva på och inte matte.
        //20.Om talet är ett triangeltal så ska metoden kalla på en annan metod som skriver ut det i trapform:

        //                  10

        //               6  9

        //           3  5  7

        //       1  2  3  4

        //   Dvs varje position i trappan ska skriva ut antalet platser till vänster och under det.

        // }
        // ------------------------------------------------------------------------------------------------------------------
        // ************************************ START ÖVNINGAR 5 v 3 EXERCISES 5 ********************************************
        // ------------------------------------------------------------------------------------------------------------------
        //static void Main(string[] args)
        //{

        //}



    }
}
