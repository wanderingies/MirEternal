#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// ClickNpcDialogPacket
    /// </summary>
    internal class ClickNpcDialogPacket : Package
    {
        #region public field

public Int32 对象编号;
public Int32 QuestId;
public Int32 Unknown;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x0071;
        public ushort Size => 14;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(对象编号);
byteBlock.Write(QuestId);
byteBlock.Write(Unknown);

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

