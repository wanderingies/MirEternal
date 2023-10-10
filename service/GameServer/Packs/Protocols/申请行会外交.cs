#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 申请行会外交
    /// </summary>
    internal class 申请行会外交 : Package
    {
        #region public field

public Byte 外交类型;
public Byte 外交时间;
public String GuildName;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x0238;
        public ushort Size => 29;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(外交类型);
byteBlock.Write(外交时间);
byteBlock.Write(GuildName);

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

