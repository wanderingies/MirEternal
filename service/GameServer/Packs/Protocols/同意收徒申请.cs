#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// 同意收徒申请
    /// </summary>
    internal class 同意收徒申请 : Package
    {
        #region public field

public Int32 对象编号;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x021B;
        public ushort Size => 6;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(对象编号);

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

