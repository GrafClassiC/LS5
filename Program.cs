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
