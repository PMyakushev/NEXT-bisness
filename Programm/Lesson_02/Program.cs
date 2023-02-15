// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < 5; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(",", array)+ "]");
// Console.WriteLine(array[3]);


// //[4,5,3,1,2]
// // 0(n)
// // [1,2,3,4,5] -0(n* log n)
// // ((5+1)/2)*5- 0*(1)

// int summa = 0;
// for (int i = 0; i < n; i++)
//     summa +=array[i];

// int n = Convert.ToInt32(Console.ReadLine());

// for(int i= 1; i<=n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write(i*j+"\t");
//     }
//     Console.WriteLine();
//}
// 0(n^2)

// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n,n];
// for(int i= 1; i<=n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         if (i+j <=n)
//             matrix[i,j]=i*j;
//             matrix[j,i]=i*j;
//     }
//     Console.WriteLine();
// }

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,n];
for(int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
    matrix[i,j]=(i+1)*(j+1);
    matrix[j,i]=(i+1)*(j+1);
    }
    Console.WriteLine();
}
for(int i= 0; i<n; i++)
{
    for (int j = 0; j<n; j++)
    {
       Console.Write(matrix[i,j]+"/t");
    //    Console.Write("  "); 
    }
    Console.WriteLine();
}