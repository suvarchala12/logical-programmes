// See https://aka.ms/new-console-template for more information
namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int  num, n, rev_no=0,r;;
            Console.Write("Enter the num :");
            n = num = Convert.ToInt32(Console.ReadLine());
            n = num;
            while(n!=0)
            {
                r = n % 10;
                rev_no = rev_no * 10 + r;
                n = n / 10;
            }
            if (num == rev_no)

                Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not a Palindrome Number");
            Console.ReadLine();
        }
    }
}