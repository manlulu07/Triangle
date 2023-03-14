// See https://aka.ms/new-console-template for more information

/*string name = "";*/

//Console.WriteLine("please enter name :");
//name = Convert.ToString(Console.ReadLine());
//Console.WriteLine($"Hello, {name}");

//Point A

double x = 0;
double y = 0;

Console.WriteLine("Enter coordinate x of dot A: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot A: ");
y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Point A = ({x},{y}) ");

//Point B

double x1 = 0;
double y1 = 0;

Console.WriteLine("Enter coordinate x of dot B: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot B: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Point B = ({x1},{y1}) ");

//Point C

double x2 = 0;
double y2 = 0;

Console.WriteLine("Enter coordinate x of dot C: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot C: ");
y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Point C = ({x2},{y2}) ");

// distance AB

double AB = Math.Sqrt(Math.Pow(x1-x,2) + Math.Pow(y1-y,2));
Console.WriteLine($" AB = {AB}");

// distance BC
double BC = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($" BC = {BC}");

//distance CA
double CA = Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));
Console.WriteLine($" CA = {CA}");

if (AB == BC || BC == CA || CA == BC || CA == AB)
{
    Console.WriteLine("Triangle IS Isosceles");
}
else
{
    Console.WriteLine("Triangle IS NOT Isosceles");
}

if (AB == (BC + CA)/2)
{
    Console.WriteLine("Triangle IS Equilateral");
}
else
{
    Console.WriteLine("Triangle IS NOT Equilateral");
}

if(Math.Round(Math.Pow(BC,2)) == Math.Round(Math.Pow(AB,2)) + Math.Round(Math.Pow(CA,2)) 
    || Math.Round(Math.Pow(AB, 2)) == Math.Round(Math.Pow(BC, 2)) + Math.Round(Math.Pow(CA, 2)) 
    || Math.Round(Math.Pow(CA, 2)) == Math.Round(Math.Pow(AB, 2)) + Math.Round(Math.Pow(BC, 2)))
{
    Console.WriteLine("Triangle IS Right");
}
else
{
    Console.WriteLine("Triangle IS NOT Right");
}
double perimeter = AB + BC + CA;

Console.WriteLine($"Perimeter: {perimeter}");

for (int i = 0; i <= perimeter; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}");
    }
}










