#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 玩家镶嵌灵石
    /// </summary>
    internal class 玩家镶嵌灵石 : Package
    {
        #region public field

public Byte 装备类型;
public Byte 装备位置;
public Byte 装备孔位;
public Byte 灵石类型;
public Byte 灵石位置;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x0044;
        public ushort Size => 7;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(装备类型);
byteBlock.Write(装备位置);
byteBlock.Write(装备孔位);
byteBlock.Write(灵石类型);
byteBlock.Write(灵石位置);

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

