class Program
{
    static void Square(int INTa, float b, float FLOATc, float n)
    {
        b = INTa / 12;
        Console.WriteLine("Par mois le salaire brut est de " + b + "euros");
        n = b * FLOATc;
        Console.WriteLine("Le salaire net est de " + n + "euros");


    }
    static void Main(string[] args)
    {
        string a = args[0];
        string c = args[1];
        int INTa = int.Parse(a);
        float FLOATc = float.Parse(c);
        float b = 0;
        float n = 0;
        Square(INTa, FLOATc, b, n);
        Console.WriteLine("En sachant que le salaire brut annuel est de " + a + "euros");
    }

}

