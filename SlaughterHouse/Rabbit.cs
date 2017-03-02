using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlaughterHouse
{
    class Rabbit : Animal
    {
        public Rabbit(int code, Breed fajta, double kezdosuly) : base(code, fajta, kezdosuly)
        {
        }

        public override void Eszik(double menny)
        {
            this.weight += menny / 3;
            if (this.weight >= 12.5)
            {
                ElerteAVagosulyt();
            }
        }

        protected override void ElerteAVagosulyt()
        {
            Notify(new HizasArgs(this));
        }
    }
}
