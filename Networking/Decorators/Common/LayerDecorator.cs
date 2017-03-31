using Networking._Layers;
using Networking._Layers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking.Decorators.Common
{
    public abstract class LayerDecorator:Layer
    {
        protected Layer layer;

        public LayerDecorator(Layer layer)
        {
            this.layer = layer;
            this.Headers = layer.Headers;
        }

        public string GetDataTypeAsString()
        {
            return Enum.GetName(typeof(LayerDataType), (int)this.layer.GetDataType());
        }

        public override LayerDataType GetDataType()
        {
            return this.layer.GetDataType();
        }

        public override int GetHeaderSize()
        {
            return this.layer.GetHeaderSize();
        }
        protected virtual StringBuilder Visualize(LayerDelegate _delegate)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, int> dictionaryItem in Headers)
            {
                sb.Append(_delegate(dictionaryItem.Key, dictionaryItem.Value));
            }
            return sb;
        }

        public abstract void Show();


    }
}
