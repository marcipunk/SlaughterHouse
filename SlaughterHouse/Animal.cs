using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlaughterHouse
{ public enum Breed { Cow, Chicken, Rabbit}

    abstract class Animal : IEat, Isubject
    {
        protected int code;
        protected Breed fajta;
        protected double weight;
        protected IList<IListener> listeners;

        public int Code
        {
            get
            {
                return code;
            }
        }

        public Breed Breed
        {
            get
            {
                return fajta;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
        }



        public void AddListener(IListener l)
        {
            listeners.Add(l);
        }

        public void Notify(HizasArgs e)
        {
            foreach (IListener listener in listeners)
            {
                listener.ElerteASulyt(e);
            }
        }

        public void RemoveListener(IListener l)
        {
            listeners.Remove(l);
        }

        public abstract void Eszik(double menny);

        private void Hizik(double kg)
        {
          weight+=kg;
        }

        protected Animal(int code, Breed fajta, double kezdosuly)
        {
            this.code = code;
            this.fajta = fajta;
            this.weight = kezdosuly;

            listeners = new List<IListener>();
        }

        protected abstract void ElerteAVagosulyt();


    }
}
