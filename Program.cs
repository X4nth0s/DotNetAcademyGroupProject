public class Program
{
    static int a;
    public static void Main(string[] args)
    {
        
        Modelli_Calc calc= new Modelli_Calc(2011);
        string s;
        Console.WriteLine("Inserisci il tuo nome per favore");
        s = Console.ReadLine();
        Console.WriteLine("Ciao " + s + " inserisci un numero");
        a = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= a; i++)
        {
            if (i % 2 == 0){
                Console.WriteLine(i + " è pari");
                Console.WriteLine(Calcolatrice.mult(i,i+1));
            }
                
            else{
                 Console.WriteLine(i + " è dispari");
                 Console.WriteLine(Calcolatrice.sum(i,i+1));
            }
               
        }
        calc.stampa();
    }
}