using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace SlaughterHouse
{
    class Butcher : IListener, Isubject
    {
        IList<Feldolgozas> Feldolgozasok;
        SlaughterForm FormPeldanyom = null;
        public List<part> butcherFridge;
        private IList<IListener> listeners;

        public List<part> ButcherFridge
        {
            get
            {
                return butcherFridge;
            }

            set
            {
                butcherFridge = value;
            }
        }

        public Butcher(IList<Animal> allatok, SlaughterForm sf)
        {
            listeners = new List<IListener>();

            this.FormPeldanyom = sf;
            Feldolgozasok = new List<Feldolgozas>();
            Feldolgozasok.Add(new Feldolgozas(Breed.Cow, CowDisassembly));
            foreach (Animal item in allatok)
            {
                item.AddListener(this);
            }

            butcherFridge = new List<part>();

            
            foreach (parttype item in Enum.GetValues(typeof(parttype)))
            {
                butcherFridge.Add(new part());
                butcherFridge[butcherFridge.Count - 1].PartName = item;
                butcherFridge[butcherFridge.Count - 1].Quantity = 0;
            }

            //sf.dGAnimals.DataSource = butcherFridge;

        }

        public void ElerteASulyt(HizasArgs e)
        {
            foreach (Feldolgozas item in Feldolgozasok)
            {
                if (item.MilyenFajta == e.konkretAllat.Breed)
                {
                    //Console.WriteLine("bazdmeg");
                    item.Modszer(butcherFridge);
                    Notify(e);
                    if (this.FormPeldanyom != null)
                    {
                        this.FormPeldanyom.BackColor = System.Drawing.Color.DarkBlue;
                    }
                    //item.Modszer();
                }
            }

            
        }

        public void CowDisassembly(List<part> fridge)
        {
            //Regex cow = new Regex(@"^cow.$");

            //foreach (part item in fridge)
            //{
            //    if (cow.IsMatch(item.PartName.ToString()))
            //    {
            //        item.Quantity += 1;
            //    }
            //}


            fridge[0].Quantity += 1;
            fridge[1].Quantity += 1;

            


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
    }
}
