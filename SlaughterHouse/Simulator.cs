using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace SlaughterHouse
{
    class Simulator : IListener
    {
        //private IList<part> parts;
        public IList<Animal> allatoklistaja;
        Random rnd;
        int allatindex;
        public Butcher hentes;

        public IList<Animal> Allatoklistaja
        {
            get
            {
                return allatoklistaja;
            }

            set
            {
                allatoklistaja = value;
            }
        }

        //internal IList<part> Parts
        //{
        //    get
        //    {
        //        return parts;
        //    }

        //    private set
        //    {
        //        parts = value;
        //    }
        //}

        public Butcher Hentes
        {
            get
            {
                return hentes;
            }

            set
            {
                hentes = value;
            }
        }

        public Simulator(int db, SlaughterForm sf)
        {

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

            hentes = new Butcher(allatoklistaja, sf);
            Hentes.AddListener(this);

            //STARTFeed();

        }


            public void STARTFeed()
            { 
                for (int j = 0; j < 50; j++)
                {
                    for (int i = 0; i < allatoklistaja.Count; i++)
                    {
                        Feed(allatoklistaja[i]);
                    }
                }
            }





        private void Feed (IEat allat)
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

        public void ElerteASulyt(HizasArgs e)
        {
            foreach (Animal item in allatoklistaja)
            {
                if (item == e.konkretAllat)
                {
                    allatoklistaja.Remove(item);
                    break;
                }
            }
        }
    }
}
