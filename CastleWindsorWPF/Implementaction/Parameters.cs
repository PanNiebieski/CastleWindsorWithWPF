using CastleWindsorWPF.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorWPF.Implementaction
{
    public class Parameter : IParameters, INotifyPropertyChanged
    {
        public int A { get; set; }
        public int B { get; set; }

        private int _c = 0;
        public int Result
        {
            get { return _c; }
            set
            {
                //if (PropertyChanged != null)
                //{
                //    PropertyChanged(this, new PropertyChangedEventArgs("C"));
                //}
                _c = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Result"));


            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
