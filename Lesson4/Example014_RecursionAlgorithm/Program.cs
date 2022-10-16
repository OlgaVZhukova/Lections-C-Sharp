
string[,] table = new string[2, 5];
// table[1, 2] = "слово";

// для того, чтобы обратиться к нужному элементу, указываем наименование массива,
// а в квадратн. скобках сначала индекс строки, затем индекс столбца.
// индексы меняются от нуля:
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]
// инициализация строк по умолчанию происходит такой константой:
// String.Empty

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"--{table[rows, columns]}--");
//     }
// }


// int[,] matrix = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         System.Console.Write($"{matrix[i, j]} ");
//     }
//     System.Console.WriteLine();
// }

// Опишем метод, который будет отдельно печатать такую двумерную матрицу
// на экран и заполнять ее числами.

void PrintArray(int[,] matr)     // 1.
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

// тут опишем дополнительный метод, кторый будет заполнять
// нашу матрицу случайными числами.

void FillArray(int[,] matr) // 3. метод, кторый будет заполнять нашу матрицу случайными числами.
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           matr[i, j] = new Random().Next(1, 10);   // тут обращаемся к конкретному элементу на позиции i, j из полуинтервала случ. чисел от 1 до 10 
        }
    }
}

int[,] matrix = new int[3, 4];  // 2. Определяем матрицу
PrintArray(matrix);             // 3. вызываем функцию (метод)
FillArray(matrix);
System.Console.WriteLine(); // прослойка между нулями и заполненным массивом
PrintArray(matrix);



