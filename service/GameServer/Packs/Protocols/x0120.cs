#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>同步签到信息</para>
    /// <para>同步签到信息</para>
    /// </summary>
    internal class x0120 : Package
    {
        #region public field

        public bool ischeckin;
        public byte checkincount;
        #endregion

        #region public attribute

        public ushort Type => 0x0120;
        public ushort Size => 5;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
            byteBlock.Write(ischeckin);
            byteBlock.Write(checkincount);
            byteBlock.Write(new byte[] { 0 });
            return byteBlock;
        }

        public ByteBlock UnMarshal(ByteBlock byteBlock)
        {
            return byteBlock;
        }

        public void Process(GameSession session)
        {
            
        }
    }
}

