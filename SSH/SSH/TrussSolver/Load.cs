using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH.TrussSolver
{
    public class Load
    {
        private double _xComponent;
        private double _yComponent;

        //public Load(double xComponent, double yComponent)
        //{
        //    _xComponent = xComponent;
        //    _yComponent = yComponent;
        //}

        public double XComponent { get => _xComponent; set => _xComponent = value; }
        public double YComponent { get => _yComponent; set => _yComponent = value; }
    }
}
