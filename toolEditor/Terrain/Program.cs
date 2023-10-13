using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrain
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = File.ReadAllBytes(@"D:\Legend\v10409\trunk\data\scene\MirSp01\MirSp01.phx");
            var ms = new MemoryStream(buffer);
            var binaryReader = new BinaryReader(ms);

            PHX_HEADER header = new PHX_HEADER()
            {
                nTitle = binaryReader.ReadInt32(),
                nVersion = binaryReader.ReadInt32(),
                nWidth = binaryReader.ReadInt32(),
                nHeight = binaryReader.ReadInt32(),
                nZoneCount = binaryReader.ReadInt32()
            };

            var unknown = binaryReader.ReadBytes(9216);

            List<ZONE_DATA> zones = new List<ZONE_DATA>();

            for (int i = 0; i < header.nZoneCount; i++)
            {
                var zone = new ZONE_DATA()
                {
                    usZoneX = binaryReader.ReadUInt16(),
                    usZoneY = binaryReader.ReadUInt16()
                };

                zone.GroundGrid = new List<ushort>();
                for (int j = 0; j < 16; j++)
                    zone.GroundGrid.Add(binaryReader.ReadUInt16());

                zone.nGridCount = binaryReader.ReadInt32();

                zone.byVolume = new List<byte>();
                for (int j = 0; j < 4; j++)
                    zone.byVolume.Add(binaryReader.ReadByte());

                zone.byDoor = new List<byte>();
                for (int j = 0; j < 4; j++)
                    zone.byDoor.Add(binaryReader.ReadByte());

                zone.wEdge = new List<ushort>();
                for (int j = 0; j < 16; j++)
                    zone.wEdge.Add(binaryReader.ReadUInt16());

                zone.nQuestID = new List<int>();
                for (int j = 0; j < 4; j++)
                    zone.nQuestID.Add(binaryReader.ReadInt32());

                binaryReader.ReadBytes(16);
                zone.byServerPointIndex = binaryReader.ReadByte();

                zone.GridList = new List<GRID_DATA>();
                for (int j = 0; j < zone.nGridCount; j++)
                {
                    var data = new GRID_DATA()
                    {
                        _bf_0 = binaryReader.ReadInt32(),
                        _bf_4 = binaryReader.ReadInt32(),
                        uReserved2 = binaryReader.ReadInt32(),
                        _bf_c = binaryReader.ReadInt32()
                    };

                    zone.GridList.Add(data);
                }

                zones.Add(zone);
            }

            for (int i = 0; i < zones.Count; i++)
            {
                for (int j = 0; j < zones[i].GridList.Count; j++)
                {
                    string txt = $"Matrix[{i},{j}]: {zones[i].GridList[j]._bf_c}\r\n";
                    File.AppendAllText(@"D:\Legend\Client\MMOGame\Content\scene\MirAct36_1\MirAct36_1.txt", txt);
                }
            }

            Console.ReadKey();
        }
    }
}
