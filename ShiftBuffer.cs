using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViberationScope
{
    class ShiftBuffer<T> : CircularBuffer<T>
    {
        public ShiftBuffer(UInt32 _size)
            : base(_size)
        {
        }
        public override T Get()
        {
            return base.ElementAt(size+indexPut-1);
        }
        public override T ElementAt(uint i)
        {
            return base.ElementAt(i+indexPut);
        }
    }

    class Cell
    {
        ShiftBuffer<double> _delayLine;
        double Average;
        double var;
        double threshold;
        public Cell(UInt32 _delay,double _threshold)
        {
            _delayLine = new ShiftBuffer<double>(_delay);
            threshold = _threshold;
        }
        public double calc(double _s)
        {
            double retVal=0;
            Average = 0.99 * Average + 0.01 * _s;
            var = 0.99 * var + 0.01 * (_s - Average) * (_s - Average);
            double std = Math.Sqrt(var);
            double s = _s;// -Average + std * 2;
            threshold = std*5;
            if (true)//s + _delayLine.Get() > threshold)
            {
                retVal = (s + _delayLine.Get())/2;
                _delayLine.Put(s);
            }
            else
            {
                _delayLine.Put(s);
            }
            return retVal;
        }
    }
}
