string f(int a, int b, int c)
{
    if ((a + b) > c && (b + c) > a && (c + a) > b)
        return "Triangle can exist";
    return "Triangle can't exist";    
}
int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a, b, c));