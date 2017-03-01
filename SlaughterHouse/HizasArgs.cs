using System;

namespace SlaughterHouse
{
    public class HizasArgs : EventArgs
    {

        public Breed milyenfajta;

        public HizasArgs(Breed fajta)
        {
            this.milyenfajta = fajta;
        }

        //internal Animal allat
        //{
        //    get
        //    {
        //        return allat;
        //    }

        //    set
        //    {
        //        allat = value;
        //    }
        //}
    }
}
