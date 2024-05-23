namespace ristkülik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            kuju();
        }

        static void kuju()
        {
            Console.WriteLine("sisesta pikkus");
            int pikkus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta laius");
            int laius = Convert.ToInt32(Console.ReadLine());
            int pindala = (pikkus * laius);
            Console.WriteLine("Pindala on " + pindala + " midagi midagi.");
            int ümbermõõt = (2 * (pikkus + laius));
            Console.WriteLine("Ümbermõõt on " + ümbermõõt + " midagi midagi.");

            for (int row = 1; row <= pikkus; row++)
            {

                if (row == 1 || row == pikkus)
                {
                    for (int col = 1; col <= laius; col++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                if (row < pikkus && row < pikkus - 1)
                {
                    Console.Write("*");
                    for (int i = 0; i < laius - 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
    }
}
