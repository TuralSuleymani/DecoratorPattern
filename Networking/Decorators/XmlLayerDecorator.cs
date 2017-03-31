using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Networking._Layers;
using System.Collections;
using Networking._Layers.Common;
using Networking.Decorators.Common;

namespace Networking.Decorators
{
    public class XmlLayerDecorator : LayerDecorator
    {
        public XmlLayerDecorator(Layer layer) : base(layer) { }

        public override void Show()
        {
            Console.WriteLine("<?xml version='1.0' standalone='yes'?>");
           Console.WriteLine(this.Visualize((key, value) => String.Format("<{0}>{1}</{0}>\n", key, value)));
        }

    }
}
