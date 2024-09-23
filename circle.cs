using System;
delegate double cir(double n);
class circle
{
    public double diameter(double n)
    {
        double diameter = n * 2;
        return diameter;

    }
    public double circumference(double n)
    {
        double circumference = n * 3.14;
        return circumference;
    }
    public double area(double n)
    {
        double area = n * n * 3.14;
        return area;
    }
    public static void Main(string[] args)
    {
        circle ck = new circle();
        cir[] c = new cir[]{
            ck.diameter,
            ck.circumference,
            ck.area
        };
        double value = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"diameter is : {c[0](value)}");
        Console.WriteLine($"circumference is : {c[1](value)}");
        Console.WriteLine($"The Area is : {c[2](value)}");

    }
}