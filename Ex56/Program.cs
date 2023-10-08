// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = WorkWithUser("Введите кол-во строк: ");
int columns = WorkWithUser("Введите кол-во столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
System.Console.WriteLine();
FindRowWithMinSum(array);

int WorkWithUser(string message)
{
    System.Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number; 
}

int[,] GetArray(int row, int column)
{
    int[,] result = new int[row, column];
    Random rnd = new Random();  
    for(int i = 0; i < row; i++)
    { 
        for (int j = 0; j < column; j++)
        {
            result[i, j] = rnd.Next(1, 10); 
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++) // GetLength(0) для строчик
    { 
        for (int j = 0; j < inArray.GetLength(1); j++) //GetLength(1) для столбца
        {
            System.Console.Write($"{inArray[i, j]} "); 
        }
        System.Console.WriteLine();
    }
}

void FindRowWithMinSum(int[,] matrix)
{
    int minSum = int.MaxValue;  // устанавливаем начальное значение на максимально возможное
    int minRowIndex = -1;  // индекс строки с наименьшей суммой

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int currentRowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentRowSum += matrix[i, j];
        }

        if (currentRowSum < minSum)
        {
            minSum = currentRowSum;
            minRowIndex = i;
        }
    }
    
    System.Console.WriteLine($"Строка с наименьшей суммой элементов = {minRowIndex + 1}");
}

