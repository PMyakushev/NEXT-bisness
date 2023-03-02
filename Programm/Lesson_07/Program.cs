const int N = 1000; // размер матрицы (const не позволяет меня размер матрицы)
const THREADS_NUMBER = 4;

int[,] serialMulRes = new int[N,N]; // результат умножения матриц в однопотоке
int[,] threadMulRes = new int[N,N];

int[,] FirstMatrix = MatrixGeneration[N, N];
int[,] SecondMatrix = MatrixGeneration[N, N];

int[,] MatrixGeneration(int row, int columns)
{
    Random _rand = new Random();
    int[,] res = new int[rows, columns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = _rand.Next(-100, 100); // _rand.Next = new Random().Next
        }
    }
    return res;
}

void SerialMatrixMul(int[,] a, int[,] b) // проверка матрицы
{
    if (a.GetLength(1) != b.GetLength(0)) throw new System.Exception("Нельзя умножать такие матрицы");
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int t = 0; t < b.GetLength(0); t++)
            {
                serialMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

void PrepaerParallelMatrixMul(int[,] a,int[,] b) 
{
    if (a.GetLength(1) !=b.GetLength(0)) throw new System.Exception("Нельзя умножать такие матрицы");
    int eachThreadCalc = N / THREADS_NUMBER;
    var threadsList = new List<Thread>();
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        //если последний поток
        if (i == THREADS_NUMBER - 1) endPos = N;
        threadsList.Add(new Thread() =>  )
    }
}
