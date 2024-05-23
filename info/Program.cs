namespace info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vali 1, 2, 3 või 4");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    kuju();
                    break;

                case "2":
                    foreach1();
                    break;
                case "3":
                    LINQwhere();
                    break;
                case "4":
                    püramiid();
                    break;
                case "5":
                    kalkulaator();
                    break;

                default:
                    Console.WriteLine("sisestatud on midagi muud");
                    break;

            }

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

        static void foreach1()
        {
            string[] array = new string[] { "piip", "tuut", "karje", "boing", "zzzzzz" };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void LINQwhere()
        {
            var peopleAge = Peoplelist.peoples
                    .Where(x => x.Age > 20 && x.Age < 30);

            foreach (var person in peopleAge)
            {
                Console.WriteLine(person.Name + " " + person.Age + " " + person.Id);
            }
        }
        static void püramiid()
        {
            Console.Write("sisesta ridade arv ");

            int rows = int.Parse(Console.ReadLine());

            int i = 1;

            int spaces = rows - 1;

            while (i <= rows)
            {
                int j = 1;

                while (j <= spaces)

                {
                    Console.Write(" ");
                    j++;
                }

                j = 1;

                while (j <= 2 * i - 1)
                {
                    Console.Write("*");

                    j++;
                }
                Console.WriteLine();
                i++;

                spaces--;
            }
            Console.ReadKey();

        }

        static void kalkulaator()
        {
            Console.WriteLine("kalkulaator");
            Console.WriteLine("sisesta esimene number");
            float nr1 = float.Parse(Console.ReadLine());
            Console.WriteLine("sisesta tehe");

            string arvutus = Console.ReadLine();

            Console.WriteLine("siseta teine number");
            float nr2 = float.Parse(Console.ReadLine());

            switch (arvutus)
            {

                case "+":
                    Add(nr1, nr2);
                    break;
                case "-":
                    Minus(nr1, nr2);
                    break;
                case "/":
                    Div(nr1, nr2);
                    break;
                case "*":
                    Mult(nr1, nr2);
                    break;
                case "juur"

                    break;
            }
        }
        static void Add(float nr1, float nr2)
        {

            float resultadd = nr1 + nr2;
            Console.WriteLine("Tulemus: " + resultadd);

        }
        static void Minus(float nr1, float nr2)
        {
            float resultmin = nr1 - nr2;
            Console.WriteLine("Tulemus: " + resultmin);
        }
        static void Div(float nr1, float nr2)
        {
            float resultdiv = nr1 / nr2;
            Console.WriteLine("Tulemus: " + resultdiv);
        }
        static void Mult(float nr1, float nr2)
        {
            float resultmult = nr1 * nr2;
            Console.WriteLine("Tulemus: " + resultmult);
        }
        static void Ruut(float nr1)
        {
            float resultmult = Math.Sqrt(nr1);
            Console.WriteLine("Tulemus: " + resultmult);
        }
    }

}
