
void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
}
int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));