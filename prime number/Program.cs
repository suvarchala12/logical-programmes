// See https://aka.ms/new-console-template for more information
namespace ConsoleApp
{
    class PrimeNumber

    {
        static void Main(string[] args)
        {
            int n=5,a=0;
            for (int i = 1; i <=1 ; i++)
            {
                if (n % i == 0)
                {
                    a++;
                    }
                }
            if (a == 2)
            {
             Console.WriteLine(" Number {0} is a PrimeNumber" ,n);
             }
              else
                { 
            
                Console.WriteLine("Number is  not a PrimeNumber.");
                }
            Console.ReadLine();
        }
    }

}


