using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace SlaughterHouse
{
    class Simulator
    {
        private IList<part> parts;
        private IList<Animal> allatoklistaja;
        Random rnd;
        int allatindex;

        internal IList<Animal> Allatoklistaja
        {
            get
            {
                return allatoklistaja;
            }

            private set
            {
                allatoklistaja = value;
            }
        }

        public Simulator(int db)
        {

            parts = new BindingList<part>();
            foreach (parttype item in Enum.GetValues(typeof(parttype)))
            {
                parts.Add(new part());
                parts[parts.Count - 1].PartName = item;
                parts[parts.Count - 1].Quantity = 0;

            }

            allatoklistaja = new List<Animal>();

            rnd = new Random();

            for (int i = 0; i < db; i++)
            {
                allatindex = rnd.Next(3);
                switch (allatindex)
                {
                    case 0:
                        allatoklistaja.Add(new Cow(i, Breed.Cow, 40));
                        break;
                    case 1:
                        allatoklistaja.Add(new Chicken(i, Breed.Chicken, 0.5));
                        break;
                    case 2:
                        allatoklistaja.Add(new Rabbit(i, Breed.Rabbit, 1));
                        break;
                }
            }
        }

        public void Feed (IEat allat)
        {
            int mennyit;
            if (allat is Cow)
            {
                mennyit = rnd.Next(10, 50);
            }
            else if (allat is Chicken)
            {
                mennyit = rnd.Next(1, 3);
            }
            else
            {
                mennyit = rnd.Next(1, 5);
            }
            
            allat.Eszik(mennyit);

        }



    }
}
