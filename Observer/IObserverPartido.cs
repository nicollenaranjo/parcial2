using linq.Torneo;
using System.Collections.Generic;

namespace Observer
{
    public interface IObserverPartidos
    {
        void update(Partido p);  
    }
}