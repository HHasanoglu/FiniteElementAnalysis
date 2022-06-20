using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH.TrussSolver
{
    class RestrainedNodes
    {
        private int _nodeID;
        private eRestrainedDir _direction;

        public RestrainedNodes(int nodeID, eRestrainedDir direction)
        {
            _nodeID = nodeID;
            _direction = direction;
        }

        public int NodeID { get => _nodeID; set => _nodeID = value; }
        public eRestrainedDir Direction { get => _direction; set => _direction = value; }
    }
}
