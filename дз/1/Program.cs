Console.Clear();
Console.WriteLine("Запуск консоли...");
Console.Write ("Введите A ");
int a = int.Parse (Console.ReadLine ()!);

Console.Write ("Введите B ");
int b = int.Parse (Console.ReadLine ()!);
int set = a;

for (int i = 1; i < b; i ++) 
  set = set*a;
 Console.WriteLine($"Равно {set}");