using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    public class TermometroEletrico : Termometro, IEstadoBinario
    {
        private bool ligado = false;

        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            ligado = false;
        }
        public IEstadoBinario Estado
        {

            get
            {



                if (ligado)
                    return IEstadoBinario.Ligado;

                else
                    return IEstadoBinario.Desligado;

            }
        }
    }

}
