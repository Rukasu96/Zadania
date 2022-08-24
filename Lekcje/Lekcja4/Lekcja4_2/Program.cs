class Program
{
    static int Sum(int a, int b)
    {
        return a + b;
    }

    static int Sub(int a, int b)
    {
        return a + b;
    }

    static int Mul(int a, int b)
    {
        return a * b;
    }

    delegate int Operation(int a, int b);
    public static void Main(string[] args)
    {
        //Operation op = Sum;
        //Operation[] operations = { Sum, Sub, Mul, (x, y) => (int)Math.Pow(x, y), (x, y) => { return x / y; } };
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int no = int.Parse(Console.ReadLine());
        //Console.WriteLine(operations[no](a, b));

        Action action = () => Console.WriteLine("Hello");
        action();

        Action<int, int> action2 = (x, y) => Console.WriteLine(x+y);
        action2(5, 9);
    }
}