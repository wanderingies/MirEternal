#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 传承武器铭文
    /// </summary>
    internal class 传承武器铭文 : Package
    {
        #region public field

public Byte 来源类型;
public Byte 来源位置;
public Byte 目标类型;
public Byte 目标位置;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x0047;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(来源类型);
byteBlock.Write(来源位置);
byteBlock.Write(目标类型);
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

