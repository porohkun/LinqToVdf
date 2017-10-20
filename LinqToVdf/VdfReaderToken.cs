using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToVdf
{
    public enum VdfReaderToken
    {
        Empty,
        Limiter,
        BlockStart,
        BlockEnd,
        Other
    }
}
