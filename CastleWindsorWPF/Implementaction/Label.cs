using CastleWindsorWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorWPF.Implementaction
{
    public class Label : ILabel
    {
        public string Text { get; set; }
        public double Size { get; set; }
    }

}
