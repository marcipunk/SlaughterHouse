namespace SlaughterHouse
{
    internal class Feldolgozas
    {
        public delegate string FeldolgozasiModszer();

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
        public Feldolgozas(Animal allat, FeldolgozasiModszer feldmod)
        {
            milyenFajta = allat.Breed;
            Modszer = feldmod;
        }




    }
}