namespace whiledo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int num = Convert.ToInt32(Console.ReadLine());
            
            do 
            {
                Thread.Sleep(1000);
                Console.WriteLine(num++);
            }
            while (num > 0);
        }
    }
}
