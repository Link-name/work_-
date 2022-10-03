
Console.WriteLine( "Введите размер массива");
int num = int.Parse(Console.ReadLine());
Console.WriteLine( "Введите число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine( "Введите число B");
int b = int.Parse(Console.ReadLine());
int[] array = new int[num];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next();
    if (i > a && i < b) count++;
}
Console.WriteLine("В отрезке от  А   до  B находятся элементов :  " + count );

// Не до конца понял задачу ( нужно было найти идексы или числа которые в деопазоне от 10 до 99 ( между которыми есть числа и посчить их))???