Console.Clear();
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите координату oX первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату oY первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату oZ первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату oX второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату oY второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату oZ второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние = {Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)):f2}");