// Задача 50. 
// Напишите программу, 
//которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [3,3];
InputMatrix(matrix);

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {matrix[n-1,m-1]}");
}
PrintMatrix(matrix);

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {        
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
