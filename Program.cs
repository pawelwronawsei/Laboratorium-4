using System.Reflection.Metadata.Ecma335;

namespace Laboratorium_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Arrays();
            //Zadanie1();
            //Zadanie2();
            Zadanie6();
            Console.ReadKey();
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

        public static void ZadanieZWhile()
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

        public static void Zadanie2()
        {
            double[] arr = { 12.5, 6.7, 2.89, 10.1, 2.45 };
            
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void Zadanie3()
        {
            int suma = 0;

            while(int.TryParse(Console.ReadLine(), out int value))
            {
                suma+=value;
            }

            Console.WriteLine(suma);
        }

        public static void Zadanie4()
        {
            double[,] arr = { { 1.1, 3.5, 2.56 }, { 1.4, 34, 7, }, { 1.5, 56, 2.6 } };
            double b = 4.1;

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > b)
                    {
                        Console.WriteLine(arr[i, j]);
                    }
                }

            }
        }

        public static void Zadanie5()
        {
            bool isValid = int.TryParse(Console.ReadLine(), out int value);

            while (!isValid || value < 0)
            {
                Console.WriteLine("Wpisz liczbę dodatnią!");
                isValid = int.TryParse(Console.ReadLine(), out value);
            }

            for(int i = 0; i < value; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < i + 1; j++)
                {
                    Console.Write("#");
                }
            }
        }

        public static void Zadanie6()
        {
            int n = int.Parse(Console.ReadLine());
            double[] myArray = new double[n];

            for(int i = 0;i < n; i++)
            {
                Console.WriteLine("WPISZ LICZBĘ: ");
                double val = double.Parse(Console.ReadLine());
                myArray[i] = val;
            }

            for(int i = myArray.Length - 1; i >= 0; i--)
            {
                if(myArray.Length % 2 == 0)
                {
                    if(i % 2 != 0)
                    {
                        Console.WriteLine(myArray[i]);
                    }
                    continue;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(myArray[i]);
                    }
                    continue;
                }  
            }
        }
    }
}