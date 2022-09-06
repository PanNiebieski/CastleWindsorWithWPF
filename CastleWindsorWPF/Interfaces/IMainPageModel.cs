using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorWPF.Interfaces
{
    public interface IMainPageModel
    {
        ILabel MainLabel { get; set; }
        ILabel SubLabel { get; set; }

        IMethods Methods { get; set; }

        IParameters Parameters { get; set; }
    }
}
