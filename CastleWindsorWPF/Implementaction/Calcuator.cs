using CastleWindsorWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorWPF.Implementaction
{
    public class Calcuator : ICalculator
    {
        private IParameters _parameters;
        public Calcuator(IParameters parameters)
        {
            _parameters = parameters;
        }

        public void Add()
        {
            _parameters.Result = _parameters.A + _parameters.B;
        }

        public void Multi()
        {
            _parameters.Result = _parameters.A * _parameters.B;
        }
    }
}
