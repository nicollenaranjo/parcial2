using System;
using System.Collections.Generic;
using linq.Torneo;

namespace Observer
{
    public class GestorPartido
    {
        #region Properties  
        private List<IObserverPartidos> subs;
        public List<IObserverPartidos> Subs 
        {
            get { return subs; }
            set { subs = value; }
        }
        #endregion Properties  

        #region Initialize
        public GestorPartido()
        {
            Subs = new List<IObserverPartidos>();
        }
        #endregion Initialize

        #region Methods
        public void Subcribe(IObserverPartidos sub)
        {
            Subs.Add(sub);
        }
        public void Unsubcribe(IObserverPartidos sub)
        {
            Subs.Remove(sub);
        }

        public void Notify(Partido p)
        {
            Subs.ForEach( sus => {
                sus.update(p);
            });
        }
        #endregion Methods
    }
}