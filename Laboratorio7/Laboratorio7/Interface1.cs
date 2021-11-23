using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    public enum IEstadoBinario { Ligado, Desligado };
    interface Interface1
    {
        void Ligar(); void Desligar();
        EstadoBinario Estado { get; }

    }
}
