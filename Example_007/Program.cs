/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]}, ");
    }
}

int [] array = new int[8];
array[0] = 1;
array[1] = 2;
array[2] = 5;
array[3] = 7;
array[4] = 19;

PrintArray(array);