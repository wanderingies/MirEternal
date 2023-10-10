#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// ReplaceLowLevelInscriptionsPacket
    /// </summary>
    internal class ReplaceLowLevelInscriptionsPacket : Package
    {
        #region public field

public Byte 装备类型;
public Byte 装备位置;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x004D;
        public ushort Size => 4;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(装备类型);
byteBlock.Write(装备位置);

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

