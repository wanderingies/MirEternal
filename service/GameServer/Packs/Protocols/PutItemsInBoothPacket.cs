#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// PutItemsInBoothPacket
    /// </summary>
    internal class PutItemsInBoothPacket : Package
    {
        #region public field

public Byte 放入位置;
public Byte 物品容器;
public Byte 物品位置;
public UInt16 物品数量;
public Int32 物品价格;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x006B;
        public ushort Size => 11;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(放入位置);
byteBlock.Write(物品容器);
byteBlock.Write(物品位置);
byteBlock.Write(物品数量);
byteBlock.Write(物品价格);

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

