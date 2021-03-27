using SimulANT.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimulANT.Simulant
{
    public class Ant : IAnt
    {
        public Point Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Point> PositionHistory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Vector Velocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Vector Direction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double ViewConeAngle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double ViewRadius { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool LookForFood()
        {
            throw new NotImplementedException();
        }

        public bool PickUpFood()
        {
            throw new NotImplementedException();
        }

        public void RandomWalk()
        {
            throw new NotImplementedException();
        }

        public void UpdatePostion()
        {
            throw new NotImplementedException();
        }
    }
}
