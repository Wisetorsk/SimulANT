using System;
using System.Collections.Generic;
using System.Text;
using SimulANT.Tools;

namespace SimulANT.Simulant
{
    public interface IAnt
    {
        public Point Position { get; set; }
        public List<Point> PositionHistory { get; set; }
        public double Speed { get; set; }
        public Vector Velocity { get; set; }
        public Vector Direction { get; set; }
        public double ViewConeAngle { get; set; }
        public double ViewRadius { get; set; }

        public void UpdatePostion();
        public void RandomWalk();
        public bool PickUpFood();
        public bool LookForFood(); // See if there is food within vision cone. 

    }
}
