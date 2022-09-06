using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorWPF.Interfaces
{
    public interface IMainPageViewModel
    {
        IMainPageModel ViewModel { get; set; }
        IMainPageModel Get();
    }
}
