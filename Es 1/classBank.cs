using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_1
{
    internal class classBank
    {
        public class ContoCorrente
        {
            private string _cognome;
            public string Cognome { get; set; }
            
            private string _nome;
            public string Nome { get; set; }

            private decimal _saldo = 0;
            public decimal Saldo { get; set; }

            private bool _contoAttivo = false;
            public bool ContoAttivo { get; set;}

            public ContoCorrente() { }


            public void menu()
            {
                Console.WriteLine("benvenuto");
                Console.WriteLine("scegli un operazione");
                Console.WriteLine("1 nuovo conto");
                Console.WriteLine("2 versamento");
                Console.WriteLine("3 prelievo");
                Console.WriteLine("4 esci");

                int oraScegli = int.Parse(Console.ReadLine());
                if (oraScegli == 1) { apriConto(); }
                else if (oraScegli == 2) { versamento(); }
                else if (oraScegli == 3) { preleva(); }
                else if (oraScegli == 4) { Console.WriteLine("chiusura"); }
                else { Console.WriteLine ("errore puoi digitare fino a 4 ");
                    tornaHome();
                
                }
            }

            private void apriConto() 
            {
                Console.WriteLine("Cognome ");
                string Cognome =Console.ReadLine();
                Console.WriteLine("Nome ");
                string Nome =Console.ReadLine();
                
                Console.WriteLine("inserisci minimo 1000 euri");
                string Saldo = Console.ReadLine();
                decimal importo = decimal.Parse(Saldo);
                if (importo < 1000)
                { Console.WriteLine("somma minima richiesta"); }
                else
                {
                    ContoCorrente c = new ContoCorrente();
                    {
                        _cognome = Cognome;
                        _nome = Nome;
                        _saldo = 0;
                        _contoAttivo = true;
                        Console.WriteLine($" conto corrente N 1 di {_cognome} {_nome} aperto");
                        menu();
                    }
                }

             
            }





            private void preleva()
            {
                if (_contoAttivo == false)
                {
                    Console.WriteLine("afanguuuuuuulo");
                }
                else
                {
                    Console.WriteLine("prendi Denaro con la carta gialla dello zio peppe");
                    decimal importoPrel = decimal.Parse(Console.ReadLine());
                    if (importoPrel > _saldo)
                    {
                        Console.WriteLine("non hai soldi!!");

                    }
                    else
                    {
                        Console.WriteLine("prelievo fatto");
                        _saldo -= importoPrel;
                        Console.WriteLine($"NUOVO SALDO {_saldo.ToString("N")}");


                    }

                }
            menu();
            

            }

            private void versamento() {
                if (_contoAttivo == false) {
                    Console.WriteLine("Torna quando avrai smesso di essere un pezzente");
                }
                else { Console.WriteLine("inserisci un importo dignitoso");
                decimal soldiVersati = Decimal.Parse(Console.ReadLine());

                    Console.WriteLine("ora siamo più ricchi,  e forse anche tu");
                    _saldo += soldiVersati;
                    Console.WriteLine($"nuovo saldo {_saldo.ToString("N")}");
                 }
                menu();

}

   private void tornaHome() { }









































        }
        


        
        
        
        
        
        
        
        
        
        
        
        
        
      




    }
}
