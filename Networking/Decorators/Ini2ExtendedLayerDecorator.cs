using Networking._Layers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking.Decorators
{
   internal class Ini2ExtendedLayerDecorator : Ini2LayerDecorator
    {
        public Ini2ExtendedLayerDecorator(Ini2LayerDecorator layer) : base(layer) { }
        public override void Show()
        {
            Console.WriteLine(String.Format("{0} = {1}", "rootDefined", "false"));
            Console.WriteLine(String.Format("{0} = {1}", "encrypted", "false"));
            (layer as Ini2LayerDecorator).Show();
        }
    }
}
