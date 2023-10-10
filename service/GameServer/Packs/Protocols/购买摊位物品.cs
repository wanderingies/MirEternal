#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 购买摊位物品
    /// </summary>
    internal class 购买摊位物品 : Package
    {
        #region public field

public Int32 对象编号;
public Byte 物品位置;
public UInt16 购买数量;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x0070;
        public ushort Size => 17;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(对象编号);
byteBlock.Write(物品位置);
byteBlock.Write(购买数量);

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

