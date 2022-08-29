/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/


System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
double[,] GetArray(int m , int n)
{
   double[,] matrix = new double[m,n]; //  создан массив заполненый нулями размером m  на n
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = (double) rand.NextDouble();
        matrix[i,j] = Math.Round(matrix[i,j],2);
    }
   }
   return matrix;
}
 double[,] resultMatrix = GetArray(rows,columns);
 PrintArray (resultMatrix);
 void PrintArray(double[,] inputMatrix)
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
