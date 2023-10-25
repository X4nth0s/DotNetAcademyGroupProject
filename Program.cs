public class MiaClasse
{
    private string parametro1;
    private string parametro2;

    public MiaClasse(string parametro1, string parametro2)
    {
        this.parametro1 = parametro1;
        this.parametro2 = parametro2;
    }

       static void Main()
    {
        // Creiamo un'istanza della classe MiaClasse passando dei valori ai parametri del costruttore.
        MiaClasse miaIstanza = new MiaClasse("Davide", "Sgrazzutti");

        // Ora possiamo accedere ai membri della classe utilizzando l'istanza.
        Console.WriteLine("Parametro1: " + miaIstanza.parametro1);
        Console.WriteLine("Parametro2: " + miaIstanza.parametro2);

    }
}
