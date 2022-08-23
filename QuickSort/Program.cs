// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter array length");
int length = int.Parse(Console.ReadLine());
Console.WriteLine();
var array = GenerateArray(length);
Output(array);
Sort(array, 0, array.Length - 1);
Output(array);

int[] GenerateArray(int length)
{
    var ret = new int[length];
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
        ret[i] = rnd.Next(0, 100);

    return ret;
}

void Sort(int[] A, int p, int r)
{
    if (p < r)
    {
        int q = Partition(A, p, r);
        Sort(A, p, q - 1);
        Sort(A, q + 1, r);
    }
}

int Partition(int[] A, int p, int r)
{
    int x = A[r];
    int i = p - 1;
    int buf;
    for (int j = p; j < r; j++)
    {
        if (A[j] <= x)
        {
            i++;
            buf = A[i];
            A[i] = A[j];
            A[j] = buf;
        }
    }
    buf = A[i + 1];
    A[i + 1] = A[r];
    A[r] = buf;
    return i + 1;
}

void Output(int[] arr)
{
    foreach (int i in arr)
        Console.WriteLine(i);
    Console.WriteLine();
}