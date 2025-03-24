using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDBContext myDb = new MyDBContext())
            {

                var turrets = myDb.Turrets.ToList();
                StampaTurrets(turrets);
            }
        }

        static void StampaTurrets(List<Turrets> turrets)
        {
            //Stampa intestazione tabella
            Console.WriteLine("{0, -10} {1, -20}", "TurretCode", "Description");
            Console.WriteLine(new string('-', 30));

            //Stampa in formato tabellare
            foreach (var turret in turrets)
            {
                Console.WriteLine("{0, -10} {1, -20}", turret.TurretCode, turret.Description);
            }
        }

        
    }
}
