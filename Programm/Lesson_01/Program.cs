// Алгоритмы в C# . Эффективность алгоритма
// Задача №1: необходимо в массиве узнать максимальную сумму трех элементов идущих подряд.
// First method
using System.Diagnostics;


int size = 10;
int m = 3;
int[] array = Enumerable.Range(1,size)
                        .Select(item =>Random.Shared.Next(10))
                        .ToArray();
Console.WriteLine($"[{string.Join("," ,array)}]");
Stopwatch sw=new();
sw.Start();


//i     V
//   [2,0,3,8,0,5,8,4,7,8]
//j     ^ ^ ^
int max = 0;

for (int i = 0; i < array.Length-m; i++)
{
    int t = 0;
    for (int j = i; j < i+m; j++)
    {
        t+=array[j]; // запись трех чисел t=t+rray[j] 1) 0=0+9 2) 9=9+5 3) 14=14+9 4) 0=0+5 5)11=
        if (t>max) max = t;
        Console.WriteLine($"{i}-j-{(j)}:  {t}");
    }
}


sw.Stop();
Console.WriteLine($"Time = {sw.ElapsedMilliseconds}");
Console.WriteLine(max);

// Second method


// int size = 10;
// int m = 3;

// Stopwatch sw = new();
// sw.Start();

// int max = 0;
// for (int i = 0; i < array.Length - m; i++) // 7
// {
//     int t = 0;
//     for (int j = i; j < i+m; j++) t+= array[j]; // 4 5
//     // Console.WriteLine(t);
//     if ( t > max) max = t;
// }
// sw.Stop();
// Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
// Console.WriteLine(max);


// Third method


// Stopwatch sw = new();
// sw.Start();
// int max = 0;
// for (int i = 0; i < array.Length - m; i++) // 7
// {
//     int t = 0;
//     for (int j = i; j < i+m; j++) t+= array[j]; // 4 5
//     // Console.WriteLine(t);
//     if ( t > max) max = t;
// }
// sw.Stop();




// Stopwatch sw1=new();
// sw1.Start();

// int max1 = 0;

// for (int i = 0; i < array.Length-m; i++)
// {
//     int t1 = 0;
//     for (int j = i; j < i+m; j++)
//     {
//         t1+=array[j]; // запись трех чисел
//         if (t1>max1)
//         {
//             max1 = t1;
//         }
//     }
// }
// sw1.Stop();

// Console.WriteLine($"Time = {sw.ElapsedMilliseconds}, and {max}");

// Console.WriteLine($"time = {sw1.ElapsedMilliseconds}, and {max1}");
