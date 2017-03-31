using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Networking._Layers.Common;
using Networking.Decorators.Common;

namespace Networking.Decorators
{
    internal class Ini2LayerDecorator : IniLayerDecorator
    {
        public Ini2LayerDecorator(Layer layer) : base(layer) { }
        public override void Show()
        {
            Console.WriteLine(String.Format("{0} = {1}", "iniVersion", "2.0"));
            Console.WriteLine(String.Format("{0} = {1}", "standalone", "yes"));
            base.Show();
        }

        
    }
}
