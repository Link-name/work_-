// int [] arrey = new int [10] {2,4,5,6,84,4,4,6,7,8}; 
// int n = arrey.Length;
// for (int i = n -1; i >= 0; i--)
// {
//     Console.Write(arrey[i]);
// }

// Console.WriteLine("Введите количество элементов массива :");
// int numL = int.Parse(Console.ReadLine());
// int [] arrey = new int [numL];
// Console.WriteLine("Введите введите элементы массива /t");
// for (int i = 0; i < arrey.Length; i++)
// {
// // Console.WriteLine($"Введите массив c индесом {i}:\t");
//    arrey[i]=int.Parse(Console.ReadLine());  
// }
// System.Console.WriteLine( "Массив: ");
// Console.Write("[");
// for ( int i = 0; i < arrey.Length-1; i++)
// //System.Console.WriteLine( "Массив: ");
// Console.Write(arrey[i]+ ", " );
// Console.Write(arrey[arrey.Length-1]+ "]");
//  Double[] aMassiv;
//             Console.WriteLine("Введите количество элементов n=");
//             int n = Convert.ToInt32(Console.ReadLine());
//             aMassiv = new Double[n];
//             Random rnd = new Random();
            
//             for (int i = 0; i < aMassiv.Length; i++)
//                 aMassiv[i] = rnd.Next(-10, 10);
            
//             int p1 = 1;//1
//             foreach (int i in aMassiv)
//                 if (i > 0) p1 *= i;
            
//             Console.WriteLine("Произведение положительных элементов массива = " + p1);
 
//             Double min = aMassiv.Min(); //находим мин элемент
//             int p2 = 0;//2
//             foreach (int i in aMassiv)
//                 if (i != min) p2 += i;
//                 else break;
//             Console.WriteLine("Сумма элементов массива, расположенных до минимального элемента = " + p2);
//             foreach (var i in aMassiv)
//             {
//                 Console.Write(string.Format("{0:f3}\t\t", i )); 
//             }
 
//             Console.ReadKey();




string world = Console.ReadLine();
Console.WriteLine(world);
string[] num = world.Split(",");
int index = new Random().Next(0,world.Length ); 
Console.WriteLine(num[index]);