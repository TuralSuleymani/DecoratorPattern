using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking._Layers.Common
{
   public abstract class Layer
    {
        public Dictionary<string, int> Headers { get; set; }

        public Layer()
        {
            Headers = new Dictionary<string, int>();
        }
        public abstract int GetHeaderSize();
        public abstract LayerDataType GetDataType();


    }
}
