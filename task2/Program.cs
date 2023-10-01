/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2 
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

System.Console.WriteLine("Введите размер массива");
string stroka = Console.ReadLine();
string[] str = stroka.Split(", ");
int n = int.Parse(str[0]);
int m = int.Parse(str[1]);
int indMin =0;

if (m == n)
{
    Console.WriteLine("Введите размеры прямоугольного двумерного массива");
}
else
{
    int[,] CreateRandomMatrix(int n, int m)
    {
        Random rand = new Random();
        int[,] array = new int[n, m];
        for (n = 0; n < array.GetLength(0); n++)
        {
            for (m = 0; m < array.GetLength(1); m++)
            {
                array[n, m] = rand.Next(1, 100);
            }
        }
        return array;
    }

    int[] GetSum(int[,] array)
    {
        int sum = 0;
        int[] sumStr = new int[n];
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int p = 0; p < array.GetLength(1); p++)
            {
                sum = sum + array[j, p];
            }
            sumStr[j] = sum;

            sum = 0;
        }
        return sumStr;
    }

int GetIndexStr(int [] sumStr)
{
    int min = sumStr[0];
  for (int i = 0; i < sumStr.Length; i++)
  {
    if(sumStr[i]<min)
    {min=sumStr[i];
    indMin = i;}
  }
  return indMin;
}
    void PrintArray(int[,] array)
    {
        for (int n = 0; n < array.GetLength(0); n++)
        {
            for (int m = 0; m < array.GetLength(1); m++)
            {
                System.Console.Write(array[n, m] + "\t");
            }
            System.Console.WriteLine();
        }
    }
    int[,] array = CreateRandomMatrix(n, m);
    PrintArray(array);
    System.Console.WriteLine();
    int[] result = GetSum(array);
    System.Console.WriteLine(string.Join("\t ", result));
    indMin = GetIndexStr(result);
    Console.WriteLine($"Наименьшая сумма строки {indMin} = {result[indMin]}");
    

}
