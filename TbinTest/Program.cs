using System;
using System.IO;
using Tbin;

namespace TbinTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map.Load(new FileStream("C:\\Users\\space\\Downloads\\xnbcli-windows-x64\\unpacked\\Maps\\Farm.tbin", FileMode.Open));
            Console.WriteLine("Map: " + map.Id + " - " + map.Description);
            foreach ( var ts in map.TileSheets )
            {
                Console.WriteLine("Tilesheet: " + ts.Id + " - " + ts.Description + " - " + ts.Image);
            }
            foreach ( var layer in map.Layers )
            {
                Console.WriteLine("Layer: " + layer.Id + " - " + layer.Description);
            }
        }
    }
}
