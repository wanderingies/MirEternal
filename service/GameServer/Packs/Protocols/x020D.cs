#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// <para>上传社交信息(已屏蔽)</para>
    /// <para>上传社交信息</para>
    /// </summary>
    internal class x020D : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x020D;
        public ushort Size => 40;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
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

