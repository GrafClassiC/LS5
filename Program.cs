// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/* Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */
/* internal class Program
{
    static void Main(string[] args)
    {
        int arr_n = int.Parse(Console.ReadLine());
        int arr_m = int.Parse(Console.ReadLine());
        int X = int.Parse(Console.ReadLine()), Y = int.Parse(Console.ReadLine());
        int[,] arr = new int[arr_n, arr_m];
        for (int i = 0; i < arr_n; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            for (int j = 0; j < arr_m; j++)
            {
                arr[i, j] = int.Parse(numbers[j]);
            }
        }
        Console.WriteLine(arr[Y, X]);
        Console.ReadLine();
    }
}
*/
// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
/* internal class Program
{
    static void Main(string[] args)
    {
        int arr_n = int.Parse(Console.ReadLine());
        int arr_m = int.Parse(Console.ReadLine());
        int[,] arr = new int[arr_n, arr_m];
        for(int i  = 0; i < arr_n; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            for(int j = 0; j < arr_m; j++)
            {
                arr[i, j] = int.Parse(numbers[j]);
            }
        }
        int[] intTemp1 = new int[arr_m];
        int[] intTemp2 = new int[arr_m];
        for (int i = 0; i < arr_m; i++)
        {
            intTemp1[i] = arr[0, i]; 
            intTemp2[i] = arr[arr_n-1, i]; 
        }
        for (int j = 0; j < arr_m; j++)
        {
            arr[0, j] = intTemp2[j];
            arr[arr_n - 1, j] = intTemp1[j];
        }
        for (int i = 0; i < arr_m; i++)
        {
            string res_ray = "";
            for (int j = 0; j < arr_m; j++)
            {
                res_ray += arr[i, j] + " ";
            }
            Console.WriteLine(res_ray);
        }
        Console.ReadLine();
    }
}
*/

// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
/* internal class Program
{
    static void Main(string[] args)
    {
        int arr_n = int.Parse(Console.ReadLine());
        int arr_m = int.Parse(Console.ReadLine());
        int[,] arr = new int[arr_n, arr_m];
        for (int i = 0; i < arr_n; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            for (int j = 0; j < arr_m; j++)
            {
                arr[i, j] = int.Parse(numbers[j]);
            }
        }
        int minSum = 1;
        int sum = SumLine(arr, 0);
        for (int i = 1; i < arr.GetLength(0); i++)
        {
            if (sum > SumLine(arr, i))
            {
                sum = SumLine(arr, i);
                minSum = i + 1;
            }
        }
        Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");
        Console.ReadLine();
    }

    static int SumLine(int[,] array, int i)
    {
        int sum = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        return sum;
    }
}
*/

