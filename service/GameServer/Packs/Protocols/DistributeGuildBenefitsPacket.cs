#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// DistributeGuildBenefitsPacket
    /// </summary>
    internal class DistributeGuildBenefitsPacket : Package
    {
        #region public field

public Byte 发放方式;
public Int32 发放总额;
public UInt16 发放人数;
public Int32 对象编号;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x00B0;
        public ushort Size => 0;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(发放方式);
byteBlock.Write(发放总额);
byteBlock.Write(发放人数);
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

