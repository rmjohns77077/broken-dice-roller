public class Program
{
    public class diceRoller
    {
        //public static int sixSideDice(int num1, int num2, int num3)
        //{
        //   int num1= Random.Next
        //}


            static void Main()
            {
                Console.WriteLine("How many side dice would you like to roll?");
                string userInput = Console.ReadLine();
                int sides = int.Parse(userInput);
                if (userInput == "6")
                {




                    Console.WriteLine("Lets get Rollin'!");
                    Random random = new Random();

                    int num1 = random.Next(1, 7);
                    int num2 = random.Next(1, 7);
                    int totalRoll = num1 + num2;

                    if (num1 + num2 == 2)
                    {
                        Console.WriteLine("snake eyes" + num1 + "," + num2);
                    }
                    if (num1 + num2 == 12)
                    {
                        Console.WriteLine("Boxcars!" + num1 + "," + num2);
                    }
                    else if (totalRoll == 7 || totalRoll == 11)
                    {
                        Console.WriteLine("Winner!!!! " + num1 + "," + num2);
                    }
                    else if (num1 + num2 >= 2)
                    {
                        Console.WriteLine("Your rolls were " + num1 + " and " + num2);
                    }
                }

                else if (userInput != "6")
                {
                    Console.WriteLine("Should've choosen 6");
                }


            }








        

    }
}
