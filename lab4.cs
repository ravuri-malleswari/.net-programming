using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultithreadingTutorial
{
    class HelloThread
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Create new Thread...\n");

            // Creates a child thread, which runs in parallel with the main thread.
            Thread newThread = new Thread(WriteB);

            Console.WriteLine("Start newThread...\n");

            // Start the thread
            newThread.Start();

            Console.WriteLine("Call Write('-') in main Thread...\n");

            // In the main thread print out character '-'
            for (int i = 0; i < 50; i++)
            {
                Console.Write('-');

                // Sleep 70 millisenconds.
                Thread.Sleep(70);
            }


            Console.WriteLine("Main Thread finished!\n");
            Console.Read();
        }

        public static void WriteB()
        {
            // Print out the 'B' 100 times.
            for (int i = 0; i < 100; i++)
            {
                Console.Write('B');

                // Sleep 100 millisenconds
                Thread.Sleep(100);
            }

        }
    }


}


