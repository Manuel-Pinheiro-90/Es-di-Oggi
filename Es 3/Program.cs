namespace Es_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Grandezza Array");
            x = int.Parse(Console.ReadLine());
            int[] lista = new int[x];
            int i;
            int som = 0;
            for (i = 0; i < lista.Length; i++)
            {
                Console.WriteLine("inserisci");
                lista[i] = int.Parse(Console.ReadLine());
            }
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
