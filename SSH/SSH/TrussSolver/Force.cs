using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH.TrussSolver
{
    public class Force
    {
        public Force(int totalDofs, List<PointLoad> loadList)
        {
            _totalDofs = totalDofs;
            _loadList = loadList;
        }

        private int _totalDofs;
        private List<PointLoad> _loadList;
        private List<RestrainedNode> _restrainedNodes;


    }
}
