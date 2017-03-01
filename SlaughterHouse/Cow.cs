using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlaughterHouse
{
    class Cow : Animal
    {
        public Cow(int code, Breed fajta, double kezdosuly) : base(code, fajta, kezdosuly)
        {
        }

        public override void Eszik(double menny)
        {
            this.weight += menny / 2;
            if (this.weight >= 230)
            {
                ElerteAVagosulyt();
            }
        }

        protected override void ElerteAVagosulyt()
        {
            Notify(new HizasArgs(Breed.Cow));
        }
    }
}
