﻿using System;
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

        public Butcher(List<Animal> allatok)
        {
            Feldolgozasok = new List<Feldolgozas>();
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
