#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncSkillInfoPacket</para>
    /// <para>SyncSkillInfoPacket</para>
    /// </summary>
    internal class x0012 : Package
    {
        #region public field

		public byte[] 技能描述;
        #endregion

        #region public attribute

        public ushort Type => 0x0012;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(技能描述);
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(WorldSession session)
        {
            
        }
    }
}

