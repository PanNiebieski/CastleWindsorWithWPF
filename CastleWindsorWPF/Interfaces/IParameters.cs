using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorWPF.Interfaces
{
    public interface IParameters
    {
        int A { get; set; }
        int B { get; set; }

        int Result { get; set; }

    }
}
