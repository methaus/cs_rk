using System;

namespace cs_rk
{
    class cs_rkrun
    {
        public static void Main()
        {
            Console.WriteLine("Pressione a tecla...");
            while (true) {
                var input = Console.ReadKey().Key;

                Console.WriteLine(
                    " --- tecla pressionada: {0}, {1}", 
                    input.GetHashCode(),
                    input.ToString()
                );

                if (input == ConsoleKey.Escape)
                    break;
            }
        }
    }
}