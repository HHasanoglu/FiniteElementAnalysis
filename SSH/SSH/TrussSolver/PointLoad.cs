using System;
using System.Collections.Generic;
using System.Text;

namespace SSH.TrussSolver
{
    public class PointLoad
    {
        #region Ctor

        public PointLoad(int nodeID, Load load)
        {
            _NodeID = nodeID;
            _load = load;
        }

        #endregion

        #region Private Fields

        private int _NodeID;
        private Load _load;

        #endregion

        #region Public Properties

        public int NodeID { get => _NodeID; set => _NodeID = value; }
        public Load Load { get => _load; set => _load = value; }


        #endregion
    }
}
