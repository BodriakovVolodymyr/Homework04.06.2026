namespace _04._06._2026
{
    internal class Program
    {
        static void Main(string[] args)
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



        }
    }
}
