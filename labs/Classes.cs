#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Shotgun
    {
        private int x, y;
        private static int objectCount = 0;

        public Shotgun()
        {
            this.x = -1;
            this.y = -1;
            objectCount++;
        }

        public Shotgun(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCount++;
        }

        public double DistanceTo(Shotgun other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }

        public static int ObjectCount() => objectCount;
    }
}
