using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace camShotTeaching.Structs
{
    public struct Pattern
    {
        private Point _firstneighbor;
        private Point _secondneighbor;
        public Point FirstNeighbor => _firstneighbor;
        public Point SecondNeighbor => _secondneighbor;

        public Pattern(Point firstneighbor, Point secondneighbor)
        {
            _firstneighbor = firstneighbor;
            _secondneighbor = secondneighbor;
        }
    }
}
