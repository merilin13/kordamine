namespace if_and_else_kordamine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int auto = 1000;
            int rekka = 5000;
            if (auto < rekka)
            {
                int vahe =(auto -rekka);
                Console.WriteLine("auto on" + vahe + "kg kergem kui rekka");
            }
            else
            {
                Console.WriteLine("rekka on kergem");
            }
        }
    }
}
