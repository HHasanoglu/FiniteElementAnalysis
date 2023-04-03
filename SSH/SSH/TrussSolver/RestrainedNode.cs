using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSH.TrussSolver
{
    public class RestrainedNode
    {
        private int _nodeID;
        private eRestraintCondition _direction;

        public RestrainedNode(int nodeID, eRestraintCondition direction)
        {
            _nodeID = nodeID;
            _direction = direction;
        }

        public int NodeID { get => _nodeID; set => _nodeID = value; }
        public eRestraintCondition Direction { get => _direction; set => _direction = value; }
    }
}
