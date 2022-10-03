// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("В ведите размер массива: ");
int number = int.Parse(Console.ReadLine());                                // Ввод значения пользователем
int[] array = new int[number];
Console.Write("В ведите минимальное положительное трехзначное число: ");     
int numArray = int.Parse(Console.ReadLine());
Console.Write("В ведите максимальное положительное трехзначное число: ");
int numArrayTo = int.Parse(Console.ReadLine());
if (numArray > 0 && numArrayTo > 0)
{
    if (numArray <= 999 && numArray > 99 && numArrayTo <= 999 && numArrayTo > 99)

        for (int i = 0; i < number; i++)
        {
            array[i] = new Random().Next(numArray, numArrayTo);
        }
    else
    {
        Console.WriteLine();
        System.Console.WriteLine("Значения введены не в рамке задачи: " + numArray + "\t" + numArrayTo);
    }
}
else
{
    Console.WriteLine();
    System.Console.WriteLine("Значения введены не в рамке задачи: " + numArray + "\t" + numArrayTo);

}

void PrintArrTo(int[] array )// вывод массива ( для проверки)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i]+ " ");  
}
}
void PrintArray(int[] array)// проверка на четность и вывод количество четных чисел
{
    int count = 0;
   Console.Write("");  
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0) break;
        if (array[i] % 2 == 0)
        {
            count++;
            Console.Write(array[i] + " ");
        }
    }
        Console.Write("]");
    Console.Write(" Количество четных чисел в массиве = " + count);
}
 
PrintArrTo(array);
PrintArray(array);

