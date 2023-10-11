using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrain
{
    public class Scene
    {
        public uint MagicNumber { get; set; }
        public uint Version { get; set; }
        public ushort VertexCount { get; set; }
        public ushort EdgeCount { get; set; }
    }

    public class Vertex
    {
        public uint x { get; set; }
        public uint y { get; set; }
        public uint z { get; set; }
    }

    public class Edge
    {
        public ushort LeftPoint { get; set; }
        public ushort RightPoint { get; set; }
        public ushort PairEdge { get; set; }
        public ushort StartEdge { get; set; }
        public ushort[] LinkEdge { get; set; } = new ushort[31];
        public ushort[] LinkCost { get; set; } = new ushort[31];
    }
}
