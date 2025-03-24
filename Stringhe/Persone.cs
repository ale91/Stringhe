using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringhe
{
    public class Persone
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }
        public DateTime DataNascita { get; set; }
        public string Indirizzo { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string CAP { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public Persone(string nome, string cognome, string codiceFiscale, DateTime dataNascita, string indirizzo, string citta, string provincia, string cap, string telefono, string email, string note)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
            DataNascita = dataNascita;
            Indirizzo = indirizzo;
            Citta = citta;
            Provincia = provincia;
            CAP = cap;
            Telefono = telefono;
            Email = email;
            Note = note;
        }

        public Persone(string nome, string cogonome, DateTime dataNascita, string indirizzo)
        {
            Nome = nome;
            Cognome = cogonome;
            DataNascita = dataNascita;
            Indirizzo = indirizzo;


        }

        static void StampaLista(List<Persone> lista)
        {
            foreach (Persone p in lista)
            {
                Console.WriteLine($"{p.Nome} {p.Cognome}");
            }
        }

        
        /*public override string ToString()
        {
            return $"{Nome} {Cognome} - {CodiceFiscale} - {DataNascita.ToShortDateString()} - {Indirizzo} - {Citta} - {Provincia} - {CAP} - {Telefono} - {Email} - {Note}";
        }
        */
    }
}
