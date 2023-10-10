#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 物品转移/交换/合并/更换装备
    /// </summary>
    internal class CharacterTransferItemPacket : Package
    {
        #region public field

public Byte 当前背包;
public Byte 原有位置;
public Byte 目标背包;
public Byte 目标位置;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x002C;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(当前背包);
byteBlock.Write(原有位置);
byteBlock.Write(目标背包);
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

