// See https://aka.ms/new-console-template for more inf
namespace fibonacci
{
    class program
    {
    //0,1,1,2,3,5,8,13,21,24
        static void Main(string[] args)
        {
            int next = 0;
            int prev = 0;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(next);
                if (next == 0)
                {
                    next = 1;

                }
                else
                {
                    int temp = next;
                    next = next + prev;
                    prev = temp;

                }

                Console.ReadLine();
            }
        }
     } 
}