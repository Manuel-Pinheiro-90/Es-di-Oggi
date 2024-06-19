namespace Es_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //do un valore di lunghezza all'array
            int x = 0;
            Console.WriteLine(" decidi la Grandezza dell'array ");
            x = int.Parse(Console.ReadLine());
            int[] lista = new int[x];
            int i;
            int som = 0;

            //do dei valori agli elementi degli array
            for (i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("inserisci valore del singolo elemento dell'array");
                lista[i] = int.Parse(Console.ReadLine());
            }


            //calcolo la somma dei valori degli array
            for (i = 0; i < lista.Length; i++)
            {
                som += lista[i];
            }
            Console.WriteLine($"\nLa somma è: {som}\n");
            Console.WriteLine($"La media è: {som / x}");
            Console.ReadLine();










        }
    }
}
