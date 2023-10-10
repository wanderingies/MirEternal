#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 玩家放入物品
    /// </summary>
    internal class 玩家放入物品 : Package
    {
        #region public field

public Byte 放入位置;
public Byte 放入物品;
public Byte 物品容器;
public Byte 物品位置;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x0096;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(放入位置);
byteBlock.Write(放入物品);
byteBlock.Write(物品容器);
byteBlock.Write(物品位置);

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

