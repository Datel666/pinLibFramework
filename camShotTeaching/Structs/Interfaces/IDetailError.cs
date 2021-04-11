using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camShotTeaching.Structs.Interfaces
{
    public interface IDetailError : IDetail
    {
        int CountError { get; }
        void SetError(int errorCount);
    }
}
