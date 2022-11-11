//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Заполнение массива
double[,] GetRandomMatrixDouble(int rows, int column, int maxValue, int minValue )
{
    double [,] matrix = new double [rows,column];
    var random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue + 1) + random.NextDouble();
        }
    }
    return matrix;
}
//Печать массива
void printMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
}

 int rows = 4;
 int column = 3;
 double[,] matrix = GetRandomMatrixDouble(rows,column,100,0);
printMatrix(matrix);
Console.WriteLine();


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] GetRandomMatrix(int rows, int columns, int minVal, int maxVal) 
{ 
int[,] matrix = new int[rows, columns]; 
var random = new Random(); 
for (int i = 0; i < rows; i++) 
{ 
    for (int j = 0; j < columns; j++) 
    { 
        matrix[i,j] = random.Next(minVal, maxVal+1); 
    } 
} 
return matrix; 
} 
 
void PrintMatrix(int[,] matrix) 
{ 
    for (int i = 0; i < matrix.GetLength(0); i++) 
{ 
  for (int j = 0; j < matrix.GetLength(1); j++)   
  { 
    Console.Write(matrix[i,j] + " "); 
  } 
  Console.WriteLine();  
} 
} 

int[,] matrixRandom = GetRandomMatrix(4, 5, 0, 10);
PrintMatrix(matrixRandom); 
System.Console.WriteLine( );

Console.WriteLine("Введите строку ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите столбец ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

    if (pos1 < 0 | pos1 > matrixRandom.GetLength(0) - 1 | pos2 > matrixRandom.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента не существует"); 
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", matrixRandom[pos1, pos2]);
    } 
  Console.ReadLine();  


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.


int [,] array = GetRandomMatrix(4,5,0,10);
PrintMatrix(array); 
System.Console.WriteLine( );
double[] averageColumns = GetResultMatrix(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ", averageColumns)}");

char inputt1 = Console.ReadKey().KeyChar;

double[] GetResultMatrix(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        result[i] = Math.Round(sum / array.GetLength(0), 2);
    }
    return result;
}