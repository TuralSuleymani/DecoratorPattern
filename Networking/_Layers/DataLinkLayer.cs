using Networking._Layers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking._Layers
{
   public sealed class DataLinkLayer:Layer
    {
        public DataLinkLayer() : base() { }

        public override LayerDataType GetDataType()
        {
            return LayerDataType.FRAME;
        }

        public override int GetHeaderSize()
        {
            return 20;
        }

      
    }
}
