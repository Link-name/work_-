//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write("В ведите размер массива: ");
int number = int.Parse(Console.ReadLine());                                // Ввод значения пользователем
int[] array = new int[number];
Console.Write("В ведите минимальное положительное трехзначное число: ");     
int numArray = int.Parse(Console.ReadLine());
Console.Write("В ведите максимальное положительное трехзначное число: ");
int numArrayTo = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            array[i] = new Random().Next(numArray, numArrayTo);
        }   

void PrintArrTo(int[] array )// вывод массива ( для проверки)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i]+ " ");  
}
}
void PrintArray(int[] array)// проверка на нечетность и вывод суммы элементов
{
    int sum = 0;
   Console.WriteLine("");  
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            sum=sum+array[i];
            Console.Write(array[i] + " ");
        }
    }
        Console.Write("]");
    Console.Write(" Сумма не четных элементов в массиве = " + sum);
}
 
PrintArrTo(array);
PrintArray(array);

