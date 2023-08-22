    namespace BubbleSort
{
    using System;

    class Program
    {
        public static int Main()
        {
            int[] ara = new int[] {12 , 10, 3, 8, 9, 2, 15, 1, 5, 4,  7};
            foreach (var i in ara)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            for (int i = 0; i < ara.Length; i++)
            {
                for (int j = 0; j < ara.Length - 1; j++)
                {
                    if (ara[j] > ara[j + 1])
                    {
                        int z = ara[j];
                        ara[j] = ara[j + 1];
                        ara[j + 1] = z;
                    }
                }
            }
            foreach (var i in ara)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.ReadKey();
            return 0;
        }
    }
}