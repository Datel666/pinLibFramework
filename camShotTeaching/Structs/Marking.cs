using camShotTeaching.Structs.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camShotTeaching.Structs
{
    public struct Marking : IMarking
    {
        public int CountPositiveAngles { get; }
        public int CountNegativeAngles { get; }

        public ICollection<Point> PositivePoints { get; }
        public ICollection<Point> NegativePoints { get; }

        public Marking(int minus, int plus) : this()
        {
            CountNegativeAngles = minus;
            CountPositiveAngles = plus;
            PositivePoints = new List<Point>();
            NegativePoints = new List<Point>();
        }

        public Marking(int minus, int plus, ICollection<Point> pointPlus, ICollection<Point> pointMinus) : this(minus, plus)
        {
            PositivePoints = pointPlus;
            NegativePoints = pointMinus;
        }
    }
}
