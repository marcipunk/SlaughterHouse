namespace SlaughterHouse
{
    enum parttype { cowdug, cowrib, chickenwing, chickenbrest, rabbitear, rabbittail}

    internal class part
    {
        parttype partName;
        int quantity;

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        internal parttype PartName
        {
            get
            {
                return partName;
            }

            set
            {
                partName = value;
            }
        }
    }
}