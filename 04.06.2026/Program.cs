namespace _04._06._2026
{
    internal class Program
    {
        //Task1
        /*static void Main(string[] args)
        {
            int[] A = new int[5];
            float[,] B = new float[3, 4];

            float minElement=A[0];
            float maxElement=A[0];
            float sum = 0;
            float product = 1;
            float sum_of_even_arrA = 0;
            float sum_add_columns_arrB = 0;


            Random Rnum = new Random();

            Console.WriteLine("Enter 5 elements for array A:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < B.GetLength(0); i++)
            {
                for(int j = 0; j < B.GetLength(1); j++)
                {

                    B[i, j] = (float)Rnum.NextDouble() * 10;
                    
                }
            }
            

            Console.WriteLine("\nArray A: ");
            foreach (int num in A)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();


            Console.WriteLine("\nArray B: ");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write($"{B[i, j]:F2}\t");
                }
                Console.WriteLine();
            }

            foreach (int num in A)
            { 
            if(num < minElement)
                {
                    minElement = num;
                }
            if (num > maxElement)
                {
                    maxElement = num;
                }
            sum += num;
            product *= num;
            if(num % 2 == 0)
                {
                    sum_of_even_arrA += num;
                }
            }

            for(int i = 0; i < B.GetLength(0); i++)
            {
                for(int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] > maxElement)
                    {
                        maxElement = B[i, j];
                    }
                    if (B[i, j] < minElement)
                    {
                        minElement = B[i, j];
                    }
                    sum += B[i, j];
                    product *= B[i, j];

                    if(j%2 == 0)
                    {
                        sum_add_columns_arrB += B[i, j];
                    }
                }
            }

            Console.WriteLine($"\nMinimum element: {minElement}");
            Console.WriteLine($"\nMaximum element: {maxElement}");
            Console.WriteLine($"\nSum of all elements: {sum}");
            Console.WriteLine($"\nProduct of all elements: {product}");
            Console.WriteLine($"\nSum of even elements in array A: {sum_of_even_arrA}");
            Console.WriteLine($"\nSum of elements in even columns of array B: {sum_add_columns_arrB:F2}");
        }*/

        //Task2
        /*static void Main(string[] args)
        {
            int[,] B = new int[5, 5];
            
            int minPos = 0;
            int maxPos = 0;
            int counter = 0;
            int sum = 0;
            Random Rnum = new Random();

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = (int)Rnum.Next(-100,101);
                }
            }


            int minEll = B[0, 0];
            int maxEll = B[0, 0];



            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] < minEll)
                    {
                        minEll = B[i, j];
                        minPos = counter;
                    }
                    if (B[i, j] > maxEll)
                    {
                        maxEll = B[i, j];
                        maxPos = counter;
                    }
                    counter++;
                }
            }
            counter = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if ((minPos < counter) && (counter < maxPos)||
                        (maxPos < counter) && (counter < minPos))
                    {
                        sum += B[i, j];
                    }
                    counter++;
                }
            }

            Console.WriteLine("\nArray B: ");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write($"{B[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nSum of elements between min {minEll} and max {maxEll} is: {sum}");

        }*/

        //Task4
        /*static void Main(string[] args)
        { 
            int[,]C = { {1, 2},
                    {3, 4} };
            int[,]D = { {6, 3},
                    {9, 1} };
            int[,] E = new int[C.GetLength(0), D.GetLength(1)];

            Console.WriteLine("Original array C: ");
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write($"{C[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Original array D: ");
            for (int i = 0; i < D.GetLength(0); i++)
            {
                for (int j = 0; j < D.GetLength(1); j++)
                {
                    Console.Write($"{D[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Array C after * 4: ");

            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write($"{C[i, j]*4}\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Array C after addition array D: ");
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write($"{C[i, j] + D[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Product of arrays C and D: ");

            for (int i = 0; i < E.GetLength(0); i++)
            {
                for (int j = 0; j < E.GetLength(1); j++)
                {
                    E[i, j] = 0;
                    for (int k = 0; k < C.GetLength(1); k++)
                    {
                        E[i, j] += C[i, k] * D[k, j];
                    }
                    Console.Write($"{E[i, j]}\t");
                }
                Console.WriteLine();
            }

        }*/


        //Task3
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter some text:");
            string? text = Console.ReadLine();
            Console.WriteLine("Enter the number by which you want to shift: ");
            int shift = int.Parse(Console.ReadLine());
            string? changed_text="";
            for (int i = 0; i < text.Length; i++)
            { 
            char symbol =(char) ((int)text[i]+shift);
                if((int)symbol>122)
                {
                    symbol = (char)(symbol - 26);
                }
            changed_text += symbol;
            }
            Console.WriteLine($"Your message after recoding: {changed_text}");



        
        }*/

        //Task5
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter some text:");
            char[]? text = Console.ReadLine().ToCharArray();

            int res = 0;
            int num = 0;
            char operation = '+';


            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    num = num * 10 + (text[i] - '0');
                }
                if (text[i] == '+' || text[i] == '-')
                {
                    if (operation == '+')
                    {
                        res += num;
                    }
                    else
                    {
                        res -= num;
                    }

                    operation = text[i];
                    num = 0;
                }


            }
            if (operation == '+')
            {
                res += num;
                num = 0;
            }
            if (operation == '-')
            {
                res -= num;
                num = 0;
            }
            Console.WriteLine($"Result: {res}");
        }*/
    }
}