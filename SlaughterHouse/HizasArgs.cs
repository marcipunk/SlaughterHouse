using System;

namespace SlaughterHouse
{
    public class HizasArgs : EventArgs
    {

        public Animal konkretAllat;


        public HizasArgs(Animal konkretAllat)
        {
            this.konkretAllat = konkretAllat;
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
