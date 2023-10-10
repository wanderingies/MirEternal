#pragma warning disable CS8618

using TouchSocket.Core;
using GameServer.Service;

namespace GameServer.Packs.Protocol
{
    /// <summary>
    /// LockItemPacket
    /// </summary>
    internal class LockItemPacket : Package
    {
        #region public field

public Byte BackpackType;
public Byte Unknown;
public Byte Slot;

        public short ResultType;
        public byte[] ResultMessage;
        #endregion

        #region public attribute

        public ushort Type => 0x0061;
        public ushort Size => 5;        
        #endregion
        
        #region private field


        #endregion

        public ByteBlock Marshal(ByteBlock byteBlock)
        {
byteBlock.Write(BackpackType);
byteBlock.Write(Unknown);
byteBlock.Write(Slot);

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

