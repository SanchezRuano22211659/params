class Program
{
    private static void increases(ref int x){x++;}
    private static void plus(int a, int b, out int c, out int d){c = a+b; d = 2;}
    private static void Main(string[] args)
    {
        int x=10;
        int y=10;
        int resultado, resultado2;
        increases(ref x);
        plus(x,y,out resultado, out resultado2);
        Console.WriteLine(x);
        Console.WriteLine(resultado);
        Console.WriteLine(resultado2);
    }
}