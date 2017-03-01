using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SlaughterHouse
{
    class Butcher : IListener
    {
        IList<Feldolgozas> Feldolgozasok;

        public Butcher(IList<Animal> allatok)
        {
            Feldolgozasok = new List<Feldolgozas>();
            Feldolgozasok.Add(new Feldolgozas(Breed.Cow, CowDisassembly));
            foreach (Animal item in allatok)
            {
                item.AddListener(this);
            }
        }

        public void ElerteASulyt(HizasArgs e)
        {
            foreach (Feldolgozas item in Feldolgozasok)
            {
                if (item.MilyenFajta == e.milyenfajta)
                {
                    Console.WriteLine("bazdmeg");
                    //item.Modszer();
                }
            }

            
        }

        public void CowDisassembly(List<part> fridge)
        {
            Regex cow = new Regex(@"^cow.$");

            foreach (part item in fridge)
            {
                if (cow.IsMatch(item.PartName.ToString()))
                {
                    item.Quantity += 1;
                }
            }
            
        }

    }
}
