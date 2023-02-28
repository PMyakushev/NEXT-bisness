/* 
Сортировка пузырьком
[3, 1, 5, 0, 7, 9, 8]
1.[1, 3, 5, 0, 7, 9, 8]
2.[1, 3, 0, 5, 7, 9, 8]
3.[1, 0, 3, 5, 7, 9, 8]
4.[0, 1, 3, 5, 7, 9, 8]
5.[0, 1, 3, 5, 7, 8, 9]
6.[0, 1, 3, 5, 7, 8, 9]
*/
using static System.Console;
WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Write("Введите значения массива: ");
    array[i] = Convert.ToInt32(ReadLine());
}
WriteLine("Начальный массив: ["+ string.Join(", ", array) + "]");
WriteLine();
for (int i = 0; i < array.Length; i++) // i = кол-во проходов
{
    for (int j = 1; j < array.Length; j++) // проходимся по сомаму массиву  * илиfor (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j-1] > array[j]) // *Или  if (array[j]>array[j+1])
        {
            int temp = array[j-1];
            array[j-1] = array[j];
            array[j] = temp;
        } 
    }
    WriteLine(i + "["+ string.Join(", ", array) + "]");
}