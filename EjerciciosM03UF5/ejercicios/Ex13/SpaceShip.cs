using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Ex13
{
    internal class SpaceShip
    {
        public List<BoardComputer>  BoardComputer { get; set; }
        public List<Rocket>  Rocket { get; set; }
        public List<NavigationSystem> NavigationSystem { get; set; }
        public List<LandingSystem> LandingSystem { get; set; }
        public List<ACrew> Crew { get; set; }
    }
}
