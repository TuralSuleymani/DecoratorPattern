using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Networking._Layers;
using Networking._Layers.Common;
using Networking.Decorators.Common;

namespace Networking.Decorators
{
    internal class IniLayerDecorator : LayerDecorator
    {
        public IniLayerDecorator(Layer layer) : base(layer) { }

        public override void Show()
        {
           Console.WriteLine(this.Visualize((key, value) => String.Format("{0} = {1}\n", key, value)));
        }
    }
}
