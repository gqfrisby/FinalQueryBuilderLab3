using QueryBuilder2.Models;
namespace QueryBuilder2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dbPath = "C:\\Users\\Gavin Frisby\\Source\\Repos\\QueryBuilder2\\Data\\data.db";
            QueryBuilder qb = new QueryBuilder(dbPath);
            string userChoice = "";
            List<Pokemon> pokemonList = new List<Pokemon>();
            List<BannedGame> games1 = new List<BannedGame>();

            int ID = 9999;
            int DexNumber = 9999;
            string name = "demo1";
            string form = "demo1";
            string type1 = "demo1";
            string type2 = "demo1";
            int total = 9999;
            int HP = 9999;
            int Attack = 9999;
            int Defense = 9999;
            int SpecialAttack = 9999;
            int SpecialDefense = 9999;
            int Speed = 9999;
            int Generation = 9999;
            Pokemon demo1 = new Pokemon(ID, DexNumber, name, form, type1, type2, total, HP, Attack, Defense, SpecialAttack, SpecialDefense, Speed, Generation);
            pokemonList.Add(demo1);

            int ID2 = 9999;
            int DexNumber2 = 9999;
            string name2 = "demo2";
            string form2 = "demo2";
            string type12 = "demo2";
            string type22 = "demo2";
            int total2 = 9999;
            int HP2 = 9999;
            int Attack2 = 9999;
            int Defense2 = 9999;
            int SpecialAttack2 = 9999;
            int SpecialDefense2 = 9999;
            int Speed2 = 9999;
            int Generation2 = 9999;
            Pokemon demo2 = new Pokemon(ID2, DexNumber2, name2, form2, type12, type22, total2, HP2, Attack2, Defense2, SpecialAttack2, SpecialDefense2, Speed2, Generation2);
            pokemonList.Add(demo2);

            int ID3 = 9999;
            string title = "demo1";
            string series = "demo1";
            string country = "demo1";
            string details = "demo1";
            BannedGame demo3 = new BannedGame(ID3, title, series, country, details);
            games1.Add(demo3);

            int ID4 = 9999;
            string title2 = "demo1";
            string series2 = "demo1";
            string country2 = "demo1";
            string details2 = "demo1";
            BannedGame demo4 = new BannedGame(ID4, title2, series2, country2 , details2);
            games1.Add(demo4);

            do
            {
                Console.WriteLine("Please Select What you would like to do with the database");
                Console.WriteLine("1.) Read");
                Console.WriteLine("2.) ReadAll");
                Console.WriteLine("3.) Create");
                Console.WriteLine("4.) Update");
                Console.WriteLine("5.) Delete");
                Console.WriteLine("6.) DeleteAll");
                Console.WriteLine("7.) Collection Demonstration");
                Console.WriteLine("8.) Stop");
                userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    Console.WriteLine("Insert the type of Object you are searching (BannedGame or Pokemon): ");
                    string table = Console.ReadLine();
                    if (table == "BannedGame")
                    {
                        Console.WriteLine("Please Insert The ID of the item you would like to look up");
                        string choice = Console.ReadLine();
                        int parsedChoice = Int32.Parse(choice);
                        BannedGame BG = qb.Read<BannedGame>(parsedChoice);
                        string bannedGame1 = BG.toString();
                        Console.WriteLine(bannedGame1);

                    }
                    else if (table == "Pokemon")
                    {
                        Console.WriteLine("Please Insert The ID of the item you would like to look up");
                        string choice = Console.ReadLine();
                        int parsedChoice = Int32.Parse(choice);
                        Pokemon PK = qb.Read<Pokemon>(parsedChoice);
                        string pokemon1 = PK.toString();
                        Console.WriteLine(pokemon1);

                    }
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("Please enter which table you would like to read (BannedGame or Pokemon): ");
                    string table1 = Console.ReadLine();
                    if (table1 == "BannedGame")
                    {
                        List<BannedGame> games = qb.ReadAll<BannedGame>();
                        foreach (BannedGame game in games)
                        {
                            Console.WriteLine(game.toString());
                            Console.WriteLine("----------------------------------------------------");
                        }

                    }
                    else if (table1 == "Pokemon")
                    {
                         List<Pokemon> pokemon = qb.ReadAll<Pokemon>();
                         foreach (Pokemon mon in pokemon)
                         {
                             Console.WriteLine(mon.toString());
                            Console.WriteLine("----------------------------------------------------");
                         } 
                    }
                }
                else if (userChoice == "3")
                {
                    Console.WriteLine("Please enter the type of object you would like to Create (BannedGame or Pokemon: ");
                    string userChoice3 = Console.ReadLine();
                    if (userChoice3 == "BannedGame")
                    {
                        Console.WriteLine("Please Enter the ID of the object you would like to create: ");
                        string preParse = Console.ReadLine();
                        int gameID = Int32.Parse(preParse);
                        Console.WriteLine("Title: ");
                        string gameTitle = Console.ReadLine();
                        Console.WriteLine("Series: ");
                        string gameSeries = Console.ReadLine();
                        Console.WriteLine("Country: ");
                        string gameCountry = Console.ReadLine();
                        Console.WriteLine("Details: ");
                        string gameDetails = Console.ReadLine();
                        BannedGame game = new BannedGame(gameID, gameTitle, gameSeries, gameCountry, gameDetails);
                        qb.Create<BannedGame>(game);
                        Console.WriteLine("Game has been Created");
                    }
                    if (userChoice3 == "Pokemon")
                    {
                        Console.WriteLine("Please Enter the ID of the object you would like to create: ");
                        string preParse = Console.ReadLine();
                        int monID = Int32.Parse(preParse);
                        Console.WriteLine("DexNumber: ");
                        string preParse1 = Console.ReadLine();
                        int monNumber = Int32.Parse(preParse1);
                        Console.WriteLine("Name: ");
                        string monName = Console.ReadLine();
                        Console.WriteLine("Form: ");
                        string monForm = Console.ReadLine();
                        Console.WriteLine("Type1: ");
                        string monType1 = Console.ReadLine();
                        Console.WriteLine("Type2: ");
                        string monType2 = Console.ReadLine();
                        Console.WriteLine("Total: ");
                        string preParse2 = Console.ReadLine();
                        int monTotal = Int32.Parse(preParse2);
                        Console.WriteLine("HP: ");
                        string preParse3 = Console.ReadLine();
                        int monHP = Int32.Parse(preParse3);
                        Console.WriteLine("Attack: ");
                        string preParse4 = Console.ReadLine();
                        int monAttack = Int32.Parse(preParse4);
                        Console.WriteLine("Defense: ");
                        string preParse5 = Console.ReadLine();
                        int monDefense = Int32.Parse(preParse5);
                        Console.WriteLine("SpecialAttack: ");
                        string preParse6 = Console.ReadLine();
                        int monSAttack = Int32.Parse(preParse6);
                        Console.WriteLine("SpecialDefense: ");
                        string preParse7 = Console.ReadLine();
                        int monSDefense = Int32.Parse(preParse7);
                        Console.WriteLine("Speed: ");
                        string preParse8 = Console.ReadLine();
                        int monSpeed = Int32.Parse(preParse8);
                        Console.WriteLine("Generation: ");
                        string preParse9 = Console.ReadLine();
                        int monGen = Int32.Parse(preParse9);
                        Pokemon mon = new Pokemon(monID, monNumber, monName, monForm, monType1, monType2, monTotal, monHP, monAttack, monDefense, monSAttack, monSDefense, monSpeed, monGen);
                        qb.Create<Pokemon>(mon);
                        Console.WriteLine("Pokemon has been created");
                    }
                }
                else if (userChoice == "4")
                {
                    Console.WriteLine("Please enter the type of object you would like to update (BannedGame or Pokemon: ");
                    string userChoice3 = Console.ReadLine();
                    if (userChoice3 == "BannedGame")
                    {
                        Console.WriteLine("Please Enter the ID of the object you would like to update: ");
                        string preParse = Console.ReadLine();
                        int gameID = Int32.Parse(preParse);
                        Console.WriteLine("(Updated) Title: ");
                        string gameTitle = Console.ReadLine();
                        Console.WriteLine("(Updated) Series: ");
                        string gameSeries = Console.ReadLine();
                        Console.WriteLine("(Updated) Country: ");
                        string gameCountry = Console.ReadLine();
                        Console.WriteLine("(Updated) Details: ");
                        string gameDetails = Console.ReadLine();
                        BannedGame game = new BannedGame(gameID, gameTitle, gameSeries, gameCountry, gameDetails);
                        qb.Update<BannedGame>(game);
                        Console.WriteLine("Game has been updated");
                    }
                    if(userChoice3 == "Pokemon")
                    {
                        Console.WriteLine("Please Enter the ID of the object you would like to update: ");
                        string preParse = Console.ReadLine();
                        int monID = Int32.Parse(preParse);
                        Console.WriteLine("(Updated) DexNumber: ");
                        string preParse1 = Console.ReadLine();
                        int monNumber = Int32.Parse(preParse1);
                        Console.WriteLine("(Updated) Name: ");
                        string monName = Console.ReadLine();
                        Console.WriteLine("(Updated) Form: ");
                        string monForm = Console.ReadLine();
                        Console.WriteLine("(Updated) Type1: ");
                        string monType1 = Console.ReadLine();
                        Console.WriteLine("(Updated) Type2: ");
                        string monType2 = Console.ReadLine();
                        Console.WriteLine("(Updated) Total: ");
                        string preParse2 = Console.ReadLine();
                        int monTotal = Int32.Parse(preParse2);
                        Console.WriteLine("(Updated) HP: ");
                        string preParse3 = Console.ReadLine();
                        int monHP = Int32.Parse(preParse3);
                        Console.WriteLine("(Updated) Attack: ");
                        string preParse4 = Console.ReadLine();
                        int monAttack = Int32.Parse(preParse4);
                        Console.WriteLine("(Updated) Defense: ");
                        string preParse5 = Console.ReadLine();
                        int monDefense = Int32.Parse(preParse5);
                        Console.WriteLine("(Updated) SpecialAttack: ");
                        string preParse6 = Console.ReadLine();
                        int monSAttack = Int32.Parse(preParse6);
                        Console.WriteLine("(Updated) SpecialDefense: ");
                        string preParse7 = Console.ReadLine();
                        int monSDefense = Int32.Parse(preParse7);
                        Console.WriteLine("(Updated) Speed: ");
                        string preParse8 = Console.ReadLine();
                        int monSpeed = Int32.Parse(preParse8);
                        Console.WriteLine("(Updated) Generation: ");
                        string preParse9 = Console.ReadLine();
                        int monGen = Int32.Parse(preParse9);
                        Pokemon mon = new Pokemon(monID, monNumber, monName, monForm, monType1, monType2, monTotal, monHP, monAttack, monDefense, monSAttack, monSDefense, monSpeed, monGen);
                        qb.Update<Pokemon>(mon);
                        Console.WriteLine("Game has been updated");
                    }
                }
                else if (userChoice == "5")
                {
                    Console.WriteLine("Please enter the type of object you would like to Delete (BannedGame or Pokemon: ");
                    string userChoice4 = Console.ReadLine();
                    if (userChoice4 == "BannedGame")
                    {
                        Console.WriteLine("Please Enter the ID of the object you would like to update: ");
                        string preParse = Console.ReadLine();
                        int gameID = Int32.Parse(preParse);
                        Console.WriteLine("(Current) Title: ");
                        string gameTitle = Console.ReadLine();
                        Console.WriteLine("(Current) Series: ");
                        string gameSeries = Console.ReadLine();
                        Console.WriteLine("(Current) Country: ");
                        string gameCountry = Console.ReadLine();
                        Console.WriteLine("(Current) Details: ");
                        string gameDetails = Console.ReadLine();
                        BannedGame game = new BannedGame(gameID, gameTitle, gameSeries, gameCountry, gameDetails);
                        qb.Delete<BannedGame>(game);
                        Console.WriteLine("Game has been updated");
                    }
                    else if(userChoice4 == "Pokemon")
                    {
                        Console.WriteLine("Please Enter the ID of the object you would like to update: ");
                        string preParse = Console.ReadLine();
                        int monID = Int32.Parse(preParse);
                        Console.WriteLine("(Current) DexNumber: ");
                        string preParse1 = Console.ReadLine();
                        int monNumber = Int32.Parse(preParse1);
                        Console.WriteLine("(Current) Name: ");
                        string monName = Console.ReadLine();
                        Console.WriteLine("(Current) Form: ");
                        string monForm = Console.ReadLine();
                        Console.WriteLine("(Current) Type1: ");
                        string monType1 = Console.ReadLine();
                        Console.WriteLine("(Current) Type2: ");
                        string monType2 = Console.ReadLine();
                        Console.WriteLine("(Current) Total: ");
                        string preParse2 = Console.ReadLine();
                        int monTotal = Int32.Parse(preParse2);
                        Console.WriteLine("(Current) HP: ");
                        string preParse3 = Console.ReadLine();
                        int monHP = Int32.Parse(preParse3);
                        Console.WriteLine("(Current) Attack: ");
                        string preParse4 = Console.ReadLine();
                        int monAttack = Int32.Parse(preParse4);
                        Console.WriteLine("(Current) Defense: ");
                        string preParse5 = Console.ReadLine();
                        int monDefense = Int32.Parse(preParse5);
                        Console.WriteLine("(Current) SpecialAttack: ");
                        string preParse6 = Console.ReadLine();
                        int monSAttack = Int32.Parse(preParse6);
                        Console.WriteLine("(Current) SpecialDefense: ");
                        string preParse7 = Console.ReadLine();
                        int monSDefense = Int32.Parse(preParse7);
                        Console.WriteLine("(Current) Speed: ");
                        string preParse8 = Console.ReadLine();
                        int monSpeed = Int32.Parse(preParse8);
                        Console.WriteLine("(Current) Generation: ");
                        string preParse9 = Console.ReadLine();
                        int monGen = Int32.Parse(preParse9);
                        Pokemon mon = new Pokemon(monID, monNumber, monName, monForm, monType1, monType2, monTotal, monHP, monAttack, monDefense, monSAttack, monSDefense, monSpeed, monGen);
                        qb.Delete<Pokemon>(mon);
                        Console.WriteLine("Pokemon has been deleted");
                    }
                }
                else if (userChoice == "6")
                {
                    Console.WriteLine("Please enter which table you would like to clear (BannedGame or Pokemon): ");
                    string table1 = Console.ReadLine();
                    if (table1 == "BannedGame")
                    {
                        qb.DeleteAll<BannedGame>();
                    }
                    else if (table1 == "Pokemon")
                    {
                        qb.DeleteAll<Pokemon>();
                    }
                    Console.WriteLine("Table Cleared");
                }
                else if (userChoice == "7")
                {
                    foreach (Pokemon mon in pokemonList)
                    {
                        qb.Create<Pokemon>(mon);
                    }
                    foreach (BannedGame game in games1)
                    {
                        qb.Create<BannedGame>(game);
                    }
                    Console.WriteLine("Demo Objects have been added to DataBase");
                }
            } while (userChoice != "8");
        }
    }
}