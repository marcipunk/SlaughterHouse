using System.Collections.Generic;

namespace SlaughterHouse

{
    internal class Feldolgozas
    {
        public delegate void FeldolgozasiModszer(List<part> fridge);

        private Breed milyenFajta;
        public FeldolgozasiModszer Modszer { get; set; }

        public Breed MilyenFajta
        {
            get
            {
                return milyenFajta;
            }
        }

        /// <summary>
        /// kostruktor
        /// </summary>
        /// <param name="allat"></param>
        /// <param name="feldmod"></param>
        public Feldolgozas(Breed fajta, FeldolgozasiModszer feldmod)
        {
            milyenFajta = fajta;
            Modszer = feldmod;
        }




    }
}