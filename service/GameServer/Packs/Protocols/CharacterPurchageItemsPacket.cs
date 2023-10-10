#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// CharacterPurchageItemsPacket
    /// </summary>
    internal class CharacterPurchageItemsPacket : Package
    {
        #region public field

public Int32 StoreId;
public Int32 物品位置;
public UInt16 购入数量;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x0031;
        public ushort Size => 12;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(StoreId);
byteBlock.Write(物品位置);
byteBlock.Write(购入数量);

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

