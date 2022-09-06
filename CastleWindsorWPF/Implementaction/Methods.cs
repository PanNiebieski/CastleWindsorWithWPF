using CastleWindsorWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CastleWindsorWPF.Implementaction
{
    public class Methods : IMethods
    {
        private ICalculator _calculator;
        public Methods(ICalculator calcaultor)
        {
            _calculator = calcaultor;
            Add = new ModelCommand(_calculator.Add);
            Multi = new ModelCommand(_calculator.Multi);
        }
        public ICommand Add
        {
            get;
        }

        public ICommand Multi
        {
            get;
        }
    }
}
