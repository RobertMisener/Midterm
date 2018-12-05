using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 Created Project Midterm
            Console.WriteLine("1) Midterm Project Created");
            //2
            Console.WriteLine("2) ");
            //3 Infinite loop
            Console.WriteLine("3) Infinite loop");
            bool keepLooping = false;
            while (keepLooping == true)
            {
                //keep looping
                Console.WriteLine("change this");
            }

            //4 : 2 to 128 
            Console.WriteLine("4) 2 to 128");
            int x = 2;
            while (x <= 64)
            {
                if (x == 2)
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine(x*2);

                x *= 2;
            }

            //5 40 to 1 (comma)
            Console.WriteLine("5) 40 to 1 (comma)");
            for (int xx = 49; xx > 0; --xx)
            {
                if (xx == 1)
                {
                    Console.Write(xx);
                }
                else
                {
                    Console.Write(xx + ", ");
                }
            }

            Console.WriteLine();
            //6 : 1 to 21 (odd) spaces
            Console.WriteLine("6) 1 to 21 odd - spaces");
            int xy = 1;
            while (xy <= 21)
            {
                if (xy % 2 != 0)
                {
                    Console.Write(xy + " ");
                }
                else { }
                xy++;
            }
            Console.WriteLine();

            Console.WriteLine("7) see comment in code");
            //7 What will output for code.
            //a) It will output * once, because do while loops always execute once
            //b) If it is only a while statement nothing will display because 10 (i) will never be less than 8 (n)


            //8 Multiple boolean value combinations
            //We combine or chain multiple boolean value combinations by using the opperands '&&'
            Console.WriteLine("8) Multiple Boolean combinations");
            Boolean icyRain = false;
            Boolean tornadoWarning = false;
            if (!icyRain && !tornadoWarning)
            {
                Console.WriteLine("Let's go outside!");
            }

            Console.WriteLine("9) (extra credit) Nested Loops");

            int [] array1 = new int [5] {1,2,3,4,5};
            int [] array2 = new int [4] {4,3,2,1};
            int a1Index = 5;
            int a2Index = 4;
            int counter = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int iii = 0; iii < a1Index; iii++)
                {
                    Console.Write(array1[iii]);
                }
                a1Index--;

                if (i < 3)
                {
                    for (int ix = counter; ix < a2Index; ix++)
                    {
                        Console.Write(array2[ix]);
                    }

                 counter += 1;
                }
                else if (i == 3)
                {
                    Console.Write(array2[3]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
