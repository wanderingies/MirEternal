#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncSkillFieldsPacket</para>
    /// <para>SyncSkillFieldsPacket</para>
    /// </summary>
    internal class x0013 : Package
    {
        #region public field

		public byte[] 栏位描述;
        #endregion

        #region public attribute

        public ushort Type => 0x0013;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(栏位描述);
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

