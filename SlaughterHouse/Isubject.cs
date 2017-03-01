

namespace SlaughterHouse


{
    internal interface Isubject
    {
        void AddListener(IListener l);
        void RemoveListener(IListener l);
        void Notify(HizasArgs e);

    }
}