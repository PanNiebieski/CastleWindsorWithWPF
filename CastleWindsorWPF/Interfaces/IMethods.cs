using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CastleWindsorWPF.Interfaces
{
    public interface IMethods
    {
        ICommand Add { get; }

        ICommand Multi { get; }
    }
}
