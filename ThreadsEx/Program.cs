using System;
using System.Threading;

namespace ThreadsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();

        }

        public static void Ex1()
        {
            
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.WriteLine("Mamas");
                }

            });

            Thread thread2 = new Thread(() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.WriteLine("Empire");
                }

            });


            thread.Start();
            thread2.Start();

        }

        public static void Ex2()
        {
            int counter = 0;
            int mamasCounter = 0;
            int empireCounter = 0;


            Thread thread = new Thread(() =>
            {
                while (counter < 10000)
                {



                    if (counter % 2 == 0)
                    {
                        ++mamasCounter;
                        Console.WriteLine("Mamas");
                        counter++;
                    }




                }

            });

            Thread thread2 = new Thread(() =>
            {
                while (counter < 10000)
                {


                    if (counter % 2 != 0)
                    {
                        ++empireCounter;
                        Console.WriteLine("Empire");
                        counter++;

                    }



                }

            });


            thread.Start();
            thread2.Start();

            thread.Join();
            thread2.Join();


            Console.WriteLine($"all together {counter}");
            Console.WriteLine($"mamas {mamasCounter}");
            Console.WriteLine($"empire {empireCounter}");
        }

    }
}
