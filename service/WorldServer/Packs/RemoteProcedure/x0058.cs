#pragma warning disable CS8618

using TouchSocket.Core;
using WorldServer.Service;

namespace WorldServer.Packs.Protocol
{
    /// <summary>
    /// <para>领取师门奖励(已经弃用, 出师时自动结算)</para>
    /// <para>领取师门奖励</para>
    /// </summary>
    internal class x0058 : Package
    {
        #region public field

        #endregion

        #region public attribute

        public ushort Type => 0x0058;
        public ushort Size => 3;        
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

        public void Process(WorldSession session)
        {
            
        }
    }
}

