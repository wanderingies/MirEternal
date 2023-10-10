#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// GuildWarehouseMovePacket
    /// </summary>
    internal class GuildWarehouseMovePacket : Package
    {
        #region public field

public Byte 原有页面;
public Byte 原有位置;
public Byte 目标页面;
public Byte 目标位置;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x023D;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(原有页面);
byteBlock.Write(原有位置);
byteBlock.Write(目标页面);
byteBlock.Write(目标位置);

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

