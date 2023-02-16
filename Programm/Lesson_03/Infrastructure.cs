using static System.Console;
using static System.String;

public static class infrastructure
{
    public static int[] CreateArray(int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
                            .Select(item => Random.Shared.Next(min, max))
                            .ToArray();
    }

    public static void Print(int[] array)
    {
        WriteLine($"[{Join(',', array)}]");
    }
}