// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [n, m];
InputMatrix(matrix );


for (int j = 0; j < matrix .GetLength(1); j++)
{
    decimal avarage = 0;
    for (int i = 0; i < matrix .GetLength(0); i++)
    {
        avarage = (avarage + matrix [i, j]);
    }
    avarage = avarage / n;
   
    Console.Write(decimal.Round(avarage, n, MidpointRounding.AwayFromZero) + "; ");
   
    
}
Console.WriteLine();
PrintMatrix(matrix );



void InputMatrix(int[,] matrix )
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix )
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix [i, j] + " ");
        }
        Console.Write("]");
        
        Console.WriteLine("");
    }
}