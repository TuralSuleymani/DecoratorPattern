using Networking._Layers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking._Layers
{
    public class PhysicalLayer : Layer
    {
        public override LayerDataType GetDataType()
        {
            return LayerDataType.BIT;
        }

        public override int GetHeaderSize()
        {
            return 0;
        }

      
    }
}
