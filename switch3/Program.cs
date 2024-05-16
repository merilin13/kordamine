namespace switch3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali 1 või muidu");

            string option = Console.ReadLine();
            if (option == "1")
            {
                Case();
            }
            else
            {
                Console.WriteLine("pole sellist valikut");
            }
            
        }
        
        static void Case()
        {
            Console.WriteLine("kirjuta 1,2 või 3");
            string option = Console.ReadLine();
            switch (option)
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
                    Console.WriteLine("nope");
                    break;

            }
        }
    }
}
