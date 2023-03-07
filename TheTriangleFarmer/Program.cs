Console.WriteLine("I am going to find an area of your triangle");
Console.WriteLine("Please, enter a base of a triangle"); ;
float triangle_base = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Please, enter a height of a triangle");
float height = Convert.ToSingle(Console.ReadLine());
float area = 0.5f * triangle_base * height;
Console.WriteLine($"The area of your triangle is {area}");
Console.ReadLine();