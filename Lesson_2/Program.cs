/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер строчки на проверку: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер столбца на проверку: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int[,] GetArray(int m , int n)
{
 
   int[,] matrix = new int[m,n]; //  создан массив заполненый нулями размером m  на n
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(50);                   
    }
   }
   return matrix;
}
if (number>0||number<=rows||number1>0||number1<=columns)
  {
   int result = matrix[number,number1];
  Console.Write($"Значение элемента: {result}");
 }
else
{
    Console.Write($"такого элемента в массиве нету ");
}
 int[,] resultMatrix = GetArray(rows,columns);
 PrintArray (resultMatrix);
 void PrintArray(int[,] inputMatrix)
 {
     for (int k = 0; k < inputMatrix.GetLength(0); k++)
     {
         for (int m = 0; m < inputMatrix.GetLength(1); m++)
         {
         System.Console.Write(inputMatrix[k,m]+"\t");
         }
      System.Console.WriteLine();
     }
 }
