namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string input;
            Console.WriteLine("Enter 1st Number :");
            input = Console.ReadLine();  //waits for user to hit return
            num1 = Convert.ToInt32(input);
            Console.WriteLine("Enter 2nd Number :");
            input = Console.ReadLine();
            num2 = Convert.ToInt32(input);
            Console.WriteLine("Sum is : {0}", sum(num1, num2));
            Console.WriteLine("Power is : {0}", power(num1, num2));
            //{0} takes 1st argument and substitutes into string
            Console.ReadKey();  //waits for a key to press before ending

        }

        static int sum(int x, int y)
        {
            return x + y;
        }

        static int power(int x, int y)
        {
            int z = x;
            for (int i = 0; i < y; i++) // for loop where i = 0, run loop whilst i is less than y, add 1 to i each time loop runs.
            {

               z = z * x;  // each time the loop runs, multiply z by x and set z to the result.
            }
            return z;

        }

    }
}
