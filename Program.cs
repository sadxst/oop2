using System;
using System.Text;
interface IFunction
{
    void Calculate();
    void Print();
}
abstract class BaseFunction : IFunction, IComparable<BaseFunction>
{
    public double X { get; set; }

    public double Value { get; protected set; }

    public abstract void Calculate();
    public abstract void Print();
    public int CompareTo(BaseFunction other)
    {
        return this.Value.CompareTo(other.Value);
    }
}
class Child1 : BaseFunction
{
    private double a, b;
    public Child1(double a, double b, double x)
    {
        this.a = a;
        this.b = b;
        this.X = x;
        Calculate();
    }
    public override void Calculate()
    {
        Value = a * X + b;
    }
    public override void Print()
    {
        Console.WriteLine($"Лінійна: y = {a}x + {b}, X = {X}, f(X) = {Value:F2}");
    }
}
class Child2 : BaseFunction
{
    private double a, b, c;

    public Child2(double a, double b, double c, double x)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.X = x;
        Calculate();
    }
    public override void Calculate()
    {
        Value = a * X * X + b * X + c;
    }
    public override void Print()
    {
        Console.WriteLine($"Квадратична: y = {a}x² + {b}x + {c}, X = {X}, f(X) = {Value:F2}");
    }
}
class Program
{
    static void Main()
    {
        Random rnd = new Random();
        BaseFunction[] functions = new BaseFunction[10];
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 0; i < functions.Length; i++)
        {
            double x = rnd.Next(-5, 6);
            if (rnd.Next(0, 2) == 0)
            {
                functions[i] = new Child1(a: rnd.Next(-5, 6), b: rnd.Next(-5, 6), x: x);
            }
            else
            {
                functions[i] = new Child2(a: rnd.Next(-3, 4), b: rnd.Next(-3, 4), c: rnd.Next(-3, 4), x: x);
            }
        }
        PrintArray("Змішаний масив:\n", functions);
        Array.Sort(functions);
        PrintArray("\nВідсортований масив:\n", functions);
    }
    static void PrintArray(string title, BaseFunction[] arr)
    {
        Console.WriteLine(title);
        foreach (var f in arr)
        {
            f.Print();
        }
    }
}