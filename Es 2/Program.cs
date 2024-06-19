using System.Security;

namespace Es_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomiDiEroi = { "Silvano", "Gregorio", "marco", "cancelmo", "manuel" };
            string name;
            int i;
            bool controllo = false;

            Console.WriteLine("inserisci il nome della persona e scopri se esiste nel nostro array");
            name = Console.ReadLine();

            for (i = 0; i < nomiDiEroi.Length; i++)
            {
                if (nomiDiEroi[i] == name)
                {
                    Console.WriteLine("nome presente possiamo eliminarlo");
                    controllo = true;
                  
                }

            }
            if (controllo == false)
            {
                Console.WriteLine("il nome non esiste ");
                
            }
            Console.ReadLine();
        }
        }
}
