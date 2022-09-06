using CastleWindsorWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorWPF.Implementaction
{

    public class MainPageModel : IMainPageModel
    {
        public ILabel MainLabel { get; set; }

        public ILabel SubLabel { get; set; }

        public IMethods Methods { get; set; }
        public IParameters Parameters { get; set; }

    }
}
