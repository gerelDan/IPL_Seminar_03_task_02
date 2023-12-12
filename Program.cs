//Задача 2: Задайте массив на 10 целых чисел. Напишите программу,
//которая определяет количество чётных чисел в массиве.
void FillArray(int[] arr, int start, int end)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(start, end);
    }
}
int[] CreateRandomArray(int size, int start, int end)
{
    int[] result = new int[size];
    FillArray(result, start, end);
    return result;
}
int[] arr = CreateRandomArray(10, 1, 100);
Console.WriteLine($"[{string.Join(", ", arr)}]");