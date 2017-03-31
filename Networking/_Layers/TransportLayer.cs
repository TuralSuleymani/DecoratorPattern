using Networking._Layers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking._Layers
{
    public sealed class TransportLayer : Layer
    {
        public TransportLayer() : base() { }
        
        public override LayerDataType GetDataType()
        {
            return LayerDataType.SEGMENT;
        }

        public override int GetHeaderSize()
        {
            return 20;
        }

      
    }
}
