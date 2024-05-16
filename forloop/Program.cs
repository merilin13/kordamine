namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            maja();
        }
        static void maja() 
        {
            Console.WriteLine("maja");
            Console.WriteLine("sisesta maja suurus");

            int size = int.Parse(Console.ReadLine());
            int row;
            int column;

            for (column = 0; column < size; column++)
            {
                for (row = 1; row < size - column; row++)
                {
                    Console.Write(" ");
                }
                for (row = 1; row <= 2 * column - 1; row++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }


            for (row = 1; row <= size; row++)
            {
                for (column = 1; column <= size * 2 - 3; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 2)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}
