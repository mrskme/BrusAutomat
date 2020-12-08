using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomat
{
    class SodaFactory
    {
        private List<Soda> Sodas = new List<Soda>();
        public void MakeSoda(Soda.Types type, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                var NewSoda = new Soda(type);
                Sodas.Add(NewSoda); 
            }
            
        }
        public List<Soda> SendToMaching()
        {
            return Sodas;
        }
    }
}
