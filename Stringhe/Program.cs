using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringhe
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creazione lista di stringhe
            List<string> listaStringhe = new List<string>();

            //Aggiunta di elementi alla lista
            listaStringhe.Add("Ciao");
            listaStringhe.Add("Mondo");
            listaStringhe.Add("!");
            Console.WriteLine("Lista di stringhe:");
            StampaLista(listaStringhe);

            //Modifica di un elemento della lista
            listaStringhe[1] = "!!!";
            Console.WriteLine("\nLista di stringhe modificata:");
            StampaLista(listaStringhe);

            //Rimozione di un elemento della lista, esempio rimozione primo elemento
            listaStringhe.RemoveAt(0);
            Console.WriteLine("\nLista di stringhe con primo elemento rimosso:");
            StampaLista(listaStringhe);

        }

        //Stampa tutti gli elementi della lista
        static void StampaLista(List<string> lista)
        {
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }
        }
    }

}