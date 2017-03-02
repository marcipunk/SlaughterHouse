using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlaughterHouse
{
    class Chicken : Animal
    {

        public Chicken(int code, Breed fajta, double kezdosuly) : base(code, fajta, kezdosuly)
        {
        }

        public override void Eszik(double menny)
        {
            this.weight += menny / 5;
            if (this.weight >= 4)
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
