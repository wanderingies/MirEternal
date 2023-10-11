using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrain
{
    internal struct PHX_HEADER
    {

        public int nTitle; // 1885895032
        public int nVersion; // 10
        public int nWidth;
        public int nHeight;
        public int nZoneCount;
    }

    internal struct ZONE_DATA
    {

        public ushort usZoneX;                      // 2 字节
        public ushort usZoneY;                      // 2 字节
        public List<ushort> GroundGrid;               // 16 * 2 字节，总共 32 字节
        public int nGridCount;                      // 4 字节
        public List<byte> byVolume;                    // 4 字节
        public List<byte> byDoor;                      // 4 字节
        public List<ushort> wEdge;                    // 16 * 2 字节，总共 32 字节
        public List<int> nQuestID;                     // 4 * 4 字节，总共 16 字节
        public byte byServerPointIndex;             // 1 字节
        public List<GRID_DATA> GridList;               // 可变大小

    };

    internal struct GRID_DATA
    {
        public int _bf_0;         // 4 字节
        public int _bf_4;         // 4 字节
        public int uReserved2;    // 4 字节
        public int _bf_c;         // 4 字节
    };
}
