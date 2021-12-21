namespace PerfectNumber
{
    class program
    {
        public static void Main(string[] args)
        {
            int number, sum = 0, n;
            Console.Write("Enter the number");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i <= 1; i++) 
            {
                if (number % i ==0)
                {
                  sum =  sum + i;
                }
             }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a PerfectNumber");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is a not PerfectNumber");
                Console.ReadLine();
            }

        }
    }
}
