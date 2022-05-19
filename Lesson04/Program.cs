// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Clear();
float [] arr = {1.5f, 2,3,4,5};
float max = arr[1];
float min = arr[0];
for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] > max)
    {
        max = arr[i];
    }
    if(arr[i]< min)
    {
        min = arr[i];
    }
}
float res = max-min;
Console.WriteLine(res);





