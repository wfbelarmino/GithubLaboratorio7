using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    public class Termometro
    {
        private double temperatura;

        public Termometro()
        {
            temperatura = 0.0;
        }

        public double Temperatura
        {

            get
            {
                return temperatura;
            }
        }

        public void Aumentar(double t)
        {
            temperatura += t;
        }

        public void Diminuir(double t)
        {
            temperatura -= t;

        }
    }

}

