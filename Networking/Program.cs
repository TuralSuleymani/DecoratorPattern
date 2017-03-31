using Networking._Layers;
using Networking.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Networking
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkLayer nlayer = new NetworkLayer();
            nlayer.Headers.Add("version", 4);
            nlayer.Headers.Add("IHL", 20);
            nlayer.Headers.Add("TotalLength", 1500);
            nlayer.Headers.Add("Identification", 0x2a15);
            nlayer.Headers.Add("TTL", 128);

            XmlLayerDecorator xmldec = new Decorators.XmlLayerDecorator(nlayer);
            xmldec.Show();
            Console.WriteLine(xmldec.GetDataTypeAsString());

            Console.WriteLine("-------------------------");
            IniLayerDecorator ini = new IniLayerDecorator(nlayer);
             ini.Show();

            Console.WriteLine("-------------------------");
            Ini2LayerDecorator ini2 = new Ini2LayerDecorator(ini);
            ini2.Show();
            Console.WriteLine("----------------------");
            Ini2ExtendedLayerDecorator ini2Extended =
                new Ini2ExtendedLayerDecorator(new Ini2LayerDecorator(nlayer));
            ini2Extended.Show();

            Console.ReadLine(); 
        }
    }
}
