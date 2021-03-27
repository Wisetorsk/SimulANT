using System;
using System.Collections.Generic;
using System.Text;

namespace SimulANT.Simulant
{
    public interface IPheromone
    {
        int CurrentAge { get; set; }
        int MaxAge { get; set; }
        Ant Source { get; set; }
    }
}
