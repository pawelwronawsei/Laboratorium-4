namespace Laboratorium_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Arrays();
            //Zadanie1();
            Zadanie3();
        }

        public static void Arrays()
        {
            int[] intArray = { 1, 2, 3 };
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[intArray.Length - 1]);
            double[] factors = new double[10]; //OKREŚLA ILE LICZB W LIŚCIE
            factors[0] = 1.5;
            Console.WriteLine(factors[0]);
        }

        public static void Zadanie1()
        {
            double[] factors = { 1.5, 4.7, 1.5 };
            double x = 5.2;

            if (factors.Length >= 3)
            {
                double wynik = factors[0] * Math.Pow(x, 2) + factors[1] * x + factors[2];
                Console.WriteLine(wynik);
            }
            else
            {
                Console.WriteLine("Tablica nie ma odpowiedniej długości, minimalna długośc to 3");
            }
        }

        public static void ForStatement()
        {
            double[] factors = new double[10];

            for (int i = 0; i < factors.Length; i++)
            {
                factors[i] = i;
            }

            for (int i = factors.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(factors[i]);
            }

            foreach (double elem in factors)
            {
                Console.WriteLine(elem);
            }
        }

        public static void WhileStatement()
        {
            char input;
            while ((input = Console.ReadKey().KeyChar) != 'q')
            {
                Console.WriteLine(", Czekam na znak 'q'");
            }
        }

        public static void Zadanie3()
        {
            int i = 0;
            int input;
            int[] intArr = new int[10];
            while ((input = int.Parse(Console.ReadLine())) != 0 && i < intArr.Length)
            {
                intArr[i] = input;
                i++;
            }

            Console.WriteLine("WCZYTANE LICZBY");

            for (int j = 0; j < intArr.Length; j++)
            {
                Console.WriteLine(intArr[j]);
            }
        }
    }
}