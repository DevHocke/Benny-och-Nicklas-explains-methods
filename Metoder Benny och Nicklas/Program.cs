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
        //static void Main(string[] args)
        //{
        //    StartProgram();
        //    Console.ReadLine();
        //}

        //static void StartProgram()
        //{
        //    bool keepGoing = false;

        //    do
        //    {
        //        Console.WriteLine("Hej och välkommen till lek med metoder! ");
        //        Console.WriteLine("1. Gör en enkel beräkning ");
        //        Console.WriteLine("2. Slumpa ett nytt efternamn ");
        //        Console.WriteLine("3. Gissa talet ");
        //        Console.WriteLine("4. Loopa igenom en lista ");
        //        Console.WriteLine("5. Bada en arg katt ");
        //        Console.WriteLine("6. Gör allting ");
        //        Console.WriteLine("7. Mixa ditt telefonnummer ");
        //        Console.WriteLine("8. EXIT");
        //        int choice = Convert.ToInt32(Console.ReadLine());

        //        if (choice == 1)
        //        {
        //            // Låter användaren skriva in två int tal som sedan skickar de två värdena till metoden SimpleCalculator,
        //            // i metoden SimpleCalculator adderas talen ihop och svaret returneras till metoden StartProgram och skriver ut det i konsolen.
        //            Console.WriteLine("Skriv ditt första tal: ");
        //            int numb1 = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("Skriv ditt andra tal: ");
        //            int numb2 = Convert.ToInt32(Console.ReadLine());
        //            int answer = SimpleCalculator(numb1, numb2);
        //            Console.WriteLine("Talet är: " + answer);
        //        }
        //        else if (choice == 2)
        //        {
        //            // Låter användaren skriva in sitt förnamn och får ett svar med ett random efternamn
        //            // som skrivs ut i consolen i metoden som är satt till void.
        //            RandomLastname();
        //        }
        //        else if (choice == 3)
        //        {
        //            // Låter användaren skriva in ett tal mellan 1 och 7 i metoden GuessNumber.
        //            // användarens tal och det slumpade talet lagras i en array som skickas tillbaks
        //            // till metoden StartProgram där en if sats styr vad som skrivs ut till användaren.
        //            int[] answer = GuessNumber();

        //             if (answer[0] == 1)
        //             {
        //                Console.WriteLine("Grattis du valde rätt nummer!");
        //             }
        //             else if (answer[1] == 0)
        //             {
        //                Console.WriteLine("Otur, du valde fel nummer bättre lycka nästa gång!");
        //             }
        //            Console.ReadLine();
        //            Console.Clear();
        //        }
        //        else if (choice == 4)
        //        {
        //            // Låter användaren skriva in 10 heltal i metoden loopThroughList.
        //            // Listan skrivs sedan ut i en forloop i metoden som är satt till void.
        //            LoopThroughList();
        //        }
        //        else if (choice == 5)
        //        {
        //            // Användaren får skriva ett tal mellan 0 och 10, talet skickas in i metoden DippThekitty där det jämförs mot två arrayer.
        //            // Om talet är ojämnt så returneras värdet 1 och så kastas den stackars katten i sjön. 
        //            // Är talet jämt så vinner katten.
        //            Console.WriteLine("Skriv ett nummer mellan 0 och 10.");
        //            int numbIn = Convert.ToInt32(Console.ReadLine());
        //            int wetDry = DippTheKitty(numbIn);
        //            Console.Clear();
        //            Console.WriteLine($"Du valde nummer {numbIn}");
        //            if (wetDry == 1)
        //            {
        //                Console.WriteLine("Fel nummer: Katten vann!");
        //            }
        //            else if (wetDry == 2)
        //            {
        //                Console.WriteLine("Rätt nummer: Du kastade den stackars katten i sjön!");
        //                Console.WriteLine("Inte konstigt att den är så arg... ;) ");
        //            }
        //            else if (wetDry == 3)
        //            {
        //                Console.WriteLine("Felaktig inmatning pappskalle!");
        //            }
        //            Thread.Sleep(3000);
        //            Console.Clear();
        //        }
        //        else if (choice == 6)
        //        {
        //            break;
        //        }
        //        else if (choice == 7)
        //        {
        //            break;
        //        }
        //        else if (choice == 8)
        //        {
        //            Console.WriteLine("Slipp då jäkla tråkmåns!");
        //            Thread.Sleep(3000);
        //            Console.Clear();
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Fel val pappskalle, skärp dig!");
        //        }
        //        Console.WriteLine("Do you want to try again? ");
        //        Console.WriteLine("1. Yes ");
        //        Console.WriteLine("2. No ");
                
        //        int yesNo = Convert.ToInt32(Console.ReadLine());
        //        if (yesNo == 1)
        //            keepGoing = true;
        //        else if (yesNo == 2)
        //        {
        //            Console.WriteLine("Tack för ditt deltagande, välkommen åter!");
        //            keepGoing = false;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Felaktig inmatning.");
        //            keepGoing = true;
        //        }

        //    } while (keepGoing == true);
        //}
        //static int SimpleCalculator(int a, int b)
        //{
        //    int sum = a + b;
        //    return sum;
        //}
        //static void RandomLastname()
        //{
        //    Console.WriteLine("Vad heter du?: ");
        //    string name = Console.ReadLine();
        //    Random rand = new Random();
        //    string[] lastNames = new string[4] {"Saxbacke", "Laengstjaert", "Pjuttgjen", "Stolpskott"};
        //    lastNames[0] = "Saxbacke";
        //    lastNames[1] = "Laengstjaert";
        //    lastNames[2] = "Pjuttgren";
        //    lastNames[3] = "Stolpskott";
        //    int mixed = rand.Next(lastNames.Length);
        //    Console.WriteLine("Hej " + name + " " + lastNames[mixed]);
        //}
        //static int[] GuessNumber()
        //{
        //    int[] lucky7 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
        //    int[] returnNumb = new int[2];
        //    Random rand = new Random();
        //    Console.WriteLine("Skriv ett tal mellan 1 och 7");
        //    int numb = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < lucky7.Length; i++)
        //    {
        //        int win = rand.Next(lucky7[i]);
        //        if (win == numb)
        //        {
        //            returnNumb[0] = 1;
        //        }
        //        else
        //        {
        //            returnNumb[1] = 0;
        //        }
        //    }
           
        //    return returnNumb;
        //}
        //static void LoopThroughList()
        //{
        //    List<int> loopThrough = new List<int>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{i} Skriv ett heltal"); 
        //        int numbIn = Convert.ToInt32(Console.ReadLine());
        //        loopThrough.Add(numbIn);
        //    }
        //    Console.Clear();
        //    foreach(var item in loopThrough)
        //    {
        //        Console.WriteLine($"Du valde nummer {item}");
        //    }
        //    Console.ReadLine();
        //    Console.Clear();
        //}
        //static int DippTheKitty(int x)
        //{
        //    int numbOut = 0;
        //    int[] even = new int[5] {2, 4, 6, 8, 10};
        //    int[] unEven = new int[5] {1, 3, 5, 7, 9};

        //    for (int i = 0; i < even.Length; i++)
        //    {
        //        if (even[i] == x)
        //        {
        //            numbOut = 1;
        //        }
        //    }
        //    for (int j = 0; j < unEven.Length; j++)
        //    {
        //        if (unEven[j] == x)
        //        {
        //            numbOut = 2;
        //        }
        //    }    
        //    if (numbOut == 1 || numbOut == 2)
        //    {
        //        return numbOut;
        //    }
        //    else
        //    {
        //        return 3;
        //    }
        //}
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
        /*
        static void Main(string[] args)
        {
        
            List<string> friendsList = new List<string>();
            friendsList.Add("Pelle");
            friendsList.Add("BennyBulaDenLillaFula");
            friendsList.Add("Kalle Stropp");

            NewMethod(friendsList);

            static void NewMethod(List<string> friendsList)
            {
                string[] myArray = new string[9];
                myArray[0] = "Du luktar så gott ";
                myArray[1] = "Imorgon är en ny dag ";
                myArray[2] = "Inga bullar för dig ";
                myArray[3] = "Massa bullar för dig ";
                myArray[4] = "Kom in i matchen ";
                myArray[5] = "Nope inte här heller ";
                myArray[6] = "Vill du ha en kaka ";
                myArray[7] = "Bussen gick för 5 min sedan ";
                myArray[8] = "Du är en pappskalle ";
                
                
                for (int i = 0; i < friendsList.Count; i++)
                {
                    Random rand = new Random();
                    String random = myArray[rand.Next(myArray.Length)];
                    Console.WriteLine(random + friendsList[i]);     
                }
            }

        } */

        //8.Skriv en metod sorteraTreTal som tar tre tal som paramterar och returnerar en array.
        //9.Skapa en array och placera dina tre tal i storleksordning i arrayen.
        //    Du kan återanvända kod från tidigare uppgifter för att ta reda på vilket tal som är stört, mellan och minst.
        //10.Returnera arrayen.
        //11.Testa så att metoden fungerar genom att skriva ut arrayen med hjälp av en foreach-loop i huvudprogrammet.
        // Default är en bool false.
        /*
        string enIfKontroll = default(string); // Default är en string "". Det går att kontrollera med isNullOrEmpty
        if (string.IsNullOrEmpty(enIfKontroll))
        {

        }
        
        int[] sortArray = new int[3];


         Console.WriteLine("Ange tal 1. ");
         sortArray[0] = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ange tal 2. ");
         sortArray[1] = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ange tal 3. ");
         sortArray[2] = Convert.ToInt32(Console.ReadLine());

        SorteraTreTal(sortArray);  // Kallar på metoden SorteraTreTal som tar in de tre talen från användaren och sorterar dem med Array.Sort

        foreach (var item in sortArray)
        {
            Console.WriteLine(item);
        }



        static int[] SorteraTreTal(int[] bumbiBjörnarna) // Tar in en int Array samt returnerar en int array. 
        {
            Array.Sort(bumbiBjörnarna);
        //  Array.Reverse(bumbiBjörnarna);  // Ändrar ordningen på arrayen.
            return bumbiBjörnarna;
        }
        */

        //12.Skriv en metod static int Hexagontal som tar en int n som parameter. 
        //13.I metoden skapa en variabel för summan och sätt det till 0.
        //14.Skriv en for-loop som går från k = 0 till k < n.
        //15.I loopen öka summan med 4 * k + 1.
        //16.Returnera summan
        //17.I huvudprogrammet anropa på metoden och skriv ut returvärdet till konsolen.

        //   För att kolla om du gjort rätt så ger n = 1-> 1, n = 2-> 6, n = 3-> 15, n = 4-> 28

        //   https://sv.wikipedia.org/wiki/Hexagontal 
        /*

            Console.WriteLine(Hexagontal(2));
            
            static int Hexagontal(int n)
            {
                int sum = default(int); // dafault in är 0.

                for (int k = 0; k < n; k++)
                {
                    sum += 4 * k + 1;  // += lägger till summan + det nya värdet. endast = ändrar värdet i sum.
                }

                return sum;
            }
            Console.ReadLine();

            */

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
        // ************************************ START ÖVNINGAR 6 v 3 EXERCISES 6 ********************************************
        // ------------------------------------------------------------------------------------------------------------------
        //                                  Metoder
        //1. Skapa en metod som tar in två argument, int a, int b och returnera a + b
        //2. Skapa en metod som tar in två argument, int a, int b och returnera a - b
        //3. Skapa en metod som tar in två argument, int a, int b och returnera a / b
        //4. Skapa en metod som tar in två argument, int a, int b och returnera a* b
        //5. Ge alla dessa beskrivande namn
         /*
        static void Main(string[] args)
        {
            bool keepGoing = false;
            do
            {
                Console.WriteLine("Hej och välkommen till övningar 6");
                Console.WriteLine("1. Gör en + beräkning ");
                Console.WriteLine("2. Gör en - beräkning ");
                Console.WriteLine("3. Gör en / beräkning ");
                Console.WriteLine("4. Gör en * beräkning ");
                Console.WriteLine("5. EXIT");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Skriv in heltal 1: ");
                    int numb1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv in heltal 2: ");
                    int numb2 = Convert.ToInt32(Console.ReadLine());
                    int sumPlus = PlusCalc(numb1, numb2);
                    Console.WriteLine($"The sum is: {sumPlus}");                   
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Skriv in heltal 1: ");
                    int numb1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv in heltal 2: ");
                    int numb2 = Convert.ToInt32(Console.ReadLine());
                    int sumPlus = MinusCalc(numb1, numb2);
                    Console.WriteLine($"The sum is: {sumPlus}");                  
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Skriv in heltal 1: ");
                    int numb1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv in heltal 2: ");
                    int numb2 = Convert.ToInt32(Console.ReadLine());
                    int sumPlus = DividedCalc(numb1, numb2);
                    Console.WriteLine($"The sum is: {sumPlus}");  
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Skriv in heltal 1: ");
                    int numb1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv in heltal 2: ");
                    int numb2 = Convert.ToInt32(Console.ReadLine());
                    int sumPlus = MultCalc(numb1, numb2);
                    Console.WriteLine($"The sum is: {sumPlus}");                    
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Program EXIT");
                    break;
                }
                Console.WriteLine("do you want to do any other calculation?");
                Console.WriteLine("1. Yes.");
                Console.WriteLine("2. No.");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    keepGoing = true;
                }
                else if (answer == 2)
                {
                    keepGoing = false;
                }
                else
                {
                    break;
                }
            } while(keepGoing == true);

            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }
        static int PlusCalc(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int MinusCalc(int a, int b)
        {
            int sum = a - b;
            return sum;
        }
        static int DividedCalc(int a, int b)
        {
            int sum = a / b;
            return sum;
        }
        static int MultCalc(int a, int b)
        {
            int sum = a * b;
            return sum;
        }
        */
        // ---------------------------------------------------------------------------------------------------------------------------
        //6. Skapa en metod som tar in basen och höjden av en triangel och returnera arean
        //7. Skapa en metod som tar in en bool och returnera det motsatta
        //8. Skapa en metod som tar in en lista och returnerar det sista elementet
        //9. Skapa en metod som tar in ett heltal och multiplicera talet med 10. Kalla sedan på en annan metod från första metoden och returnera det talet delat på 5

        //10. Skapa en lista av strings med fyra element "Det" "var" "en" "gång..."
        //11. Ta listan av strings och skicka in den i en kedja av metoder.
        //12. För varje metod lägg till en string i listan
        //13. När det finns 10 element i listan, skriv ut allt på en rad separerat med,

        //14. Skapa ett program som ber användaren mata in ett tal 10 gånger.Spara undan dessa i en lista
        //15. Skicka in listan i en metod som heter SortEven.
        //16. För varje element i listan: Kolla om talet är jämt
        //17. Om talet är jämt skicka in talet till en annan metod som lägger till det i en lista.
        //18. Gör likadant med ojämna tal
        //19. Skriv sedan ut de båda listorna med antalet jämna och ojämna tal

        //20. Skriv en metod som tar konvertrar timmar till minuter
        //21. Använd sedan minuterna som argument till en annan metod som konverterar minuter till sekunder. 
        //22. Skriv sedan ut vad timmar blir i minuter och hur många sekunder det är totalt

        //23. Hur mycket är sant? Skriv en metod som kollar en array av bool statements och retunera antalet true/false
        //24. Om antalet true är mer än false skriv ut "In wine there is potatos!" annars skriv ut "lies lies lies..."


        //static void Main(string[] args)
        //{

        //}



    }
}
