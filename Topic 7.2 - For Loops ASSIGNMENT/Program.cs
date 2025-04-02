namespace Topic_7._2___For_Loops_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1 - Counting down
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Blast off!");
            
            
            // Assignment 2 - X and Y
            
            Console.WriteLine("X\tY");
            Console.WriteLine("------------");
            for (int x = -10; x <= 10; x+=2)
            {
               
                    Console.WriteLine(x + "\t" + (x * x));
                
            }


            // Assignment 3 - For Loop fun
            int nameLoop = 5;
            Console.WriteLine("Whats your name?");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            if (name.ToLower() != "aldworth")
            {
                nameLoop = 10;
            }
            for (int i = 0; i < nameLoop; i++)
            {
                Console.WriteLine(name);
            }
            
                
           





        }
    }
}
