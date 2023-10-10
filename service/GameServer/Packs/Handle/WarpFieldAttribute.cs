#pragma warning disable CS0649

namespace GameServer.Packs.Handle
{
    internal class WarpFieldAttribute : Attribute
    {
        public ushort SubScript;
        public ushort Length;
        public bool Reverse;
    }
}
