#pragma warning disable CS0649
#pragma warning disable CS8618

namespace GameServer.Packs.Handle
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class PackageInfoAttribute : Attribute
    {
        public ushort Id;
        public ushort Length;
        public string Description;
    }
}
