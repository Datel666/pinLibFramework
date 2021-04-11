using camShotTeaching.Structs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camShotTeaching.Structs
{
    public struct Value : IValue
    {
        public double MinValue { get; }
        public int Index { get; }

        public Value(double minValue, int index)
        {
            MinValue = minValue;
            Index = index;
        }
    }
}
