string world = Console.ReadLine();
Console.WriteLine(world);
string[] num = world.Split(",");
int index = new Random().Next(0,world.Length ); 
Console.WriteLine(num[index]);