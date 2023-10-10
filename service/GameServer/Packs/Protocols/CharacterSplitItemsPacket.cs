#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// CharacterSplitItemsPacket
    /// </summary>
    internal class CharacterSplitItemsPacket : Package
    {
        #region public field

public Byte 当前背包;
public Byte 物品位置;
public Byte 目标背包;
public Byte 目标位置;
public UInt16 拆分数量;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x002E;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(当前背包);
byteBlock.Write(物品位置);
byteBlock.Write(目标背包);
byteBlock.Write(目标位置);
byteBlock.Write(拆分数量);

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

