namespace ruudu_kuju_ja_pindala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            kuju();
        }

        static void kuju()
        {   Console.WriteLine("sisesta pikkus");
            int pikkus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta laius");
            int laius = Convert.ToInt32(Console.ReadLine());
            int pindala = (pikkus * laius);
            Console.WriteLine("Pindala on " + pindala + " midagi midagi.");
            int ümbermõõt = (pikkus * 2 + laius * 2);
            Console.WriteLine("Ümbermõõt on " + ümbermõõt + " midagi midagi.");
            for (int row = 1; row <= pikkus; row++)
            {

                if (row == 1 || row == laius)
                {
                    for (int col = 1; col <= pikkus; col++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }


                if (row < laius && row < laius - 1)
                {
                    Console.Write("*");
                    for (int i = 0; i < pikkus - 2; i++)
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
