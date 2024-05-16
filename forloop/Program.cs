namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int valik = Convert.ToInt32(Console.ReadLine());
            switch (valik)
            {
                case 1:
                    maja();
                    break;
                case 2:
                    teemant();
                    break;

            }
                
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
        static void teemant()
        {
            int i, j, count = 1, number;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());

            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }

            count = 1;
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
    }
}
