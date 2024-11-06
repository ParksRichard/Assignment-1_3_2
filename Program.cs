namespace Assignment_1_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string answer;
            do
            {
                //Write a console application in C# to explore different ways in which array is declared and initialized and explore different properties and methods of Array class.
                //declaring the array thing
                string[] condiments;

                //int selection = 4; = old news
                Console.WriteLine("Roll to see what condiment Burger King is out of today.");
                Console.WriteLine("");
                Console.WriteLine("Unfortunately, you get no");
                //string selection = Console.ReadLine();
                Random rnd = new Random();

                condiments = new string[] { "Pickles", "Lettuce", "Tomato", "Horseradish", "Mustard", "Bacon" };

                Console.WriteLine(condiments[rnd.Next(0, 5)]);
                Console.WriteLine("");
                Console.WriteLine("Please see the total list of burger toppings.");
                Console.WriteLine("");

               //sort
               string[] condiments2 = { "Pickles", "Lettuce", "Tomato", "Horseradish", "Mustard", "Bacon" };
               foreach (string i in condiments2)

                    Console.WriteLine(i);

                Console.WriteLine("");
                Console.WriteLine("The total number of options on the menu is as follows");
                Console.WriteLine(condiments.Length);
                //end teh array w/ n-1
                {
                //int i = condiments.Length;
                //Array.Sort(condiments);
                //int[]  = new int[];
                //foreach (string i in condiments) ;
                //Console.WriteLine(i);
                }
                //int count = (i=0; i <n/2; i++);
                //reverse




                Console.ReadLine();
                Console.WriteLine("Do you want to try again?(Yup/Nope):");
                answer = Console.ReadLine();
            }
            while (answer == "Yup" || answer == "yup" || answer == "yes" || answer == "Yes");
            if (answer == "Nope");
            Console.WriteLine("");
            Console.WriteLine("Are you really really sure?");
            Console.WriteLine("");
            Console.WriteLine("Please come again!");
            
            // ((n-1)-1)
            //This is a note
            //lost in the sauce somewhere
        }
    }
}


