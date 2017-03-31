using Networking._Layers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking._Layers
{
    public sealed class NetworkLayer : Layer
    {
        public NetworkLayer() : base() { }
        
        public override LayerDataType GetDataType()
        {
            return LayerDataType.PACKET;
        }

        public override int GetHeaderSize()
        {
            return 20;
        }

      
    }
}
