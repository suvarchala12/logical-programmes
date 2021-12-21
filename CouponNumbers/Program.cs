// See https://aka.ms/new-console-template for more information
using System;
using util;
namespace CouponNumbers
{
    class CouponNumber
    {
      public CouponNumber()
    {
            GenCoupan();
    }
        static void GenCoupan()
        {
            Utility u = new Utility();
            Console.WriteLine("Enter the number of coupans you want:");
            int num = u.ReadInt();
            Random PC = new Random();
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXTYZabcdefghijklmnopqrstuvwxyz";
            string[] array = new string[num];
            for (int i = 0;i<num;i++)
            {
                int rn1=PC.Next(0,100);
                int rn = PC.Next(26);
                char rn2 = alpha[rn];
                int rn3 = PC.Next(222, 444);
                int rn4 = PC.Next(20);
                char rn5 = alpha[rn4];
                int rn6 = PC.Next(26);
                char rn7 =  alpha[rn6];
                string coupon = " " + rn1 + rn2 + rn5 + rn7 + rn3 + rn2 + rn6 + rn2 + rn;
                array[i] = coupon;
                int val = i;
                if(i !=0)
                {
                    for (int j = 0; j <= 1 - 1; j++)
                    {
                        if (coupon == array[j])
                        {
                            j;
                        }
                         

                    }
                    Console.WriteLine("Total random number needed to have all distinct count");
                }



            }
        }
    }
}
