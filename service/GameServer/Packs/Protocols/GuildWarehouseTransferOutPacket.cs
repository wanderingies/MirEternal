#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// GuildWarehouseTransferOutPacket
    /// </summary>
    internal class GuildWarehouseTransferOutPacket : Package
    {
        #region public field

public Byte 仓库页面;
public Byte 仓库位置;
public Byte 目标容器;
public Byte 目标位置;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x00A6;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(仓库页面);
byteBlock.Write(仓库位置);
byteBlock.Write(目标容器);
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

