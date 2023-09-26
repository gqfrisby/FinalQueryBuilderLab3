
namespace QueryBuilder2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dbPath = "C:\\Users\\gqfri\\source\\repos\\QueryBuilder\\QueryBuilder\\Data\\data.db";
            QueryBuilder qb = new QueryBuilder(dbPath);
            Console.WriteLine("Please Select What you would like to do with the database");
            Console.WriteLine("1.) Read");
            Console.WriteLine("2.) ReadAll");
            Console.WriteLine("3.) Create");
            Console.WriteLine("4.) Update");
            Console.WriteLine("5.) Delete");
            Console.WriteLine("6.) DeleteAll");
            Console.WriteLine("7.) Stop");

            string userChoice = Console.ReadLine();
            do
            {
                if (userChoice == "1")
                {
                    Console.WriteLine("Please Insert The ID of the item you would like to look up";
                    string choice = Console.ReadLine();
                    int parsedChoice = Int32.Parse(choice);
                    qb.Read<int>(parsedChoice);
                }
                else if (userChoice == "2")
                {
                    qb.ReadAll();
                }
                else if (userChoice == "3")
                {
                    qb.Create();
                }
                else if (userChoice == "4")
                {
                    qb.Update();
                }
                else if (userChoice == "5")
                {
                    qb.Delete();
                }
                else if (userChoice == "6")
                {
                    qb.DeleteAll();
                }
            } while (userChoice != "7");
        }
    }
}