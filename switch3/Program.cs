namespace switch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string option =Console.ReadLine();

            switch(option)
            {
                case "1":
                    Console.WriteLine("case1");
                   break;

                case "2":
                    Console.WriteLine("case2");
                    break;

                case "3":
                    Console.WriteLine("case3");
                    break;

                default:
                    Console.WriteLine("slay");
                    break;
            }
        }
    }
}
