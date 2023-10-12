#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>SyncSceneVariablesPacket</para>
    /// <para>SyncSceneVariablesPacket</para>
    /// </summary>
    internal class x00B8 : Package
    {
        #region public field

		public byte[] Data;
        #endregion

        #region public attribute

        public ushort Type => 0x00B8;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
			byteBlock.Write(Data);
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

