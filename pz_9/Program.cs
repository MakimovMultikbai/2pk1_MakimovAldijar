namespace pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите число строк массива:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальное количество элементов в строчке массива:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное количество элементов в строчке массива:");
            int y = int.Parse(Console.ReadLine());
            double[][] mass = new double[a][];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = new double[rnd.Next(x, y)];
            }
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                {
                    mass[i][j] = rnd.Next(10, 100) + Math.Round(rnd.NextDouble(),2);
                    Console.Write(mass[i][j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            double[] end = new double[mass.Length];
            for(int i = 0; i < end.Length; i++)
            {
                end[i] = mass[i][^1];
                Console.Write(end[i]+"   ");
            }
            Console.WriteLine();
            double[][] swap = new double[mass.Length][];

 
            double max;
            double first = mass[0][0];
            max = mass[0][0];
            for (int i = 0; i < mass.Length; i++)
            {
                max = mass[i][0];
                for (int j = 1; j < mass[i].Length; j++)
                {
                    if (mass[i][j] > max)
                        max = mass[i][j];
                }
                first = mass[i][0];
                for (int j = 0; j < mass[i].Length; j++)
                {
                    swap[i][0] = max;
                    if (swap[i][j]==max)
                    {
                        swap[i][j] = first;
                    }
                }
                Console.Write(max+"   ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < swap.Length; i++)
            {
                for (int j = 0; j < swap[i].Length; j++)
                {
                    Console.Write(swap[i][j]+"   ");
                }
                Console.WriteLine();
            }
        }
    }
}
