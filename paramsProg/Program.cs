class Program
{
    private void increases(ref int x){x++;}

    private static void Main(string[] args)
    {
        Program p = new Program();
        int x=10;
        p.increases(ref x);
        Console.WriteLine(x);
    }
}