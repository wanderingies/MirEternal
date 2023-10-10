#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// ReplaceInscriptionRefinementPacket
    /// </summary>
    internal class ReplaceInscriptionRefinementPacket : Package
    {
        #region public field

public Byte 装备类型;
public Byte 装备位置;
public Int32 Id;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x004C;
        public ushort Size => 8;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(装备类型);
byteBlock.Write(装备位置);
byteBlock.Write(Id);

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

