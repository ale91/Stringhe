using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringhe
{

    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public DateTime DataNascita { get; set; }

        public string CodiceFiscale { get; set; }

        public Persona (string nome, string cognome, DateTime dataNascita, string codiceFiscale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome}, Nato il: {DataNascita.ToShortDateString()}, CodiceFiscale: {CodiceFiscale}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var persone = new List<Persone>(); //creo lista

            var Fabio = new Persone("Fabio", "Farinola", new DateTime(1989,09,27), "abcd"); //creazione persona
            var Mario = new Persone("Mario", "Rossi", new DateTime(1990, 10, 27), "abcd");
            var Luigi = new Persone("Luigi", "Verdi", new DateTime(1991, 08, 18), "abcd");
            var Luca = new Persone("Luca", "Diblasio", new DateTime(1992, 01, 12), "abcd");

            persone.Add(Fabio); //aggiungo persona alla lista
            persone.Add(Mario);
            persone.Add(Luigi);
            persone.Add(Luca);

            /*
            //where
            var t = persone.Where(x => x.Nome.Contains("L")).ToList();

            //ForE\ach
            persone.ForEach(x => x.CAP = "76016");

            var t2 = persone.Select(x => x.Cognome);
            */

            Console.WriteLine("Lista inizale:");
            StampaPersone(persone);

            //Aggiungi nuovo oggetto alla lista
            var Anna = new Persona("Anna", "Bianchi", new DateTime(1993, 05, 21), "efgh");
            persone.Add(Anna);
            Console.WriteLine("\nDopo aggiunta di Anna:");

            //Modifica un oggetto della lista
            var personaDaModificare = persone.FirstOrDefault(p => p.Nome == "Luigi");
            if(personaDaModificare != null)
            {
                personaDaModificare.Cognome = "Rossi";
                personaDaModificare.CodiceFiscale = "ijkl";
            }
            Console.WriteLine("\nDopo modifica di Luigi:");
            StampaPersone(persone);

            //Rimuovi Mario
            RimuoviPersona(persone, "Mario");
            Console.WriteLine("\nLista dopo rimozione:");
            StampaPersone(persone);

            //Ordina la lista per nome
            var personeOrdinate = OrdinaPersonePerNome(persone);
            
        }

        //Stampa tutti gli elementi della lista
        static void StampaPersone(List<Persone> persone)
        {
            //Intestazione tabella
            Console.WriteLine("{0, -10}{1 -10}{2 -20}{3 -20}");
            Console.WriteLine(('-', 30));

            //formato tabellare
            foreach (var persona in persone)
            {
                Console.WriteLine("{0, -10}{1 -10}{2 -20}{3 -20}", persona.Nome, persona.Cognome, persona.DataNascita, persona.CodiceFiscale);
            }
        }

        //Metodo per rimuovere persona da lista in base al nome
        static void RimuoviPersona(List<Persone> persone, string nome)
        {
            //Trova persona con nome specificato
            var personaDaRimuovere = persone.FirstOrDefault(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (personaDaRimuovere!=null)
            {
                persone.Remove(personaDaRimuovere);
                Console.WriteLine($"\n'{nome}' {personaDaRimuovere.Cognome} {personaDaRimuovere.Nome}è stato rimosso dall'elenco.");
            }
            else
            {
                Console.WriteLine($"\nNessuna persona con il nome '{nome}' è nell'elenco.");
            }
        }

        //Metodo per ordinare la lista in base al nome
        static List<Persone> OrdinaPersonePerNome(List<Persone> persone)
        {
            return persone.OrderBy(p => p.Nome).ToList(); //ogni elemento di p nella lista persone, ordina in base alla proprietà Nome
        }
    }

}